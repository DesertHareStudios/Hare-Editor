namespace HareEditor {
    partial class RangedNumberField {
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
            this.tbrValue = new System.Windows.Forms.TrackBar();
            this.Wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrValue)).BeginInit();
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
            this.Wrapper.Controls.Add(this.tbrValue);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(100, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(100, 24);
            this.Wrapper.TabIndex = 1;
            // 
            // tbrValue
            // 
            this.tbrValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbrValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbrValue.Location = new System.Drawing.Point(0, 0);
            this.tbrValue.Name = "tbrValue";
            this.tbrValue.Size = new System.Drawing.Size(100, 24);
            this.tbrValue.TabIndex = 0;
            this.tbrValue.ValueChanged += new System.EventHandler(this.tbxValue_ValueChanged);
            // 
            // RangedNumberField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.lblText);
            this.Name = "RangedNumberField";
            this.Size = new System.Drawing.Size(200, 24);
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private DBPanel Wrapper;
        private System.Windows.Forms.TrackBar tbrValue;
    }
}
