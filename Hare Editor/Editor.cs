using System;
using System.IO;
using System.Windows.Forms;
using OpenTK;
using HareEngine;
using System.Diagnostics;
using Newtonsoft.Json;

namespace HareEditor {

    public partial class Editor : Form {

        public ProjectHolder Project;
        public Scene currentScene;
        public bool isRunning = false;
        public bool isPaused = false;
        public string scenePath = "";
        private GameObject selectedGameObject;
        public GameObject ContextGO;

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
            HareEngine.Debug.Register((type, msg) => {
                lblLastLog.Text = msg;
            });
        }

        public void SoftReload() {
            BackColor = Program.colorSecondary;
            Appbar.BackColor = Program.colorPrimary;
            lblAssets.BackColor = Program.colorAccentDark;
            lblAssets.ForeColor = Program.colorAccentFont;
            bntAddComponent.BackColor = Program.colorAccentDark;
            bntAddComponent.ForeColor = Program.colorAccentFont;
            lblHierarchy.BackColor = Program.colorAccentDark;
            lblHierarchy.ForeColor = Program.colorAccentFont;
            lblScene.BackColor = Program.colorAccentDark;
            lblScene.ForeColor = Program.colorAccentFont;
            lblInspector.BackColor = Program.colorAccentDark;
            lblInspector.ForeColor = Program.colorAccentFont;
            Text = "Hare Editor v" + Program.CurrentVersion + " - " +
                currentScene.Name + " - " + Project.Name;
            lblScene.Text = currentScene.Name;
            Hierarchy.Reload();
            Inspector.Reload();
            Assets.SoftReload();
        }

