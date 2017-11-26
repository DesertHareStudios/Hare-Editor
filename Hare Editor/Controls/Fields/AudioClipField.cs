using System;
using System.Windows.Forms;
using HareEngine;

namespace HareEditor {

    public partial class AudioClipField : UserControl {

        public delegate void OnClipSelected(AudioClip t);

        public event OnClipSelected ClipSelected;

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

        public AudioClipField() {
            InitializeComponent();
        }

        private void lblValue_Click(object sender, EventArgs e) {
            AudioClipPrompt.Prompt((t) => {
                lblValue.Text = t.Name;
                ClipSelected?.Invoke(t);
            });

        }

    }

}
