using System.Windows.Forms;

namespace HareEditor {

    public partial class ImagePrompt : Form {

        private string AssetName = "";
        private OnImageSelected ois;

        private ImagePrompt() {
            InitializeComponent();
        }

        public static void Prompt(string title, OnImageSelected listener) {
            ImagePrompt ip = new ImagePrompt();
            ip.Text = title;
            ip.ois = listener;
            HareEngine.Asset.ForEachAsset((asset) => {
                try {
                    ImagePromptItem ipi = new ImagePromptItem(asset);
                    ipi.Click += (o, e) => {
                        ip.AssetName = asset.Name;
                        ipi.Selected = true;
                        if (ip.AssetName != "") {
                            ip.ois?.Invoke(ip.AssetName);
                        }
                    };
                    ipi.pnlImage.Click += (o, e) => {
                        ip.AssetName = asset.Name;
                        ipi.Selected = true;
                        if (ip.AssetName != "") {
                            ip.ois?.Invoke(ip.AssetName);
                        }
                    };
                    ipi.lblName.Click += (o, e) => {
                        ip.AssetName = asset.Name;
                        ipi.Selected = true;
                        if (ip.AssetName != "") {
                            ip.ois?.Invoke(ip.AssetName);
                        }
                    };
                    ipi.lblSize.Click += (o, e) => {
                        ip.AssetName = asset.Name;
                        ipi.Selected = true;
                        if (ip.AssetName != "") {
                            ip.ois?.Invoke(ip.AssetName);
                        }
                    };
                    ip.pnlWrapper.Controls.Add(ipi);
                } catch {
                    //Not an image asset
                }
            });
            ip.FormClosed += (o, e) => {
                ImagePromptItem.Clear();
            };
            ip.Show();
        }

        public delegate void OnImageSelected(string path);

    }

}