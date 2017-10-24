namespace HareEditor {
    partial class CreateProject {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Appbar = new HareEditor.DBPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblNewProject = new System.Windows.Forms.Label();
            this.pnlProjectName = new HareEditor.DBPanel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.tbxProjectName = new System.Windows.Forms.TextBox();
            this.Wrapper = new HareEditor.DBPanel();
            this.pnlDirectory = new HareEditor.DBPanel();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.pnlDirectoryTbx = new HareEditor.DBPanel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbxDirectory = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Appbar.SuspendLayout();
            this.pnlProjectName.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.pnlDirectory.SuspendLayout();
            this.pnlDirectoryTbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Appbar.Controls.Add(this.pictureBox1);
            this.Appbar.Controls.Add(this.btnBack);
            this.Appbar.Controls.Add(this.btnCreate);
            this.Appbar.Controls.Add(this.lblNewProject);
            this.Appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appbar.Location = new System.Drawing.Point(0, 0);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(584, 56);
            this.Appbar.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBack.Location = new System.Drawing.Point(402, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCreate.Location = new System.Drawing.Point(493, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 56);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblNewProject
            // 
            this.lblNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNewProject.Location = new System.Drawing.Point(59, 0);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(123, 56);
            this.lblNewProject.TabIndex = 0;
            this.lblNewProject.Text = "New Project";
            this.lblNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlProjectName
            // 
            this.pnlProjectName.Controls.Add(this.lblProjectName);
            this.pnlProjectName.Controls.Add(this.tbxProjectName);
            this.pnlProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjectName.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectName.Name = "pnlProjectName";
            this.pnlProjectName.Size = new System.Drawing.Size(584, 56);
            this.pnlProjectName.TabIndex = 1;
            // 
            // lblProjectName
            // 
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(584, 34);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project Name";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxProjectName
            // 
            this.tbxProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProjectName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbxProjectName.Location = new System.Drawing.Point(0, 34);
            this.tbxProjectName.Name = "tbxProjectName";
            this.tbxProjectName.Size = new System.Drawing.Size(584, 22);
            this.tbxProjectName.TabIndex = 0;
            this.tbxProjectName.Text = "New Project";
            // 
            // Wrapper
            // 
            this.Wrapper.AutoScroll = true;
            this.Wrapper.BackColor = System.Drawing.Color.Transparent;
            this.Wrapper.Controls.Add(this.pnlDirectory);
            this.Wrapper.Controls.Add(this.pnlProjectName);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 56);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(584, 305);
            this.Wrapper.TabIndex = 2;
            // 
            // pnlDirectory
            // 
            this.pnlDirectory.Controls.Add(this.lblDirectory);
            this.pnlDirectory.Controls.Add(this.pnlDirectoryTbx);
            this.pnlDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDirectory.Location = new System.Drawing.Point(0, 56);
            this.pnlDirectory.Name = "pnlDirectory";
            this.pnlDirectory.Size = new System.Drawing.Size(584, 56);
            this.pnlDirectory.TabIndex = 2;
            // 
            // lblDirectory
            // 
            this.lblDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectory.Location = new System.Drawing.Point(0, 0);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(584, 28);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Directory";
            this.lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDirectoryTbx
            // 
            this.pnlDirectoryTbx.Controls.Add(this.btnBrowse);
            this.pnlDirectoryTbx.Controls.Add(this.tbxDirectory);
            this.pnlDirectoryTbx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDirectoryTbx.Location = new System.Drawing.Point(0, 28);
            this.pnlDirectoryTbx.Name = "pnlDirectoryTbx";
            this.pnlDirectoryTbx.Size = new System.Drawing.Size(584, 28);
            this.pnlDirectoryTbx.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(493, 0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbxDirectory
            // 
            this.tbxDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbxDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxDirectory.Enabled = false;
            this.tbxDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxDirectory.Location = new System.Drawing.Point(0, 0);
            this.tbxDirectory.Name = "tbxDirectory";
            this.tbxDirectory.Size = new System.Drawing.Size(485, 27);
            this.tbxDirectory.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::HareEditor.Properties.Resources.DHSLogo_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.Appbar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateProject";
            this.Text = "Hare Editor - New Project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateProject_FormClosed);
            this.Appbar.ResumeLayout(false);
            this.pnlProjectName.ResumeLayout(false);
            this.pnlProjectName.PerformLayout();
            this.Wrapper.ResumeLayout(false);
            this.pnlDirectory.ResumeLayout(false);
            this.pnlDirectoryTbx.ResumeLayout(false);
            this.pnlDirectoryTbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel Appbar;
        private System.Windows.Forms.Label lblNewProject;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private DBPanel pnlProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox tbxProjectName;
        private DBPanel Wrapper;
        private DBPanel pnlDirectory;
        private System.Windows.Forms.Label lblDirectory;
        private DBPanel pnlDirectoryTbx;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbxDirectory;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}