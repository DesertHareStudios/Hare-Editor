using HareEngine;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class AudioClipPrompt : Form {

        public delegate void OnAudioClipSelected(AudioClip t);

        private AudioClipPrompt() {
            InitializeComponent();
        }

        public static void Prompt(OnAudioClipSelected obs) {
            AudioClipPrompt bp = new AudioClipPrompt();
            bp.BackColor = Program.colorSecondary;
            HareEngine.Asset.ForEachAsset<AudioClip>((clip) => {
                Label label = new Label();
                label.ForeColor = Program.colorFont;
                label.Text = clip.Name;
                label.Dock = DockStyle.Top;
                label.Height = 32;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.DoubleClick += (o, e) => {
                    obs?.Invoke(clip);
                    bp.Close();
                };
                label.Click += (o, e) => {
                    foreach (Control c in bp.Controls) {
                        c.BackColor = System.Drawing.Color.Transparent;
                        c.ForeColor = Program.colorFont;
                        label.BackColor = Program.colorAccent;
                        label.ForeColor = Program.colorAccentFont;
                    }
                };
                bp.Controls.Add(label);
            });
            bp.Show();
        }
    }

}