namespace HareEditor {
    partial class ColorField {
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
            this.pnlColor = new HareEditor.DBPanel();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlColorHolder = new HareEditor.DBPanel();
            this.pnlAlpha = new HareEditor.DBPanel();
            this.pnlColorHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlColor
            // 
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(32, 24);
            this.pnlColor.TabIndex = 0;
            this.pnlColor.Click += new System.EventHandler(this.pnlColor_Click);
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Location = new System.Drawing.Point(32, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(168, 32);
            this.lblText.TabIndex = 1;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlColorHolder
            // 
            this.pnlColorHolder.Controls.Add(this.pnlColor);
            this.pnlColorHolder.Controls.Add(this.pnlAlpha);
            this.pnlColorHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColorHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlColorHolder.Name = "pnlColorHolder";
            this.pnlColorHolder.Size = new System.Drawing.Size(32, 32);
            this.pnlColorHolder.TabIndex = 2;
            // 
            // pnlAlpha
            // 
            this.pnlAlpha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlpha.Location = new System.Drawing.Point(0, 24);
            this.pnlAlpha.Name = "pnlAlpha";
            this.pnlAlpha.Size = new System.Drawing.Size(32, 8);
            this.pnlAlpha.TabIndex = 0;
            // 
            // ColorField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pnlColorHolder);
            this.DoubleBuffered = true;
            this.Name = "ColorField";
            this.Size = new System.Drawing.Size(200, 32);
            this.pnlColorHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel pnlColor;
        private System.Windows.Forms.Label lblText;
        private DBPanel pnlColorHolder;
        private DBPanel pnlAlpha;
    }
}
