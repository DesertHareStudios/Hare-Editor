using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace HareEditor {

    public class Game : DBPanel {

        private HareGLControl glcontrol;

        public Game() {
            try {
                glcontrol = new HareGLControl();
                glcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

    }

}
