using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class BehaviourField : UserControl {

        public delegate void OnActiveChanged(bool active);
        public delegate void OnDelete();

        public event OnActiveChanged ActiveChanged;
        public event OnDelete Delete;

        public BehaviourField() {
            InitializeComponent();
        }

        public bool Active {
            get => cbxActive.Checked;
            set => cbxActive.Checked = value;
        }

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public Color FontColor {
            get => lblText.ForeColor;
            set {
                lblText.ForeColor = value;
                btnRemove.ForeColor = value;
            }
        }

        private void cbxActive_CheckedChanged(object sender, EventArgs e) {
            ActiveChanged?.Invoke(cbxActive.Checked);
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            Delete?.Invoke();
        }

    }

}
