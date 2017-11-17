using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace HareEditor {

    public partial class CreateProject : Form {

        public string Path {
            get {
                return tbxDirectory.Text + tbxProjectName.Text;
            }
        }

        public CreateProject() {
            InitializeComponent();
            DoubleBuffered = true;
            BackColor = Program.colorSecondary;
            Appbar.BackColor = Program.colorPrimary;
            btnBack.ForeColor = Program.colorAccentFont;
            btnCreate.ForeColor = Program.colorAccentFont;
            btnBrowse.BackColor = Program.colorAccentDark;
            btnBrowse.ForeColor = Program.colorAccentFont;
            lblTitle.ForeColor = Program.colorAccentFont;
            lblDirectory.ForeColor = Program.colorFont;
            lblProjectName.ForeColor = Program.colorFont;
        }

        public void Sync(Form form) {
            Location = form.Location;
            Size = form.Size;
            WindowState = form.WindowState;
        }

        public void ClearData() {
            tbxDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
            tbxProjectName.Text = "New Project";
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            Program.welcome.Sync(this);
            ClearData();
            Program.welcome.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            if (Directory.Exists(Path)) {
                MessageBox.Show("Directory already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (!string.IsNullOrEmpty(tbxProjectName.Text) &&
                    tbxProjectName.Text.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) < 0) {
                    this.Hide();
                    ProjectHolder project = new ProjectHolder(tbxProjectName.Text, Path);
                    Directory.CreateDirectory(Path);
                    Directory.CreateDirectory(Path + "\\Assets");
                    Directory.CreateDirectory(Path + "\\ProjectSettings");
                    Directory.CreateDirectory(Path + "\\Build");
                    File.WriteAllText(Path + "\\.gitignore", "/[Tt]emp/\n/[Bb]uild/\n/[Bb]uilds/\n*.apk");
                    Asset ProjectDetails = new Asset();
                    ProjectDetails.PutString("name", project.Name)
                        .SaveToFile(Path + "\\ProjectSettings\\Details.asset");
                    Program.recentProjects.Add(project);
                    Program.SaveProjectList();
                    Program.editor.Project = project;
                    Program.editor.Init();
                    Program.editor.Show();
                } else {
                    MessageBox.Show(
                        "Invalid Project Name",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                tbxDirectory.Text = dialog.FileName + "\\";
            }
        }

        private void CreateProject_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }

}
