using OpenTK;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class ColorSelector : Form {

        private Color color = Color.White;
        private OnColorSelected ocs;
        private bool MovingAlpha = false;
        private bool MovingHue = false;
        private bool MovingColor = false;
        private HareEngine.Color[] hues = new HareEngine.Color[] {
                new HareEngine.Color(1f, 0f, 0f),
                new HareEngine.Color(1f, 1f, 0f),
                new HareEngine.Color(0f, 1f, 0f),
                new HareEngine.Color(0f, 1f, 1f),
                new HareEngine.Color(0f, 0f, 1f),
                new HareEngine.Color(1f, 0f, 1f),
                new HareEngine.Color(1f, 0f, 0f)
            };
        private HareEngine.Color hue;

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
            cs.hue = Program.NETColorToHareColor(defaultColor);
            Vector3 v = cs.hue.Vector3;
            v.Normalize();
            cs.hue = new HareEngine.Color(v.X, v.Y, v.Z);
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
            pnlColorPreview.BackColor = Color.FromArgb(255, color.R, color.G, color.B);
            pnlColorAlphaPreview.BackColor = Color.FromArgb(255, color.A, color.A, color.A);
            ocs?.Invoke(Program.NETColorToHareColor(color));
        }

        private void MainColors_Paint(object sender, PaintEventArgs e) {
            for (int x = 0; x < MainColors.Width; x++) {
                for (int y = 0; y < MainColors.Height; y++) {
                    float rx = HareEngine.Mathf.Clamp((float)x / MainColors.Width, 0f, 1f);
                    float ry = HareEngine.Mathf.Clamp((float)y / MainColors.Height, 0f, 1f);
                    HareEngine.Color xcolor = HareEngine.Color.Lerp(
                            new HareEngine.Color(1f, 1f, 1f),
                            hue,
                            rx
                        );
                    HareEngine.Color pointColor = HareEngine.Color.Lerp(
                            xcolor,
                            new HareEngine.Color(0f, 0f, 0f, 1f),
                            ry
                        );
                    Pen p = new Pen(Program.HareColorToNETColor(pointColor));
                    e.Graphics.DrawRectangle(p, new Rectangle(x, y, 1, 1));
                }
            }
        }

        private void MainColors_MouseDown(object sender, MouseEventArgs e) {
            MovingColor = true;
            float x = HareEngine.Mathf.Clamp((float)e.X / MainColors.Width, 0f, 1f);
            float y = HareEngine.Mathf.Clamp((float)e.Y / MainColors.Height, 0f, 1f);
            HareEngine.Color xcolor = HareEngine.Color.Lerp(
                    new HareEngine.Color(1f, 1f, 1f),
                    hue,
                    x
                );
            HareEngine.Color selColor = HareEngine.Color.Lerp(
                    xcolor,
                    new HareEngine.Color(0f, 0f, 0f, 1f),
                    y
                );
            color = Program.HareColorToNETColor(selColor);
            tbxRed.Value = color.R;
            tbxGreen.Value = color.G;
            tbxBlue.Value = color.B;
        }

        private void MainColors_MouseUp(object sender, MouseEventArgs e) {
            MovingColor = false;
        }

        private void MainColors_MouseMove(object sender, MouseEventArgs e) {
            if (MovingColor) {
                float x = HareEngine.Mathf.Clamp((float)e.X / MainColors.Width, 0f, 1f);
                float y = HareEngine.Mathf.Clamp((float)e.Y / MainColors.Height, 0f, 1f);
                HareEngine.Color xcolor = HareEngine.Color.Lerp(
                        new HareEngine.Color(1f, 1f, 1f),
                        hue,
                        x
                    );
                HareEngine.Color selColor = HareEngine.Color.Lerp(
                        xcolor,
                        new HareEngine.Color(0f, 0f, 0f, 1f),
                        y
                    );
                color = Program.HareColorToNETColor(selColor);
                tbxRed.Value = color.R;
                tbxGreen.Value = color.G;
                tbxBlue.Value = color.B;
            }
        }

        private void Alpha_Paint(object sender, PaintEventArgs e) {
            for (int x = 0; x < Alpha.Width; x++) {
                Pen p = new Pen(
                  Program.HareColorToNETColor(
                    HareEngine.Color.Lerp(
                      new HareEngine.Color(0f, 0f, 0f),
                      new HareEngine.Color(1f, 1f, 1f),
                      (float)x / (float)Alpha.Width
                      )
                    )
                    );
                e.Graphics.DrawRectangle(p, new Rectangle(x, 0, 1, Alpha.Height));
            }
        }


        private void Hue_Paint(object sender, PaintEventArgs e) {
            for (int y = 0; y < Hue.Height; y++) {
                Pen p = new Pen(
                  Program.HareColorToNETColor(
                    HareEngine.Color.Lerp(
                      hues,
                      (float)y / (float)Hue.Height
                      )
                    )
                    );
                e.Graphics.DrawRectangle(p, new Rectangle(0, y, Hue.Width, 1));
            }
        }

        private void Alpha_MouseDown(object sender, MouseEventArgs e) {
            MovingAlpha = true;
            float x = HareEngine.Mathf.Clamp((float)e.X, 0f, Alpha.Width);
            color = Color.FromArgb((int)((x / (float)Alpha.Width) * 255), color.R, color.G, color.B);
            tbxAlpha.Value = color.A;
        }

        private void Alpha_MouseUp(object sender, MouseEventArgs e) {
            MovingAlpha = false;
        }

        private void Hue_MouseDown(object sender, MouseEventArgs e) {
            MovingHue = true;
            float y = HareEngine.Mathf.Clamp((float)e.Y / (float)Hue.Height, 0f, 1f);
            hue = HareEngine.Color.Lerp(hues, y);
            MainColors.Invalidate();
        }

        private void Hue_MouseUp(object sender, MouseEventArgs e) {
            MovingHue = false;
        }

        private void Alpha_MouseMove(object sender, MouseEventArgs e) {
            if (MovingAlpha) {
                float x = HareEngine.Mathf.Clamp((float)e.X, 0f, Alpha.Width);
                color = Color.FromArgb((int)((x / (float)Alpha.Width) * 255), color.R, color.G, color.B);
                tbxAlpha.Value = color.A;
            }
        }

        private void Hue_MouseMove(object sender, MouseEventArgs e) {
            if (MovingHue) {
                float y = HareEngine.Mathf.Clamp((float)e.Y / (float)Hue.Height, 0f, 1f);
                hue = HareEngine.Color.Lerp(hues, y);
                MainColors.Invalidate();
            }
        }

        private void ColorSelector_FormClosed(object sender, FormClosedEventArgs e) {
            ocs?.Invoke(Program.NETColorToHareColor(color));
        }
    }

}
