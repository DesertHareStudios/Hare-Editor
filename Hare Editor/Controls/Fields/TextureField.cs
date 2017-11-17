using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class TextureField : UserControl {

        private string tex;

        public string Texture {
            get { return tex; }
            set {
                tex = value;
                try {
                    pnlImage.BackgroundImage = new Bitmap(tex);
                } catch {
                    pnlImage.BackgroundImage = null;
                }
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

        public TextureField() {
            InitializeComponent();
        }

        private void pnlImage_Click(object sender, System.EventArgs e) {
            base.OnClick(e);
        }
    }

}
