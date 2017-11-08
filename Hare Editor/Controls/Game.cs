using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using HareEngine;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace HareEditor {

    public class Game : DBPanel {

        private GLControl glcontrol;
        private Scene backUpScene;
        private Thread t;
        private int sleep = 0;

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
                OpenTK.Toolkit.Init();
                Controls.Clear();
                glcontrol = new GLControl(GraphicsMode.Default, 3, 0, GraphicsContextFlags.ForwardCompatible);
                glcontrol.Dock = DockStyle.Fill;
                glcontrol.MakeCurrent();
                glcontrol.Resize += (o, e) => {
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
                    scene.Preload = () => {
                        Texture tex = new Texture(Directory.GetCurrentDirectory() + "\\logo.png");
                        scene.gameObjects[1].GetComponent<SpriteRenderer>().sprite = tex;
                    };
                    scene.Preload?.Invoke();
                }
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
                            float dump = HareEngine.Random.Value;
                            int delta = (int)(((float)sw.ElapsedMilliseconds / 1000f) / 1000f);
                            sw.Stop();
                            sleep = (1000 / 10) - delta;
                            GL.ClearColor(Hare.clearColor.r, Hare.clearColor.g, Hare.clearColor.b, Hare.clearColor.a);
                            //GL.ClearColor(HareEngine.Random.Value, HareEngine.Random.Value, HareEngine.Random.Value, 1f);
                            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                            scene.Render();
                            glcontrol.SwapBuffers();
                        }
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                };
                t.IsBackground = true;
                t.Start();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

    }

}
