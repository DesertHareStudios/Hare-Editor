using System;
using System.Windows.Forms;
using HareEngine;

namespace HareEditor {

    public partial class ActiveBehaviourField : UserControl {

        public delegate void OnABehaviourSelected(Behaviour t);

        public event OnABehaviourSelected ABehaviourSelected;

        private Type type;

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

        public ActiveBehaviourField(Type type) {
            InitializeComponent();
            this.type = type;
            if (!type.IsSubclassOf(typeof(Behaviour))) {
                throw new ArgumentException("Type must derive from Behaviour");
            }
        }

        private void lblValue_Click(object sender, EventArgs e) {
            ActiveBehaviourPrompt.Prompt(type, (t) => {
                lblValue.Text = t.gameObject.Name;
                ABehaviourSelected?.Invoke(t);
            });

        }

    }

}
