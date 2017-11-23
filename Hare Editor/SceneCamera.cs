using System;
using System.Windows.Forms;

namespace HareEditor {

    public partial class SceneCamera : Form {

        private static SceneCamera instance;

        public static SceneCamera Instance {
            get {
                if (instance == null) {
                    instance = new SceneCamera();
                }
                return instance;
            }
        }

        private SceneCamera() {
            EnumField viewmode = new EnumField(typeof(Viewmode));
            viewmode.Dock = DockStyle.Top;
            viewmode.Value = Program.editor.Sceneview.sceneCamera.GetComponent<HareEngine.Camera>().viewmode;
            viewmode.Text = "viewmode";
            viewmode.FontColor = Program.colorFont;
            viewmode.ValueChanged += (o, e) => {
                Program.editor.Sceneview.sceneCamera.GetComponent<HareEngine.Camera>().viewmode = (Viewmode)viewmode.Value;
            };
            Controls.Add(viewmode);
            RangedNumberField fov = new RangedNumberField(Program.editor.Sceneview.sceneCamera.GetComponent<HareEngine.Camera>().fov);
            fov.Dock = DockStyle.Top;
            fov.Text = "fov";
            fov.Value = (float)Program.editor.Sceneview.sceneCamera.GetComponent<HareEngine.Camera>().fov.Value;
            fov.FontColor = Program.colorFont;
            fov.ValueChanged += (o, e) => {
                Program.editor.Sceneview.sceneCamera.GetComponent<HareEngine.Camera>().fov.Value = (float)(fov.Value);
            };
            Controls.Add(fov);
            InitializeComponent();
            BackColor = Program.colorSecondary;
            vfPosition.FontColor = Program.colorFont;
            qfRotation.FontColor = Program.colorFont;
            nfOrthoWidth.FontColor = Program.colorFont;
            viewmode.FontColor = Program.colorFont;
            fov.FontColor = Program.colorFont;
            vfPosition.Text = "Position";
            vfPosition.Value = Program.editor.Sceneview.sceneCamera.transform.position;
            qfRotation.Text = "Rotation";
            qfRotation.Value = Program.editor.Sceneview.sceneCamera.transform.rotation;
            nfOrthoWidth.Text = "OrthoWidth";
            nfOrthoWidth.Value = (decimal)Program.editor.Sceneview.sceneCamera.GetComponent<HareEngine.Camera>().OrthoWidth;
        }

        private void nfOrthoWidth_ValueChanged(object sender, EventArgs e) {
            Program.editor.Sceneview.sceneCamera.GetComponent<HareEngine.Camera>().OrthoWidth = (float)nfOrthoWidth.Value;
        }

        private void qfRotation_ValueChanged(object sender, EventArgs e) {
            Program.editor.Sceneview.sceneCamera.transform.rotation = qfRotation.Value;
        }

        private void vfPosition_ValueChanged(object sender, EventArgs e) {
            Program.editor.Sceneview.sceneCamera.transform.position = vfPosition.Value;
        }

        private void SceneCamera_FormClosed(object sender, FormClosedEventArgs e) {
            instance = null;
        }
    }

}
