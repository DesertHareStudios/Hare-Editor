using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HareEditor {

    public class Assets : DBPanel {

        private List<Label> toAdd = new List<Label>();

        public void Reload() {
            Controls.Clear();
            string x = "";
            string path = Program.editor.Project.Path + "\\Assets\\";
            RecursiveFiles(path, x);
            for (int i = toAdd.Count - 1; i >= 0; i--) {
                Controls.Add(toAdd[i]);
            }
            toAdd.Clear();
        }

        private void RecursiveFiles(string path, string x) {
            string[] subdirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string rs in subdirs) {
                string[] ss = rs.Split('\\');
                string s = ss[ss.Length - 1];
                Print(s, x);
                RecursiveFiles(path + "\\" + s, x + "  ");
            }
            foreach (string rs in files) {
                string[] ss = rs.Split('\\');
                string s = ss[ss.Length - 1];
                Print(s, x);
            }
        }

        private void Print(string t, string x) {
            Label label = new Label();
            label.Text = x + t;
            label.Dock = DockStyle.Top;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.ForeColor = Program.editor.FontColor1;
            label.BackColor = System.Drawing.Color.Transparent;
            label.Click += (o, e) => {
                this.Reload();
            };
            toAdd.Add(label);
        }

    }
}
