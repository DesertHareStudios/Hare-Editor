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

        private int attrib_pos;
        private int attrib_col;
        private int uniform_mview;

        private int vbo_pos;
        private int vbo_col;
        private int vbo_mview;
        private int ibo_elements;

        Vector3[] vertdata;
        Vector4[] coldata;
        int[] indicedata;

        private int ProgramID;

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
                    GL.Viewport(Location.X, Location.Y, Width, Height);
                    GL.Ortho(-glcontrol.Width / 2, glcontrol.Width / 2, -glcontrol.Height / 2, glcontrol.Height / 2, -1, 1);
                    glcontrol.SwapBuffers();
                };
                Controls.Add(glcontrol);
                GL.Viewport(Location.X, Location.Y, Width, Height);
                GL.Ortho(-glcontrol.Width / 2, glcontrol.Width / 2, -glcontrol.Height / 2, glcontrol.Height / 2, -1, 1);
                if (t != null) {
                    t.Abort();
                }
                if (scene != null) {
                    scene.Preload?.Invoke();
                }
                ProgramID = GL.CreateProgram();
                Shader.DefaultVertexShader.Attach(ProgramID);
                Shader.DefaultFragmentShader.Attach(ProgramID);
                attrib_pos = GL.GetAttribLocation(ProgramID, "position");
                attrib_col = GL.GetAttribLocation(ProgramID, "color");
                uniform_mview = GL.GetUniformLocation(ProgramID, "modelview");

                GL.GenBuffers(1, out vbo_pos);
                GL.GenBuffers(1, out vbo_col);
                GL.GenBuffers(1, out vbo_mview);
                GL.GenBuffers(1, out ibo_elements);


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
                            scene.ForEachRenderer((r) => {
                                verts.AddRange(r.GetVerts().ToList());
                                inds.AddRange(r.GetIndices(vertcount).ToList());
                                colors.AddRange(r.GetColors().ToList());
                                vertcount += r.VertCount;
                            });

                            vertdata = verts.ToArray();
                            indicedata = inds.ToArray();
                            coldata = colors.ToArray();

                            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_pos);
                            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(vertdata.Length * Vector3.SizeInBytes), vertdata, BufferUsageHint.StaticDraw);
                            GL.VertexAttribPointer(attrib_pos, 3, VertexAttribPointerType.Float, false, 0, 0);

                            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_col);
                            GL.BufferData<Vector4>(BufferTarget.ArrayBuffer, (IntPtr)(coldata.Length * Vector4.SizeInBytes), coldata, BufferUsageHint.StaticDraw);
                            GL.VertexAttribPointer(attrib_col, 3, VertexAttribPointerType.Float, true, 0, 0);

                            GL.UseProgram(ProgramID);
                            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
                            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
                            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indicedata.Length * sizeof(int)), indicedata, BufferUsageHint.StaticDraw);

                            //Render
                            GL.Viewport(Location.X, Location.Y, Width, Height);

                            GL.Enable(EnableCap.DepthTest);

                            GL.EnableVertexAttribArray(attrib_pos);
                            GL.EnableVertexAttribArray(attrib_col);

                            int indiceat = 0;

                            scene.ForEachCamera((cam) => {
                                Hare.clearColor = cam.clearColor;
                                scene.ForEachRenderer((r) => {
                                    Matrix4 mvp = r.MVPMatrix(cam);
                                    GL.UniformMatrix4(uniform_mview, false, ref mvp);
                                    GL.DrawElements(BeginMode.Triangles, r.IndiceCount, DrawElementsType.UnsignedInt, indiceat * sizeof(uint));
                                    indiceat += r.IndiceCount;
                                });
                            });

                            GL.DisableVertexAttribArray(attrib_pos);
                            GL.DisableVertexAttribArray(attrib_col);

                            GL.Flush();

                            glcontrol.SwapBuffers();
                            int delta = (int)(((float)sw.ElapsedMilliseconds / 1000f) / 1000f);
                            sw.Stop();
                            sleep = (1000 / 10) - delta;
                        }
                    } catch (Exception ex) {
                        HareEngine.Debug.Error(ex.Message + "\n" + ex.StackTrace);
                    }
                };
                t.IsBackground = true;
                t.Start();
            } catch (Exception e) {
                HareEngine.Debug.Error(e.Message + "\n" + e.StackTrace);
            }
        }

    }

}
