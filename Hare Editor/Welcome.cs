using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace HareEditor {

    public partial class Welcome : Form {

        List<ProjectHolder> recentProjects = new List<ProjectHolder>();

        public Welcome() {
            Program.welcome = this;
            InitializeComponent();
            switch (EditorPrefs.Instance.theme) {
                case Theme.Light:
                    BackColor = Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = Color.FromArgb(157, 157, 157);
                    break;
                case Theme.Dark:
                    BackColor = Color.FromArgb(37, 37, 37);
                    Appbar.BackColor = Color.FromArgb(15, 15, 15);
                    break;
                case Theme.Hybrid:
                    BackColor = Color.FromArgb(240, 240, 240);
                    Appbar.BackColor = Color.FromArgb(37, 37, 37);
                    break;
            }
        }

        private void btnNew_Click(object sender, EventArgs e) {
            //TODO Prompt project name
            //Temporal code for testing...
            this.Hide();
            Program.editor.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                MessageBox.Show("You selected: " + dialog.FileName);
                //TODO validate project and open it
            }
        }

        private void Welcome_Load(object sender, EventArgs e) {
            try {
                string[] text = File.ReadAllLines(Environment.CurrentDirectory + "rpl.list");
                for (int i = 0; i < text.Length - 1; i++) {
                    recentProjects.Add(new ProjectHolder(text[i++], text[i]));
                }
            } catch { }
            bool isEmpty = true;
            foreach (ProjectHolder ph in recentProjects) {
                isEmpty = false;
                DBPanel panel;
                Label path;
                Label name;
                Button btnDel;
                panel = new DBPanel();
                btnDel = new Button();
                name = new Label();
                path = new Label();
                panel.SuspendLayout();
                panel.Controls.Add(path);
                panel.Controls.Add(name);
                panel.Controls.Add(btnDel);
                panel.Dock = DockStyle.Top;
                panel.Location = new Point(0, 56);
                panel.Size = new Size(584, 56);
                btnDel.Dock = DockStyle.Right;
                btnDel.FlatAppearance.BorderSize = 0;
                btnDel.FlatStyle = FlatStyle.Flat;
                btnDel.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                btnDel.ForeColor = Color.FromArgb(158, 158, 158);
                btnDel.Location = new Point(528, 0);
                btnDel.Name = "btnDel";
                btnDel.Size = new Size(56, 56);
                btnDel.Text = "x";
                btnDel.UseVisualStyleBackColor = true;
                name.Dock = DockStyle.Top;
                name.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
                name.Location = new Point(0, 0);
                name.Size = new Size(528, 28);
                name.Text = ph.Name;
                name.TextAlign = ContentAlignment.BottomLeft;
                path.Dock = DockStyle.Top;
                path.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                path.ForeColor = Color.FromArgb(158, 158, 158);
                path.Location = new Point(0, 28);
                path.Size = new Size(528, 28);
                path.Text = ph.Path;
                wrapperPanel.Controls.Add(panel);
                panel.ResumeLayout(false);
            }
            if (isEmpty) {
                Label emptyLabel = new Label();
                wrapperPanel.Controls.Add(emptyLabel);
                emptyLabel.Dock = DockStyle.Top;
                emptyLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
                emptyLabel.Location = new Point(0, 0);
                emptyLabel.Size = new Size(584, 112);
                emptyLabel.Text = "Your project list is empty. Add a new project to begin.";
                emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
                emptyLabel.Click += new EventHandler(this.btnNew_Click);
            }
        }

        public void SaveProjectList() {
            string text = "";
            foreach (ProjectHolder ph in recentProjects) {
                text += ph.Name + "\n" + ph.Path + "\n";
            }
            File.WriteAllText(Environment.CurrentDirectory + "rpl.list", text);
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }

}