        public void Init() {
            if (currentScene == null) {
                currentScene = new Scene("Untitled");

                GameObject camera = new GameObject("Main Camera");
                camera.AddBehaviour(new Camera(camera));
                camera.AddBehaviour(new AudioListener(camera));
                camera.transform.position = new Vector3(0f, 0f, 10f);

                currentScene.gameObjects.Add(camera);

                SelectedGameObject = camera;

            }
            Sceneview.Init();
            SoftReload();
            //TODO load project contents
            Assets.Reload();
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
                switch (MessageBox.Show(
                        "Save changes before closing?",
                        "Save changes",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    )) {
                    case DialogResult.Yes:
                        SaveSceneMenu_Click(sender, e);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
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

        private void CopyMenu_Click(object sender, EventArgs e) {

        }

        private void PasteMenu_Click(object sender, EventArgs e) {

        }

        private void NewSceneMenu_Click(object sender, EventArgs e) {
            if (DialogResult.Yes == MessageBox.Show(
                    "Do you want to save the current scene?",
                    "Save current scene",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question

                )) {
                SaveSceneMenu_Click(sender, e);
            }
            Scene newScene = new Scene("Untitled");
            GameObject camera = new GameObject("Main Camera");
            camera.AddBehaviour(new Camera(camera));
            camera.AddBehaviour(new AudioListener(camera));
            newScene.gameObjects.Add(camera);
            currentScene = newScene;
            SelectedGameObject = null;
            SoftReload();
        }

        private void lightToolStripMenuItem1_Click(object sender, EventArgs e) {
            EditorPrefs.Instance.theme = Theme.Light;
            Program.ReloadColors();
            SoftReload();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e) {
            EditorPrefs.Instance.theme = Theme.Dark;
            Program.ReloadColors();
            SoftReload();
        }

        private void hybridToolStripMenuItem_Click(object sender, EventArgs e) {
            EditorPrefs.Instance.theme = Theme.Hybrid;
            Program.ReloadColors();
            SoftReload();
        }

        private void CameraMenu_Click(object sender, EventArgs e) {
            GameObject camera = new GameObject("Camera");
            camera.AddBehaviour(new Camera(camera));
            camera.AddBehaviour(new AudioListener(camera));
            if (ContextGO != null) {
                camera.transform.parent = ContextGO.transform;
                ContextGO = null;
            }
            currentScene.gameObjects.Add(camera);
            SoftReload();
        }

        private void CreateEmptyMenu_Click(object sender, EventArgs e) {
            if (currentScene != null) {
                GameObject go = new GameObject("New GameObject");
                if (ContextGO != null) {
                    go.transform.parent = ContextGO.transform;
                    ContextGO = null;
                }
                currentScene.gameObjects.Add(go);
                SoftReload();
            }
        }

        private void SpriteMenu_Click(object sender, EventArgs e) {
            if (currentScene != null) {
                GameObject sprite = new GameObject("New Sprite");
                sprite.AddBehaviour(new SpriteRenderer(sprite));
                if (ContextGO != null) {
                    sprite.transform.parent = ContextGO.transform;
                    ContextGO = null;
                }
                currentScene.gameObjects.Add(sprite);
                SoftReload();
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
                if (ContextGO != null) {
                    Cube.transform.parent = ContextGO.transform;
                    ContextGO = null;
                }
                currentScene.gameObjects.Add(Cube);
                SoftReload();
            }
        }

        private void sceneCameraPropertiesToolStripMenuItem_Click(object sender, EventArgs e) {
            SceneCamera.Instance.Show();
        }

        private void bntAddComponent_Click(object sender, EventArgs e) {
            if (selectedGameObject != null) {
                BehaviourPrompt.Prompt((t) => {
                    if (t != null) {
                        selectedGameObject.AddBehaviour((Behaviour)Activator.CreateInstance(t, selectedGameObject));
                        Inspector.Reload();
                    }
                });
            }
        }

        private void SaveSceneMenu_Click(object sender, EventArgs e) {
            if (scenePath == "") {
                SaveASSceneMenu_Click(sender, e);
            } else {
                try {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                    settings.TypeNameHandling = TypeNameHandling.All;
                    settings.Converters.Add(new Vector2Converter());
                    settings.Converters.Add(new Vector3Converter());
                    settings.Converters.Add(new Vector4Converter());
                    settings.Converters.Add(new QuaternionConverter());
                    File.WriteAllText(scenePath, JsonConvert.SerializeObject(currentScene, settings));
                    SoftReload();
                } catch (Exception ex) {
                    HareEngine.Debug.Exception(ex);
                    MessageBox.Show(
                        "Could not save scene. See console(Window/Show Console) for details.",
                        "Error saving file",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void SaveASSceneMenu_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Hare Scene|*.hare";
            sfd.Title = "Save Scene As...";
            sfd.InitialDirectory = Project.Path + "\\Assets";
            sfd.ShowDialog();
            if (sfd.FileName != "") {
                string[] ss = sfd.FileName.Split('\\');
                string s = ss[ss.Length - 1];
                string[] sParts = s.Split('.');
                string name = "";
                for (int i = 0; i < sParts.Length - 1; i++) {
                    name += sParts[i];
                    if (i < sParts.Length - 2) {
                        name += ".";
                    }
                }
                currentScene.Name = name;
                Text = "Hare Editor v" + Program.CurrentVersion + " - " +
                    currentScene.Name + " - " + Project.Name;
                lblScene.Text = currentScene.Name;
                scenePath = sfd.FileName;
                SaveSceneMenu_Click(sender, e);
            }
        }

        private void OpenSceneMenu_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Project.Path + "\\Assets";
            ofd.Title = "Open Scene";
            ofd.Filter = "Hare Scene|*.hare";
            ofd.ShowDialog();
            if (ofd.FileName != "") {
                OpenScene(ofd.FileName, sender, e);
            }
        }

        public void OpenScene(string path) {
            OpenScene(path, this, null);
        }

        public void OpenScene(string path, object sender, EventArgs e) {
            if (DialogResult.Yes == MessageBox.Show(
                    "Do you want to save this scene before?",
                    "Save Scene",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )) {
                SaveSceneMenu_Click(sender, e);
            }
            try {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                settings.TypeNameHandling = TypeNameHandling.All;
                settings.Converters.Add(new Vector2Converter());
                settings.Converters.Add(new Vector3Converter());
                settings.Converters.Add(new Vector4Converter());
                settings.Converters.Add(new QuaternionConverter());
                Scene o = JsonConvert.DeserializeObject<Scene>(File.ReadAllText(path), settings);
                scenePath = path;
                currentScene = o;
                SelectedGameObject = null;
                SoftReload();
            } catch (Exception ex) {
                HareEngine.Debug.Exception(ex);
                MessageBox.Show(
                    "Could not open scene. See console(Window/Show Console) for details.",
                    "Error opening file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void lblLastLog_DoubleClick(object sender, EventArgs e) {
            Console.Instance.Show();
        }

        private void DeleteMenu_Click(object sender, EventArgs e) {
            if (((Control)sender).Tag.GetType() == typeof(GameObject)) {
                currentScene.gameObjects.Remove((GameObject)((Control)sender).Tag);
                SelectedGameObject = null;
                SoftReload();
            }
        }
    }

}
