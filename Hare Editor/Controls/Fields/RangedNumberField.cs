using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class RangedNumberField : UserControl {

        public event EventHandler ValueChanged;

        public float Value {
            get => tbrValue.Value;
            set => tbrValue.Value = (int)value;
        }

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public Color FontColor {
            get => lblText.ForeColor;
            set => lblText.ForeColor = value;
        }

        public RangedNumberField(HareEngine.Range range) {
            InitializeComponent();
            tbrValue.Minimum = (int)range.Min;
            tbrValue.Maximum = (int)range.Max;
            tbrValue.BackColor = Program.colorSecondary;
        }

        private void tbxValue_ValueChanged(object sender, EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }

    }

}
