using HareEngine;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HareEditor {

    public partial class ActiveBehaviourPrompt : Form {

        public delegate void OnABehaviourSelected(Behaviour t);

        private ActiveBehaviourPrompt() {
            InitializeComponent();
        }

        public static void Prompt(Type type, OnABehaviourSelected obs) {
            ActiveBehaviourPrompt bp = new ActiveBehaviourPrompt();
            bp.BackColor = Program.colorSecondary;
            foreach (GameObject t in Program.editor.currentScene.gameObjects) {
                foreach (Behaviour b in t.behaviours) {
                    if (b.GetType() == type || b.GetType().IsSubclassOf(type)) {
                        Label label = new Label();
                        label.ForeColor = Program.colorFont;
                        label.Text = t.Name;
                        label.Dock = DockStyle.Top;
                        label.Height = 32;
                        label.TextAlign = ContentAlignment.MiddleLeft;
                        label.DoubleClick += (o, e) => {
                            obs?.Invoke(b);
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