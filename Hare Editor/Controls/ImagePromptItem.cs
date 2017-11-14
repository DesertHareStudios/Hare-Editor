using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace HareEditor {

    public partial class ImagePromptItem : UserControl {

        private static List<ImagePromptItem> items = new List<ImagePromptItem>();
        public static void Clear() {
            items.Clear();
        }

        private bool selected = false;

        public bool Selected {
            get {
                return selected;
            }
            set {
                if (value) {
                    foreach (ImagePromptItem i in items) {
                        if (i != this) {
                            i.Selected = false;
                        }
                    }
                    BackColor = Color.LightSeaGreen;
                } else {
                    BackColor = Color.Transparent;
                }
                selected = value;
            }
        }

        public ImagePromptItem(HareEngine.Asset asset) {
            InitializeComponent();
            Bitmap img = new Bitmap(asset.FilePath);
            pnlImage.BackgroundImage = img;
            lblName.Text = asset.Name;
            lblSize.Text = img.Width + "x" + img.Height;
            items.Add(this);
        }

    }

}
