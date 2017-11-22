namespace HareEditor {
    partial class StringField {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblText = new System.Windows.Forms.Label();
            this.Wrapper = new HareEditor.DBPanel();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 24);
            this.lblText.TabIndex = 0;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.tbxValue);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(100, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(100, 24);
            this.Wrapper.TabIndex = 1;
            // 
            // tbxValue
            // 
            this.tbxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxValue.Location = new System.Drawing.Point(0, 2);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(100, 20);
            this.tbxValue.TabIndex = 0;
            this.tbxValue.TextChanged += new System.EventHandler(this.tbxValue_ValueChanged);
            // 
            // StringField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.lblText);
            this.Name = "StringField";
            this.Size = new System.Drawing.Size(200, 24);
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private DBPanel Wrapper;
        private System.Windows.Forms.TextBox tbxValue;
    }
}
