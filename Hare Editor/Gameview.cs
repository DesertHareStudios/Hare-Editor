using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareEditor {

    public partial class Gameview : Form {

        public Gameview() {
            InitializeComponent();
            GLControl glcontrol = new GLControl();
            glcontrol.Dock = DockStyle.Fill;
            glcontrol.MakeCurrent();
        }

    }

}
