using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class ColorSelector : Form {

        private Color color = Color.White;
        private OnColorSelected ocs;

        private ColorSelector() {
            InitializeComponent();
            BackColor = Program.colorSecondary;
            lblAlpha.ForeColor = Program.colorFont;
            lblRed.ForeColor = Program.colorFont;
            lblGreen.ForeColor = Program.colorFont;
            lblBlue.ForeColor = Program.colorFont;
        }

        public static void Prompt(string title, Color defaultColor, OnColorSelected listener) {
            ColorSelector cs = new ColorSelector();
            cs.pnlColorPreview.BackColor = defaultColor;
            cs.color = defaultColor;
            cs.ocs = listener;
            cs.Text = title;
            cs.tbxAlpha.Value = defaultColor.A;
            cs.tbxRed.Value = defaultColor.R;
            cs.tbxGreen.Value = defaultColor.G;
            cs.tbxBlue.Value = defaultColor.B;
            cs.Show();
        }

        public delegate void OnColorSelected(HareEngine.Color color);

        private void ValueChanged(object sender, EventArgs e) {
            color = Color.FromArgb(
                    (int)tbxAlpha.Value,
                    (int)tbxRed.Value,
                    (int)tbxGreen.Value,
                    (int)tbxBlue.Value
                );
            pnlColorPreview.BackColor = color;
            ocs?.Invoke(Program.NETColorToHareColor(color));
        }

        private void MainColors_Paint(object sender, PaintEventArgs e) {

        }

        private void Alpha_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < Alpha.Width; i++) {
                Pen p = new Pen(
                  Program.HareColorToNETColor(
                    HareEngine.Color.Lerp(
                      new HareEngine.Color(0f, 0f, 0f),
                      new HareEngine.Color(1f, 1f, 1f),
                      (float)(i + 1f) / (float)Alpha.Width
                      )
                    )
                    );
                e.Graphics.DrawRectangle(p, new Rectangle(i, 0, 1, Alpha.Height));
            }
        }

        private void Alpha_MouseDown(object sender, MouseEventArgs e) {
            color = Color.FromArgb((int)(((float)e.X / (float)Alpha.Width) * 255), color.R, color.G, color.B);
            tbxAlpha.Value = color.A;
            ocs?.Invoke(Program.NETColorToHareColor(color));
        }
    }

}
