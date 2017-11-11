namespace HareEditor {
    partial class ColorSelector {
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
            this.pnlBlue = new HareEditor.DBPanel();
            this.tbxBlue = new System.Windows.Forms.NumericUpDown();
            this.lblBlue = new System.Windows.Forms.Label();
            this.pnlGreen = new HareEditor.DBPanel();
            this.lblGreen = new System.Windows.Forms.Label();
            this.tbxGreen = new System.Windows.Forms.NumericUpDown();
            this.pnlRed = new HareEditor.DBPanel();
            this.lblRed = new System.Windows.Forms.Label();
            this.tbxRed = new System.Windows.Forms.NumericUpDown();
            this.pnlAlpha = new HareEditor.DBPanel();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.tbxAlpha = new System.Windows.Forms.NumericUpDown();
            this.pnlBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBlue)).BeginInit();
            this.pnlGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxGreen)).BeginInit();
            this.pnlRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRed)).BeginInit();
            this.pnlAlpha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBlue
            // 
            this.pnlBlue.Controls.Add(this.lblBlue);
            this.pnlBlue.Controls.Add(this.tbxBlue);
            this.pnlBlue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBlue.Location = new System.Drawing.Point(0, 321);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(234, 20);
            this.pnlBlue.TabIndex = 0;
            // 
            // tbxBlue
            // 
            this.tbxBlue.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxBlue.Location = new System.Drawing.Point(109, 0);
            this.tbxBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(125, 20);
            this.tbxBlue.TabIndex = 0;
            this.tbxBlue.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblBlue
            // 
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBlue.Location = new System.Drawing.Point(0, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(103, 20);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "Blue";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGreen
            // 
            this.pnlGreen.Controls.Add(this.lblGreen);
            this.pnlGreen.Controls.Add(this.tbxGreen);
            this.pnlGreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGreen.Location = new System.Drawing.Point(0, 301);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(234, 20);
            this.pnlGreen.TabIndex = 2;
            // 
            // lblGreen
            // 
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGreen.Location = new System.Drawing.Point(0, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(103, 20);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Green";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxGreen
            // 
            this.tbxGreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxGreen.Location = new System.Drawing.Point(109, 0);
            this.tbxGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(125, 20);
            this.tbxGreen.TabIndex = 0;
            this.tbxGreen.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // pnlRed
            // 
            this.pnlRed.Controls.Add(this.lblRed);
            this.pnlRed.Controls.Add(this.tbxRed);
            this.pnlRed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRed.Location = new System.Drawing.Point(0, 281);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(234, 20);
            this.pnlRed.TabIndex = 3;
            // 
            // lblRed
            // 
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRed.Location = new System.Drawing.Point(0, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(103, 20);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxRed
            // 
            this.tbxRed.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxRed.Location = new System.Drawing.Point(109, 0);
            this.tbxRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tbxRed.Name = "tbxRed";
            this.tbxRed.Size = new System.Drawing.Size(125, 20);
            this.tbxRed.TabIndex = 0;
            this.tbxRed.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // pnlAlpha
            // 
            this.pnlAlpha.Controls.Add(this.lblAlpha);
            this.pnlAlpha.Controls.Add(this.tbxAlpha);
            this.pnlAlpha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlpha.Location = new System.Drawing.Point(0, 341);
            this.pnlAlpha.Name = "pnlAlpha";
            this.pnlAlpha.Size = new System.Drawing.Size(234, 20);
            this.pnlAlpha.TabIndex = 2;
            // 
            // lblAlpha
            // 
            this.lblAlpha.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAlpha.Location = new System.Drawing.Point(0, 0);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(103, 20);
            this.lblAlpha.TabIndex = 1;
            this.lblAlpha.Text = "Alpha";
            this.lblAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxAlpha
            // 
            this.tbxAlpha.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxAlpha.Location = new System.Drawing.Point(109, 0);
            this.tbxAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tbxAlpha.Name = "tbxAlpha";
            this.tbxAlpha.Size = new System.Drawing.Size(125, 20);
            this.tbxAlpha.TabIndex = 0;
            this.tbxAlpha.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // ColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(234, 361);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.pnlBlue);
            this.Controls.Add(this.pnlAlpha);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSelector";
            this.Text = "ColorSelector";
            this.pnlBlue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxBlue)).EndInit();
            this.pnlGreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxGreen)).EndInit();
            this.pnlRed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxRed)).EndInit();
            this.pnlAlpha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbxAlpha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel pnlBlue;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.NumericUpDown tbxBlue;
        private DBPanel pnlGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.NumericUpDown tbxGreen;
        private DBPanel pnlRed;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.NumericUpDown tbxRed;
        private DBPanel pnlAlpha;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.NumericUpDown tbxAlpha;
    }
}