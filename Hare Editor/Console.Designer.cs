namespace HareEditor {
    partial class Console {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console));
            this.Appbar = new HareEditor.DBPanel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbxError = new System.Windows.Forms.CheckBox();
            this.cbxWarning = new System.Windows.Forms.CheckBox();
            this.cbxLog = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.Wrapper = new HareEditor.DBPanel();
            this.Appbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Appbar.Controls.Add(this.tbxSearch);
            this.Appbar.Controls.Add(this.cbxError);
            this.Appbar.Controls.Add(this.cbxWarning);
            this.Appbar.Controls.Add(this.cbxLog);
            this.Appbar.Controls.Add(this.btnClear);
            this.Appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appbar.Location = new System.Drawing.Point(0, 0);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(584, 56);
            this.Appbar.TabIndex = 0;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(98, 18);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(297, 20);
            this.tbxSearch.TabIndex = 4;
            this.tbxSearch.TextChanged += new System.EventHandler(this.Search);
            // 
            // cbxError
            // 
            this.cbxError.BackColor = System.Drawing.Color.Transparent;
            this.cbxError.Checked = true;
            this.cbxError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxError.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxError.Location = new System.Drawing.Point(401, 0);
            this.cbxError.Name = "cbxError";
            this.cbxError.Size = new System.Drawing.Size(56, 56);
            this.cbxError.TabIndex = 3;
            this.cbxError.Text = "Error";
            this.cbxError.UseVisualStyleBackColor = false;
            this.cbxError.CheckedChanged += new System.EventHandler(this.Search);
            // 
            // cbxWarning
            // 
            this.cbxWarning.BackColor = System.Drawing.Color.Transparent;
            this.cbxWarning.Checked = true;
            this.cbxWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWarning.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWarning.Location = new System.Drawing.Point(457, 0);
            this.cbxWarning.Name = "cbxWarning";
            this.cbxWarning.Size = new System.Drawing.Size(77, 56);
            this.cbxWarning.TabIndex = 2;
            this.cbxWarning.Text = "Warning";
            this.cbxWarning.UseVisualStyleBackColor = false;
            this.cbxWarning.CheckedChanged += new System.EventHandler(this.Search);
            // 
            // cbxLog
            // 
            this.cbxLog.BackColor = System.Drawing.Color.Transparent;
            this.cbxLog.Checked = true;
            this.cbxLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLog.Location = new System.Drawing.Point(534, 0);
            this.cbxLog.Name = "cbxLog";
            this.cbxLog.Size = new System.Drawing.Size(50, 56);
            this.cbxLog.TabIndex = 1;
            this.cbxLog.Text = "Log";
            this.cbxLog.UseVisualStyleBackColor = false;
            this.cbxLog.CheckedChanged += new System.EventHandler(this.Search);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 56);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.AutoScroll = true;
            this.Wrapper.BackColor = System.Drawing.Color.Transparent;
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 56);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(584, 261);
            this.Wrapper.TabIndex = 1;
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(584, 317);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.Appbar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Console";
            this.Text = "Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Console_FormClosed);
            this.Appbar.ResumeLayout(false);
            this.Appbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel Appbar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.CheckBox cbxError;
        private System.Windows.Forms.CheckBox cbxWarning;
        private System.Windows.Forms.CheckBox cbxLog;
        private DBPanel Wrapper;
    }
}