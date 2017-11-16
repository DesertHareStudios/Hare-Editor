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
    }

}
