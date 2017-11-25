using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using HareEngine;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace HareEditor {

    public class Sceneview : DBPanel {

        public GLControl glcontrol;
        private Scene backUpScene;
        private Thread t;
        private int sleep = 0;

        public GameObject sceneCamera;

        private int ibo_elements;

        Vector3[] vertdata;
        int[] indicedata;
        Vector2[] texdata;

        private ShaderProgram SProgram;

        private Scene scene {
            get {
                if (Program.editor.isRunning) {
                    if (backUpScene == null) {
                        backUpScene = Program.editor.currentScene;
                    }
                    return backUpScene;
                }
                backUpScene = null;
                return Program.editor.currentScene;
            }
        }

        public void MakeCurrent() {
            if (glcontrol != null) {
                glcontrol.MakeCurrent();
                Hare.window.Width = Width;
                Hare.window.Height = Height;
                GL.Viewport(0, 0, Width, Height);
            }
        }

        public void Init() {
            try {
                Hare.Init(Width, Height, "Hare Editor");
                Controls.Clear();
                glcontrol = new GLControl(GraphicsMode.Default, 3, 0, GraphicsContextFlags.ForwardCompatible);
                glcontrol.Dock = DockStyle.Fill;
                glcontrol.MakeCurrent();
                glcontrol.Resize += (o, e) => {
                    Hare.window.Width = Width;
                    Hare.window.Height = Height;
                    GL.Viewport(0, 0, Width, Height);
                };
                Controls.Add(glcontrol);
                GL.Viewport(0, 0, Width, Height);
                if (t != null) {
                    t.Abort();
                }
                if (scene != null) {
                    scene.Preload?.Invoke();
                }
                GL.GenBuffers(1, out ibo_elements);
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
                SProgram = new ShaderProgram(Shader.DefaultVertexShader, Shader.DefaultFragmentShader);

                sceneCamera = new GameObject("Scene Camera");
                sceneCamera.AddBehaviour(new Camera(sceneCamera));
                sceneCamera.GetComponent<Camera>().Render = false;
                sceneCamera.transform.position = new Vector3(0f, 0f, 5f);
                sceneCamera.GetComponent<Camera>().clearColor = new Color(0.618f, 0.618f, 0.618f);

                t = new Thread(() => {
                    while (true) {
                        glcontrol.Invalidate();
                        if (sleep > 0) {
                            Thread.Sleep(sleep);
                        }
                        glcontrol.Visible = !Program.editor.isRunning;
                    }
                });
                glcontrol.Paint += (o, e) => {
                    try {
                        Stopwatch sw = Stopwatch.StartNew();
                        if (scene != null) {
                            float dump = HareEngine.Random.Value;
                            //Update

                            List<Vector3> verts = new List<Vector3>();
                            List<int> inds = new List<int>();
                            List<Vector4> colors = new List<Vector4>();
                            List<Vector2> uvs = new List<Vector2>();

                            int vertcount = 0;
                            scene.ForEachBehaviour<Renderer>((r) => {
                                verts.AddRange(r.GetVerts().ToList());
                                inds.AddRange(r.GetIndices(vertcount).ToList());
                                uvs.AddRange(r.GetUVs().ToList());
                                vertcount += r.VertCount;
                            });

                            vertdata = verts.ToArray();
                            indicedata = inds.ToArray();
                            texdata = uvs.ToArray();

                            GL.BindBuffer(BufferTarget.ArrayBuffer, SProgram.GetBuffer("position"));
                            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(vertdata.Length * Vector3.SizeInBytes), vertdata, BufferUsageHint.StaticDraw);
                            GL.VertexAttribPointer(SProgram.GetAttribute("position"), 3, VertexAttribPointerType.Float, false, 0, 0);

                            if (SProgram.GetAttribute("texcoord") != -1) {
                                GL.BindBuffer(BufferTarget.ArrayBuffer, SProgram.GetBuffer("texcoord"));
                                GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, (IntPtr)(texdata.Length * Vector2.SizeInBytes), texdata, BufferUsageHint.StaticDraw);
                                GL.VertexAttribPointer(SProgram.GetAttribute("texcoord"), 2, VertexAttribPointerType.Float, true, 0, 0);
                            }

                            GL.UseProgram(SProgram.ID);
                            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

                            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
                            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indicedata.Length * sizeof(int)), indicedata, BufferUsageHint.StaticDraw);

                            //Render
                            GL.ClearColor(Hare.clearColor.r, Hare.clearColor.g, Hare.clearColor.b, 1f);
                            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                            GL.Enable(EnableCap.DepthTest);

                            SProgram.EnableVertexAttribArrays();
                            Camera cam = sceneCamera.GetComponent<Camera>();
                            //scene.ForEachBehaviour<Camera>((cam) => {
                            Hare.clearColor = cam.clearColor;
                            int indiceat = 0;
                            scene.ForEachBehaviour<Renderer>((r) => {
                                r.MVPMatrix = r.transform.SetMVPMatrix(cam);
                                if (r.texture != null) {
                                    GL.BindTexture(TextureTarget.Texture2D, r.texture.ID);
                                }
                                GL.UniformMatrix4(SProgram.GetUniform("modelview"), false, ref r.MVPMatrix);

                                if (SProgram.GetAttribute("maintexture") != -1) {
                                    GL.Uniform1(SProgram.GetAttribute("maintexture"), r.texture.ID);
                                }

                                GL.DrawElements(BeginMode.Triangles, r.IndiceCount, DrawElementsType.UnsignedInt, indiceat * sizeof(uint));
                                indiceat += r.IndiceCount;
                            });
                            //});

                            SProgram.DisableVertexAttribArrays();

                            GL.Flush();

                            glcontrol.SwapBuffers();
                            Time.deltaTime = sw.ElapsedMilliseconds / 1000f;
                            int delta = (int)(((float)sw.ElapsedMilliseconds / 1000f) / 1000f);
                            sw.Stop();
                            sleep = (1000 / 10) - delta;
                        }
                    } catch (Exception ex) {
                        HareEngine.Debug.Exception(ex);
                    }
                };

                glcontrol.KeyDown += (o, e) => {
                    if (!Program.editor.isRunning) {
                        Vector3 translator = new Vector3();
                        if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) {
                            translator.Y += 0.1618f;
                        }
                        if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) {
                            translator.X -= 0.1618f;
                        }
                        if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) {
                            translator.Y -= 0.1618f;
                        }
                        if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) {
                            translator.X += 0.1618f;
                        }
                        sceneCamera.transform.Translate(translator);
                    }
                };

                t.IsBackground = true;
                t.Start();
            } catch (Exception e) {
                HareEngine.Debug.Exception(e);
            }
        }

    }

}
