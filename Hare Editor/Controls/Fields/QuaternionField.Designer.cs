namespace HareEditor {
    partial class QuaternionField {
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
            this.pnlZ = new HareEditor.DBPanel();
            this.tbxZ = new System.Windows.Forms.NumericUpDown();
            this.lblZ = new System.Windows.Forms.Label();
            this.pnlY = new HareEditor.DBPanel();
            this.tbxY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.pnlX = new HareEditor.DBPanel();
            this.tbxX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.Wrapper.SuspendLayout();
            this.pnlZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxZ)).BeginInit();
            this.pnlY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxY)).BeginInit();
            this.pnlX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(200, 24);
            this.lblText.TabIndex = 0;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.pnlZ);
            this.Wrapper.Controls.Add(this.lblZ);
            this.Wrapper.Controls.Add(this.pnlY);
            this.Wrapper.Controls.Add(this.lblY);
            this.Wrapper.Controls.Add(this.pnlX);
            this.Wrapper.Controls.Add(this.lblX);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Wrapper.Location = new System.Drawing.Point(0, 24);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(200, 24);
            this.Wrapper.TabIndex = 1;
            // 
            // pnlZ
            // 
            this.pnlZ.Controls.Add(this.tbxZ);
            this.pnlZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlZ.Location = new System.Drawing.Point(149, 0);
            this.pnlZ.Name = "pnlZ";
            this.pnlZ.Size = new System.Drawing.Size(49, 24);
            this.pnlZ.TabIndex = 5;
            // 
            // tbxZ
            // 
            this.tbxZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxZ.DecimalPlaces = 8;
            this.tbxZ.Location = new System.Drawing.Point(0, 2);
            this.tbxZ.Name = "tbxZ";
            this.tbxZ.Size = new System.Drawing.Size(49, 20);
            this.tbxZ.TabIndex = 0;
            this.tbxZ.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblZ
            // 
            this.lblZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblZ.Location = new System.Drawing.Point(132, 0);
            this.lblZ.Margin = new System.Windows.Forms.Padding(0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 24);
            this.lblZ.TabIndex = 1;
            this.lblZ.Text = "Z:";
            this.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlY
            // 
            this.pnlY.Controls.Add(this.tbxY);
            this.pnlY.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlY.Location = new System.Drawing.Point(83, 0);
            this.pnlY.Name = "pnlY";
            this.pnlY.Size = new System.Drawing.Size(49, 24);
            this.pnlY.TabIndex = 4;
            // 
            // tbxY
            // 
            this.tbxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxY.DecimalPlaces = 8;
            this.tbxY.Location = new System.Drawing.Point(0, 2);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(49, 20);
            this.tbxY.TabIndex = 0;
            this.tbxY.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblY
            // 
            this.lblY.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblY.Location = new System.Drawing.Point(66, 0);
            this.lblY.Margin = new System.Windows.Forms.Padding(0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 24);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y:";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlX
            // 
            this.pnlX.Controls.Add(this.tbxX);
            this.pnlX.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlX.Location = new System.Drawing.Point(17, 0);
            this.pnlX.Name = "pnlX";
            this.pnlX.Size = new System.Drawing.Size(49, 24);
            this.pnlX.TabIndex = 3;
            // 
            // tbxX
            // 
            this.tbxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxX.DecimalPlaces = 8;
            this.tbxX.Location = new System.Drawing.Point(0, 2);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(49, 20);
            this.tbxX.TabIndex = 0;
            this.tbxX.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lblX
            // 
            this.lblX.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblX.Location = new System.Drawing.Point(0, 0);
            this.lblX.Margin = new System.Windows.Forms.Padding(0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 24);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuaternionField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.lblText);
            this.Name = "QuaternionField";
            this.Size = new System.Drawing.Size(200, 48);
            this.Resize += new System.EventHandler(this.QuaternionField_Resize);
            this.Wrapper.ResumeLayout(false);
            this.pnlZ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxZ)).EndInit();
            this.pnlY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxY)).EndInit();
            this.pnlX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private DBPanel Wrapper;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblX;
        private DBPanel pnlZ;
        private System.Windows.Forms.NumericUpDown tbxZ;
        private DBPanel pnlY;
        private System.Windows.Forms.NumericUpDown tbxY;
        private DBPanel pnlX;
        private System.Windows.Forms.NumericUpDown tbxX;
    }
}
