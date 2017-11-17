using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class NumberField : UserControl {

        public event EventHandler ValueChanged;

        public decimal Value {
            get => tbxValue.Value;
            set => tbxValue.Value = value;
        }

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public Color FontColor {
            get => lblText.ForeColor;
            set => lblText.ForeColor = value;
        }

        public NumberField() {
            InitializeComponent();
            tbxValue.DecimalPlaces = 8;
            tbxValue.Minimum = decimal.MinValue;
            tbxValue.Maximum = decimal.MaxValue;
        }

        private void tbxValue_ValueChanged(object sender, EventArgs e) {
            ValueChanged?.Invoke(sender, e);
        }

    }

}
