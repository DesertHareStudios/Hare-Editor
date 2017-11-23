using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class EnumField : UserControl {

        public event EventHandler ValueChanged;

        private Type enumType;

        public Type EnumType {
            get {
                return enumType;
            }
            set {
                if (!value.IsEnum) {
                    throw new ArgumentException("Type T must be an Enum");
                }
                enumType = value;
            }
        }

        public object Value {
            get {
                return Enum.Parse(EnumType, cbxValue.Text);
            }
            set {
                if (value.GetType() != EnumType) {
                    throw new ArgumentException("Type T must be an Enum");
                }
                if (value != null) {
                    cbxValue.SelectedItem = Enum.GetName(EnumType, value);
                } else {
                    cbxValue.SelectedIndex = 0;
                }
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
            }
        }

        public EnumField(Type enumtype) {
            InitializeComponent();
            EnumType = enumtype;
            var all = Enum.GetValues(EnumType);
            foreach (var e in all) {
                cbxValue.Items.Add(Enum.GetName(EnumType, e));
            }
        }

        private void cbxValue_SelectedIndexChanged(object sender, EventArgs e) {
            ValueChanged?.Invoke(this, e);
        }

    }

}
