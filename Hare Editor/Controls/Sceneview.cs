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

        private GLControl glcontrol;
        private Scene backUpScene;
        private Thread t;
        private int sleep = 0;
        private GameObject sceneCamera;

        private int ibo_elements;

        Vector3[] vertdata;
        Vector4[] coldata;
        int[] indicedata;

        private ShaderProgram SProgram;

        public bool isRunning = false;

        private Scene scene {
            get {
                if (isRunning) {
                    if (backUpScene == null) {
                        backUpScene = Program.editor.currentScene;
                    }
                    return backUpScene;
                }
                backUpScene = null;
                return Program.editor.currentScene;
            }
        }

        public void Init() {
            try {
                Hare.Init(Width, Height, "Hare Editor");
                OpenTK.Toolkit.Init();
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
                SProgram = new ShaderProgram(Shader.DefaultVertexShader, Shader.DefaultFragmentShader);

                sceneCamera = new GameObject("Scene Camera");
                sceneCamera.AddBehaviour(new Camera(sceneCamera));
                sceneCamera.transform.position = new Vector3(0f, 0f, 5f);
                sceneCamera.GetComponent<Camera>().clearColor = new Color(0.618f, 0.618f, 0.618f);

                t = new Thread(() => {
                    while (true) {
                        glcontrol.Invalidate();
                        if (sleep > 0) {
                            Thread.Sleep(sleep);
                        }
                    }
                });
                glcontrol.Paint += (o, e) => {
                    try {
                        Stopwatch sw = Stopwatch.StartNew();
                        if (scene != null) {
                            GL.ClearColor(Hare.clearColor.r, Hare.clearColor.g, Hare.clearColor.b, 1f);
                            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                            float dump = HareEngine.Random.Value;
                            //Update

                            List<Vector3> verts = new List<Vector3>();
                            List<int> inds = new List<int>();
                            List<Vector4> colors = new List<Vector4>();

                            int vertcount = 0;
                            scene.ForEachBehaviour<Renderer>((r) => {
                                verts.AddRange(r.GetVerts().ToList());
                                inds.AddRange(r.GetIndices(vertcount).ToList());
                                colors.AddRange(r.GetColors().ToList());
                                vertcount += r.VertCount;
                            });

                            vertdata = verts.ToArray();
                            indicedata = inds.ToArray();
                            coldata = colors.ToArray();

                            GL.BindBuffer(BufferTarget.ArrayBuffer, SProgram.GetBuffer("position"));
                            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(vertdata.Length * Vector3.SizeInBytes), vertdata, BufferUsageHint.StaticDraw);
                            GL.VertexAttribPointer(SProgram.GetAttribute("position"), 3, VertexAttribPointerType.Float, false, 0, 0);

                            if (SProgram.GetAttribute("tint") != -1) {
                                GL.BindBuffer(BufferTarget.ArrayBuffer, SProgram.GetBuffer("tint"));
                                GL.BufferData<Vector4>(BufferTarget.ArrayBuffer, (IntPtr)(coldata.Length * Vector4.SizeInBytes), coldata, BufferUsageHint.StaticDraw);
                                GL.VertexAttribPointer(SProgram.GetAttribute("tint"), 3, VertexAttribPointerType.Float, true, 0, 0);
                            }

                            GL.UseProgram(SProgram.ID);
                            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

                            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
                            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indicedata.Length * sizeof(int)), indicedata, BufferUsageHint.StaticDraw);

                            //Render

                            GL.Enable(EnableCap.DepthTest);

                            SProgram.EnableVertexAttribArrays();
                            //Camera cam = sceneCamera.GetComponent<Camera>();
                            scene.ForEachBehaviour<Camera>((cam) => {
                                Hare.clearColor = cam.clearColor;
                                int indiceat = 0;
                                scene.ForEachBehaviour<Renderer>((r) => {
                                    r.SetMVPMatrix(cam);
                                    GL.UniformMatrix4(SProgram.GetUniform("modelview"), false, ref r.MVPMatrix);
                                    GL.DrawElements(BeginMode.Triangles, r.IndiceCount, DrawElementsType.UnsignedInt, indiceat * sizeof(uint));
                                    indiceat += r.IndiceCount;
                                });
                            });

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
                    HareEngine.Debug.Log(sceneCamera.transform.position.ToString());
                };

                glcontrol.Scroll += (o, e) => {
                    switch (e.ScrollOrientation) {
                        case ScrollOrientation.VerticalScroll:
                            Camera cam = sceneCamera.GetComponent<Camera>();
                            if (cam.viewmode == Viewmode.Perspective) {
                                cam.fov.Value = Mathf.Clamp(cam.fov.Value + (e.NewValue - e.OldValue), 1f, 179f);
                                HareEngine.Debug.Log(cam.fov.ToString());
                            }
                            break;
                        case ScrollOrientation.HorizontalScroll:
                            break;
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
