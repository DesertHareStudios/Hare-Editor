namespace HareEditor {
    partial class SceneCamera {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneCamera));
            this.vfPosition = new HareEditor.VectorField();
            this.qfRotation = new HareEditor.QuaternionField();
            this.nfOrthoWidth = new HareEditor.NumberField();
            this.SuspendLayout();
            // 
            // vfPosition
            // 
            this.vfPosition.BackColor = System.Drawing.Color.Transparent;
            this.vfPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.vfPosition.FontColor = System.Drawing.SystemColors.ControlText;
            this.vfPosition.Location = new System.Drawing.Point(0, 0);
            this.vfPosition.Name = "vfPosition";
            this.vfPosition.Size = new System.Drawing.Size(334, 48);
            this.vfPosition.TabIndex = 0;
            this.vfPosition.Value = ((OpenTK.Vector3)(resources.GetObject("vfPosition.Value")));
            this.vfPosition.ValueChanged += new System.EventHandler(this.vfPosition_ValueChanged);
            // 
            // qfRotation
            // 
            this.qfRotation.BackColor = System.Drawing.Color.Transparent;
            this.qfRotation.Dock = System.Windows.Forms.DockStyle.Top;
            this.qfRotation.FontColor = System.Drawing.SystemColors.ControlText;
            this.qfRotation.Location = new System.Drawing.Point(0, 48);
            this.qfRotation.Name = "qfRotation";
            this.qfRotation.Size = new System.Drawing.Size(334, 48);
            this.qfRotation.TabIndex = 1;
            this.qfRotation.Value = ((OpenTK.Quaternion)(resources.GetObject("qfRotation.Value")));
            this.qfRotation.ValueChanged += new System.EventHandler(this.qfRotation_ValueChanged);
            // 
            // nfOrthoWidth
            // 
            this.nfOrthoWidth.BackColor = System.Drawing.Color.Transparent;
            this.nfOrthoWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.nfOrthoWidth.FontColor = System.Drawing.SystemColors.ControlText;
            this.nfOrthoWidth.Location = new System.Drawing.Point(0, 96);
            this.nfOrthoWidth.Name = "nfOrthoWidth";
            this.nfOrthoWidth.Size = new System.Drawing.Size(334, 24);
            this.nfOrthoWidth.TabIndex = 2;
            this.nfOrthoWidth.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nfOrthoWidth.ValueChanged += new System.EventHandler(this.nfOrthoWidth_ValueChanged);
            // 
            // SceneCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(334, 171);
            this.Controls.Add(this.nfOrthoWidth);
            this.Controls.Add(this.qfRotation);
            this.Controls.Add(this.vfPosition);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 210);
            this.Name = "SceneCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene Camera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SceneCamera_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private VectorField vfPosition;
        private QuaternionField qfRotation;
        private NumberField nfOrthoWidth;
    }
}