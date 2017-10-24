using System;
using System.Windows.Forms;
using HareEngine;

namespace HareEditor {

    public partial class Editor : Form {

        public ProjectHolder Project;
        public Scene currentScene;
        public GameObject SelectedGameObject;

        public Editor() {
            InitializeComponent();
        }

        public void Init() {
            switch (EditorPrefs.Instance.theme) {
                case Theme.Light:
                    BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = System.Drawing.Color.FromArgb(157, 157, 157);
                    break;
                case Theme.Dark:
                    BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
                    Appbar.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
                    break;
                case Theme.Hybrid:
                    BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
                    break;
            }
            if (currentScene == null) {
                currentScene = new Scene("Untitled");
                GameObject camera = new GameObject("Main Camera");
                camera.AddBehaviour(new Camera(camera));
                camera.AddBehaviour(new AudioListener(camera));
                currentScene.gameObjects.Add(camera);
            }
            Text = "Hare Editor " + EditorPrefs.versionName + " - " +
                currentScene.Name + " - " + Project.Name;
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

        private void Editor_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = DialogResult.No == MessageBox.Show(
                    "Do you really want to exit? Any unsaved changes will be lost.",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
        }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Hide();
      Program.welcome.Show();
    }
  }

}
