using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace HareEditor {

    public partial class Welcome : Form {

        public Welcome() {
            Program.welcome = this;
            InitializeComponent();
        }

        public void Init() {
            BackColor = Program.colorSecondary;
            Appbar.BackColor = Program.colorPrimary;
            btnNew.BackColor = Program.colorAccentDark;
            btnNew.ForeColor = Program.colorAccentFont;
            btnOpen.BackColor = Program.colorAccentDark;
            btnOpen.ForeColor = Program.colorAccentFont;
            lblTitle.ForeColor = Program.colorAccentFont;
            try {
                Program.recentProjects.Clear();
                wrapperPanel.Controls.Clear();
                string[] text = File.ReadAllLines(Environment.CurrentDirectory + "\\rpl.list");
                for (int i = 0; i < text.Length; i++) {
                    try {
                        if (Directory.Exists(text[i + 1])) {
                            Program.recentProjects.Add(new ProjectHolder(text[i++], text[i]));
                        }
                    } catch { }
                }
            } catch { }
            bool isEmpty = true;
            foreach (ProjectHolder ph in Program.recentProjects) {
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
                btnDel.ForeColor = Program.colorFont;
                btnDel.Location = new Point(528, 0);
                btnDel.Name = "btnDel";
                btnDel.Size = new Size(56, 56);
                btnDel.Text = "x";
                btnDel.UseVisualStyleBackColor = true;
                name.Dock = DockStyle.Top;
                name.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
                name.ForeColor = Program.colorFont;
                name.Location = new Point(0, 0);
                name.Size = new Size(528, 28);
                name.Text = ph.Name;
                name.TextAlign = ContentAlignment.BottomLeft;
                path.Dock = DockStyle.Top;
                path.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                path.ForeColor = Program.colorFont;
                path.Location = new Point(0, 28);
                path.Size = new Size(528, 28);
                path.Text = ph.Path;
                wrapperPanel.Controls.Add(panel);
                panel.ResumeLayout(false);
                panel.Click += (o, args) => {
                    this.Hide();
                    Program.editor.Project = ph;
                    Program.editor.Init();
                    Program.editor.Show();
                };
                name.Click += (o, args) => {
                    this.Hide();
                    Program.editor.Project = ph;
                    Program.editor.Init();
                    Program.editor.Show();
                };
                path.Click += (o, args) => {
                    this.Hide();
                    Program.editor.Project = ph;
                    Program.editor.Init();
                    Program.editor.Show();
                };
                btnDel.Click += (o, args) => {
                    wrapperPanel.Controls.Remove(panel);
                    Program.recentProjects.Remove(ph);
                    Program.SaveProjectList();
                    Init();
                };
            }
            if (isEmpty) {
                Label emptyLabel = new Label();
                wrapperPanel.Controls.Add(emptyLabel);
                emptyLabel.Dock = DockStyle.Top;
                emptyLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
                emptyLabel.ForeColor = Program.colorFont;
                emptyLabel.Location = new Point(0, 0);
                emptyLabel.Size = new Size(584, 112);
                emptyLabel.Text = "Your project list is empty. Add a new project to begin.";
                emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
                emptyLabel.Click += new EventHandler(this.btnNew_Click);
            }
        }

        public void Sync(Form form) {
            Location = form.Location;
            Size = form.Size;
            WindowState = form.WindowState;
        }

        private void btnNew_Click(object sender, EventArgs e) {
            this.Hide();
            Program.cProject.ClearData();
            Program.cProject.Show();
            Program.cProject.Sync(this);
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                bool valid = false;
                string name = "";
                if (Directory.Exists(dialog.FileName + "\\Assets")) {
                    if (Directory.Exists(dialog.FileName + "\\ProjectSettings")) {
                        name = Asset.ReadFromFile(dialog.FileName + "\\ProjectSettings\\Details.asset").GetString("name", "");
                        if (name != "") {
                            valid = true;
                        }
                    }
                }
                if (valid) {
                    this.Hide();
                    ProjectHolder project = new ProjectHolder(name, dialog.FileName);
                    Program.recentProjects.Add(project);
                    Program.SaveProjectList();
                    Program.editor.Project = project;
                    Program.editor.Init();
                    Program.editor.Show();
                } else {
                    MessageBox.Show(
                        "Selected folder is not a valid Hare Project",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void Welcome_Load(object sender, EventArgs e) {
            Init();
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }

}
