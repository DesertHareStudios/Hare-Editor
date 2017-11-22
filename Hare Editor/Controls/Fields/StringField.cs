using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class StringField : UserControl {

        public event EventHandler ValueChanged;

        public string Value {
            get => tbxValue.Text;
            set => tbxValue.Text = value;
        }

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public Color FontColor {
            get => lblText.ForeColor;
            set => lblText.ForeColor = value;
        }

        public StringField() {
            InitializeComponent();
        }

        private void tbxValue_ValueChanged(object sender, EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }

    }

}
