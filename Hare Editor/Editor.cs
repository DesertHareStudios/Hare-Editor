using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class Editor : Form {

        public ProjectHolder Project;

        public Editor() {
            InitializeComponent();
            switch (EditorPrefs.Instance.theme) {
                case Theme.Light:
                    BackColor = Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = Color.FromArgb(157, 157, 157);
                    break;
                case Theme.Dark:
                    BackColor = Color.FromArgb(37, 37, 37);
                    Appbar.BackColor = Color.FromArgb(15, 15, 15);
                    break;
                case Theme.Hybrid:
                    BackColor = Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = Color.FromArgb(37, 37, 37);
                    break;
            }
        }

        public void Init() {
            Text = "Hare Editor - " + Project.Name;
            //TODO load project contents
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Editor_Resize(object sender, EventArgs e) {
            int fw = wrapperPanel.Width;
            int fh = wrapperPanel.Height;
            dataPanel.Width = fw / 4;
            inspectorPanel.Width = fw / 4;
            hierarchyPanel.Height = fh / 2;
            assetsPanel.Height = fh / 2;
            gameViewPanel.Height = fh / 2;
            scenePanel.Height = fh / 2;
        }
    }

}
