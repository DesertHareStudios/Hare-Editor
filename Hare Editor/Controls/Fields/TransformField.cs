using System;
using System.Windows.Forms;
using HareEngine;

namespace HareEditor {

    public partial class TransformField : UserControl {

        public delegate void OnTransformSelected(Transform t);

        public event OnTransformSelected TransformSelected;

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public string ValueText {
            get => lblValue.Text;
            set => lblValue.Text = value;
        }

        public System.Drawing.Color FontColor {
            get => lblText.ForeColor;
            set {
                lblText.ForeColor = value;
                lblValue.ForeColor = value;
            }
        }

        public TransformField() {
            InitializeComponent();
        }

        private void lblValue_Click(object sender, EventArgs e) {
            TransformPrompt.Prompt((t) => {
                lblValue.Text = t.gameObject.Name;
                TransformSelected?.Invoke(t);
            });

        }

    }

}
