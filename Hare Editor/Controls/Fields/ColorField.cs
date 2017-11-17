using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class ColorField : UserControl {

        public Color Color {
            get {
                return Color.FromArgb(
                        pnlAlpha.BackColor.R,
                        pnlColor.BackColor.R,
                        pnlColor.BackColor.G,
                        pnlColor.BackColor.B
                    );
            }
            set {
                pnlColor.BackColor = Color.FromArgb(
                        255,
                        value.R,
                        value.G,
                        value.B
                    );
                pnlAlpha.BackColor = Color.FromArgb(255, value.A, value.A, value.A);
            }
        }

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public Color FontColor {
            get => lblText.ForeColor;
            set => lblText.ForeColor = value;
        }

        public ColorField() {
            InitializeComponent();
        }

        private void pnlColor_Click(object sender, EventArgs e) {
            base.OnClick(e);
        }

    }

}
