using HareEngine;
using OpenTK;
using OpenTK.Audio.OpenAL;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace HareEditor {

    public partial class Gameview : Form {

        public GLControl glcontrol;
        private bool init = true;

        private int ibo_elements;

        Vector3[] vertdata;
        int[] indicedata;
        Vector2[] texdata;

        private ShaderProgram SProgram;

        public Scene scene;

        public Gameview() {
            InitializeComponent();
            glcontrol = new GLControl();
            glcontrol.Dock = DockStyle.Fill;
            glcontrol.MakeCurrent();
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

                GL.GenBuffers(1, out ibo_elements);
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
                SProgram = new ShaderProgram(Shader.DefaultVertexShader, Shader.DefaultFragmentShader);

                var version = AL.Get(ALGetString.Version);
                var vendor = AL.Get(ALGetString.Vendor);
                var renderer = AL.Get(ALGetString.Renderer);

                glcontrol.Paint += (o, e) => {
                    try {
                        if (scene != null) {
                            Stopwatch fsw = Stopwatch.StartNew();
                            float dump = HareEngine.Random.Value;
                            try {
                                Input.UpdateData();
                            } catch (Exception ex) {
                                HareEngine.Debug.Exception(ex);
                            }

                            foreach (GameObject go in Hare.aboutToDestroy) {
                                if (go != null) {
                                    go.Active = false;
                                    scene.gameObjects.Remove(go);
                                    go.behaviours.Clear();
                                }
                            }
                            Hare.aboutToDestroy.Clear();

                            scene.ForEachBehaviour<AudioListener>((listener) => {
                                scene.ForEachBehaviour<AudioSource>((source) => {
                                    if (source.clip != null) {
                                        source.SendToBuffer(listener);
                                    }
                                });
                            });

                            scene.FixedUpdate();
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

                            Time.fixedDeltaTime = fsw.ElapsedMilliseconds / 1000f;
                            fsw.Stop();

                            //Render
                            Stopwatch sw = Stopwatch.StartNew();
                            GL.ClearColor(Hare.clearColor.r, Hare.clearColor.g, Hare.clearColor.b, 1f);
                            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                            if (init) {
                                init = false;
                                scene.Awake();
                                scene.Start();
                            }
                            scene.Update();
                            scene.LateUpdate();
                            GL.Enable(EnableCap.DepthTest);

                            SProgram.EnableVertexAttribArrays();
                            scene.ForEachBehaviour<Camera>((cam) => {
                                if (cam.Render) {
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
                                }
                            });

                            SProgram.DisableVertexAttribArrays();

                            GL.Flush();

                            glcontrol.SwapBuffers();
                            Time.deltaTime = sw.ElapsedMilliseconds / 1000f;
                            Time.time += Time.deltaTime;
                            sw.Stop();
                            glcontrol.Invalidate();
                        }
                    } catch (Exception ex) {
                        HareEngine.Debug.Exception(ex);
                    }
                };
            } catch (Exception e) {
                HareEngine.Debug.Exception(e);
            }
        }

        private void Gameview_FormClosed(object sender, FormClosedEventArgs e) {
            Program.editor.isRunning = false;
            Program.editor.Sceneview.MakeCurrent();
        }
    }

}
