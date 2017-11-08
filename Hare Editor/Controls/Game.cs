using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using HareEngine;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace HareEditor {

    public class Game : DBPanel {

        private GLControl glcontrol;
        private Scene backUpScene;
        private Thread t;

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
                if (t != null) {
                    t.Abort();
                }
                t = new Thread(() => {
                    while (true) {
                        Stopwatch sw = Stopwatch.StartNew();
                        if (scene != null) {
                            scene.Render();
                            int deltaMs = (int)(((float)sw.ElapsedMilliseconds / 1000f) / 1000f);
                            sw.Stop();
                            int sleep = (1000 / 60) - deltaMs;
                            glcontrol.SwapBuffers();
                            glcontrol.Invalidate();
                            Thread.Sleep(sleep);
                        }
                    }
                });
                t.IsBackground = true;
                t.Start();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

    }

}
