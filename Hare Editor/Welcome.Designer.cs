namespace HareEditor {
    partial class Welcome {
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wrapperPanel = new HareEditor.DBPanel();
            this.Appbar.SuspendLayout();
            this.wrapperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Appbar.Controls.Add(this.btnNew);
            this.Appbar.Controls.Add(this.btnOpen);
            this.Appbar.Controls.Add(this.label1);
            this.Appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appbar.Location = new System.Drawing.Point(0, 0);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(584, 56);
            this.Appbar.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(402, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 56);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(493, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(91, 56);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperPanel.Location = new System.Drawing.Point(0, 56);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Size = new System.Drawing.Size(584, 305);
            this.wrapperPanel.TabIndex = 1;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.wrapperPanel);
            this.Controls.Add(this.Appbar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Text = "Hare Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_FormClosed);
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.Appbar.ResumeLayout(false);
            this.wrapperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel Appbar;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private DBPanel wrapperPanel;
    }
}