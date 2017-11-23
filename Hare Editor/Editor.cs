using System;
using System.Windows.Forms;
using OpenTK;
using HareEngine;
using System.Diagnostics;
using System.Threading;
using OpenTK.Graphics;

namespace HareEditor {

    public partial class Editor : Form {

        public ProjectHolder Project;
        public Scene currentScene;
        public bool isRunning = false;
        public bool isPaused = false;
        private GameObject selectedGameObject;

        public GameObject SelectedGameObject {
            get {
                return selectedGameObject;
            }
            set {
                selectedGameObject = value;
                Inspector.Reload();
            }
        }

        public Editor() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void Init() {
            BackColor = Program.colorSecondary;
            Appbar.BackColor = Program.colorPrimary;
            lblAssets.BackColor = Program.colorAccentDark;
            lblAssets.ForeColor = Program.colorAccentFont;
            lblHierarchy.BackColor = Program.colorAccentDark;
            lblHierarchy.ForeColor = Program.colorAccentFont;
            lblScene.BackColor = Program.colorAccentDark;
            lblScene.ForeColor = Program.colorAccentFont;
            lblInspector.BackColor = Program.colorAccentDark;
            lblInspector.ForeColor = Program.colorAccentFont;
            if (currentScene == null) {
                currentScene = new Scene("Untitled");

                GameObject camera = new GameObject("Main Camera");
                camera.AddBehaviour(new Camera(camera));
                camera.AddBehaviour(new AudioListener(camera));
                camera.transform.position = new Vector3(0f, 0f, 5f);

                GameObject sprite = new GameObject("Sprite");
                sprite.AddBehaviour(new SpriteRenderer(sprite));
                sprite.AddBehaviour(new Rigidbody(sprite));
                sprite.AddBehaviour(new PlatformerInput(sprite));

                currentScene.gameObjects.Add(camera);
                currentScene.gameObjects.Add(sprite);

                SelectedGameObject = camera;

            }
            Text = "Hare Editor v" + Program.CurrentVersion + " - " +
                currentScene.Name + " - " + Project.Name;
            //TODO load project contents
            Sceneview.Init();
            Assets.Reload();
            Hierarchy.Reload();
            Inspector.Reload();
        }

        private void Editor_Resize(object sender, EventArgs e) {
            int fw = wrapperPanel.Width;
            int fh = wrapperPanel.Height;
            dataPanel.Width = fw / 4;
            inspectorPanel.Width = fw / 4;
            hierarchyPanel.Height = fh / 2;
            assetsPanel.Height = fh / 2;
            gameViewPanel.Height = fh;
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e) {
            EditorPrefs.Instance.Save();
            if (Visible) {
                e.Cancel = DialogResult.No == MessageBox.Show(
                        "Do you really want to exit? Any unsaved changes will be lost.",
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
            }
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e) {
            Program.Gameview.Close();
            Program.Gameview = null;
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (DialogResult.Yes == MessageBox.Show(
                "Do you really want to exit? Any unsaved changes will be lost.",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )) {
                Hide();
                Program.welcome.Show();
            }
        }

        private void createEmptyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (currentScene != null) {
                currentScene.gameObjects.Add(new GameObject("New GameObject"));
                Hierarchy.Reload();
            }
        }

        private void spriteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (currentScene != null) {
                GameObject sprite = new GameObject("New Sprite");
                sprite.AddBehaviour(new SpriteRenderer(sprite));
                currentScene.gameObjects.Add(sprite);
                Hierarchy.Reload();
            }
        }

        private void CopyMenu_Click(object sender, EventArgs e) {

        }

        private void PasteMenu_Click(object sender, EventArgs e) {

        }

        private void NewSceneMenu_Click(object sender, EventArgs e) {
            Scene newScene = new Scene("Untitled");
            GameObject camera = new GameObject("Main Camera");
            camera.AddBehaviour(new Camera(camera));
            camera.AddBehaviour(new AudioListener(camera));
            newScene.gameObjects.Add(camera);
            currentScene = newScene;
            Hierarchy.Reload();
        }

        private void lightToolStripMenuItem1_Click(object sender, EventArgs e) {
            EditorPrefs.Instance.theme = Theme.Light;
            Program.ReloadColors();
            Init();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e) {
            EditorPrefs.Instance.theme = Theme.Dark;
            Program.ReloadColors();
            Init();
        }

        private void hybridToolStripMenuItem_Click(object sender, EventArgs e) {
            EditorPrefs.Instance.theme = Theme.Hybrid;
            Program.ReloadColors();
            Init();
        }

        private void CameraMenu_Click(object sender, EventArgs e) {
            GameObject camera = new GameObject("Camera");
            camera.AddBehaviour(new Camera(camera));
            camera.AddBehaviour(new AudioListener(camera));
            currentScene.gameObjects.Add(camera);
            Hierarchy.Reload();
        }

        private void CreateEmptyMenu_Click(object sender, EventArgs e) {
            if (currentScene != null) {
                currentScene.gameObjects.Add(new GameObject("New GameObject"));
                Hierarchy.Reload();
            }
        }

        private void SpriteMenu_Click(object sender, EventArgs e) {
            if (currentScene != null) {
                GameObject sprite = new GameObject("New Sprite");
                sprite.AddBehaviour(new SpriteRenderer(sprite));
                currentScene.gameObjects.Add(sprite);
                Hierarchy.Reload();
            }
        }

        private void showInExplorerToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", Project.Path + "\\Assets");
        }

        private void RefreshMenu_Click(object sender, EventArgs e) {
            Init();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            isRunning = !isRunning;
            if (isRunning) {
                Program.Gameview = null;
                Program.Gameview.scene = currentScene;
                Program.Gameview.Init();
                Program.Gameview.Size = this.Sceneview.Size;
                Program.Gameview.Show();
            } else {
                Program.Gameview.Close();
                Program.Gameview = null;
                Sceneview.MakeCurrent();
            }
        }

        private void PauseButton_Click(object sender, EventArgs e) {
            if (isRunning) {
                isPaused = !isPaused;
            }
        }

        private void showConsoleToolStripMenuItem_Click(object sender, EventArgs e) {
            Console.Instance.Show();
        }

        private void CubeMenu_Click(object sender, EventArgs e) {
            if (currentScene != null) {
                GameObject Cube = new GameObject("Cube");
                Cube.AddBehaviour(new CubeRenderer(Cube));
                currentScene.gameObjects.Add(Cube);
                Hierarchy.Reload();
            }
        }

        private void sceneCameraPropertiesToolStripMenuItem_Click(object sender, EventArgs e) {
            SceneCamera.Instance.Show();
        }
    }

}
