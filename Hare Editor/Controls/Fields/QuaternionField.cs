using System;
using System.Windows.Forms;
using OpenTK;
using HareEngine;

namespace HareEditor {

    public partial class QuaternionField : UserControl {

        public event EventHandler ValueChanged;

        public Quaternion Value {
            get {
                return Quaternion.FromEulerAngles(
                    Mathf.ToRadians((float)tbxZ.Value),
                    Mathf.ToRadians((float)tbxY.Value),
                    Mathf.ToRadians((float)tbxX.Value)
                    );
            }
            set {
                Vector3 v = Mathf.GetEulerAngles(value);
                tbxX.Value = (decimal)v.X;
                tbxY.Value = (decimal)v.Y;
                tbxZ.Value = (decimal)v.Z;
            }
        }

        public override string Text {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        public System.Drawing.Color FontColor {
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

        public QuaternionField() {
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

        private void QuaternionField_Resize(object sender, EventArgs e) {
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
