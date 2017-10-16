using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor.Controls {

    public partial class Card : UserControl {

        [Description("Title of the card"), Category("Data")]
        public string Title {
            get {
                return title.Text;
            }
            set {
                title.Text = value;
            }
        }

        public override Color ForeColor {
            get {
                return title.ForeColor;
            }
            set {
                title.ForeColor = value;
            }
        }

        public override Color BackColor {
            get {
                return content.ForeColor;
            }
            set {
                content.ForeColor = value;
            }
        }

        public Card() {
            InitializeComponent();
        }
    }

}
