using HareEngine;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class TransformPrompt : Form {

        public delegate void OnTransformSelected(Transform t);

        private TransformPrompt() {
            InitializeComponent();
        }

        public static void Prompt(OnTransformSelected obs) {
            TransformPrompt bp = new TransformPrompt();
            bp.BackColor = Program.colorSecondary;
            foreach (GameObject t in Program.editor.currentScene.gameObjects) {
                Label label = new Label();
                label.ForeColor = Program.colorFont;
                label.Text = t.Name;
                label.Dock = DockStyle.Top;
                label.Height = 32;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.DoubleClick += (o, e) => {
                    obs?.Invoke(t.transform);
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
            }
            bp.Show();
        }
    }

}