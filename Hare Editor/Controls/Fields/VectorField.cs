using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;

namespace HareEditor {

    public partial class VectorField : UserControl {

        public event EventHandler ValueChanged;

        public Vector3 Value {
            get {
                return new Vector3(
                    (float)tbxX.Value,
                    (float)tbxY.Value,
                    (float)tbxZ.Value
                    );
            }
            set {
                tbxX.Value = (decimal)value.X;
                tbxY.Value = (decimal)value.Y;
                tbxZ.Value = (decimal)value.Z;
            }
        }

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public Color FontColor {
            get {
                return lblText.ForeColor;
            }
            set {
                lblText.ForeColor = value;
                lblX.ForeColor = value;
                lblY.ForeColor = value;
                lblZ.ForeColor = value;
            }
        }

        public VectorField() {
            InitializeComponent();
            tbxX.Minimum = decimal.MinValue;
            tbxX.Maximum = decimal.MaxValue;
            tbxY.Minimum = decimal.MinValue;
            tbxY.Maximum = decimal.MaxValue;
            tbxZ.Minimum = decimal.MinValue;
            tbxZ.Maximum = decimal.MaxValue;
        }

        public void OnValueChanged(object sender, EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }

        private void VectorField_Resize(object sender, EventArgs e) {
            int w = (Width - (lblX.Width + lblY.Width + lblZ.Width)) / 3;
            pnlX.Width = w;
            pnlY.Width = w;
            pnlZ.Width = w;
            tbxX.Width = w;
            tbxY.Width = w;
            tbxZ.Width = w;
        }

    }

}
