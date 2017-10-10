using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareEditor {

    static class Program {

        private static Editor _editor;

        public static Editor editor {
            get {
                if (_editor == null) {
                    _editor = new Editor();
                }
                return _editor;
            }
        }

        public static Welcome welcome;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }

        public static System.Drawing.Color HareColorToNETColor(HareEngine.Color color) {
            return System.Drawing.Color.FromArgb(
                    (int)(color.a * 255),
                    (int)(color.r * 255),
                    (int)(color.g * 255),
                    (int)(color.b * 255)
                );
        }

    }

}
