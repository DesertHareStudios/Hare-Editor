using HareEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareEditor {

    public partial class BehaviourPrompt : Form {

        public delegate void OnBehaviourSelected(Type t);

        private BehaviourPrompt() {
            InitializeComponent();
        }

        public static void Prompt(OnBehaviourSelected obs) {
            BehaviourPrompt bp = new BehaviourPrompt();
            bp.BackColor = Program.colorSecondary;
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies()) {
                foreach (Type t in a.GetTypes()) {
                    if (t.IsSubclassOf(typeof(Behaviour))) {
                        Label label = new Label();
                        label.ForeColor = Program.colorFont;
                        label.Text = t.Name;
                        label.Dock = DockStyle.Top;
                        label.Height = 32;
                        label.TextAlign = ContentAlignment.MiddleLeft;
                        label.DoubleClick += (o, e) => {
                            obs?.Invoke(t);
                            bp.Close();
                        };
                        label.Click += (o, e) => {
                            foreach (Control c in bp.Controls) {
                                c.BackColor = System.Drawing.Color.Transparent;
                                c.ForeColor = Program.colorFont;
                                label.BackColor = Program.colorAccent;
                                label.ForeColor = Program.colorAccentFont;
                            }
                        };
                        bp.Controls.Add(label);
                    }
                }
            }
            bp.Show();
        }
    }

}