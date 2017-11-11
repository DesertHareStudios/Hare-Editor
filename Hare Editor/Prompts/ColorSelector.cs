using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class ColorSelector : Form {

        private Color color = Color.White;
        private OnColorSelected ocs;

        private ColorSelector() {
            InitializeComponent();
        }

        public static void Prompt(string title, Color defaultColor, OnColorSelected listener) {
            ColorSelector cs = new ColorSelector();
            cs.Show();
            cs.color = defaultColor;
            cs.ocs = listener;
            cs.Text = title;
            cs.tbxAlpha.Value = cs.color.A;
            cs.tbxRed.Value = cs.color.R;
            cs.tbxGreen.Value = cs.color.G;
            cs.tbxBlue.Value = cs.color.B;
            cs.Location = new Point(
                    (Program.editor.Location.X + Program.editor.Width) / 2 - (cs.Width / 2),
                    (Program.editor.Location.Y + Program.editor.Height) / 2 - (cs.Height / 2)
                );
            cs.FormClosed += (o, e) => {
                cs.ocs?.Invoke(Program.NETColorToHareColor(cs.color));
            };
        }

        public delegate void OnColorSelected(HareEngine.Color color);

        private void ValueChanged(object sender, EventArgs e) {
            color = Color.FromArgb(
                    (int)tbxAlpha.Value,
                    (int)tbxRed.Value,
                    (int)tbxGreen.Value,
                    (int)tbxBlue.Value
                );
            ocs?.Invoke(Program.NETColorToHareColor(color));
        }
    }

}
