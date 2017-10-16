namespace HareEditor {
    partial class Editor {
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPanel = new HareEditor.DBPanel();
            this.assetsPanel = new HareEditor.DBPanel();
            this.Assets = new HareEditor.Controls.Card();
            this.hierarchyPanel = new HareEditor.DBPanel();
            this.Hierarchy = new HareEditor.Controls.Card();
            this.inspectorPanel = new HareEditor.DBPanel();
            this.Inspector = new HareEditor.Controls.Card();
            this.renderPanel = new HareEditor.DBPanel();
            this.scenePanel = new HareEditor.DBPanel();
            this.SceneView = new HareEditor.Controls.Card();
            this.gameViewPanel = new HareEditor.DBPanel();
            this.GameView = new HareEditor.Controls.Card();
            this.wrapperPanel = new HareEditor.DBPanel();
            this.MenuStrip.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.assetsPanel.SuspendLayout();
            this.hierarchyPanel.SuspendLayout();
            this.inspectorPanel.SuspendLayout();
            this.renderPanel.SuspendLayout();
            this.scenePanel.SuspendLayout();
            this.gameViewPanel.SuspendLayout();
            this.wrapperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appbar.Location = new System.Drawing.Point(0, 24);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(784, 56);
            this.Appbar.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSceneToolStripMenuItem,
            this.saveSceneToolStripMenuItem,
            this.saveSceneAsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSceneToolStripMenuItem
            // 
            this.newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            this.newSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newSceneToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.newSceneToolStripMenuItem.Text = "New Scene";
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveSceneToolStripMenuItem.Text = "Save Scene";
            // 
            // saveSceneAsToolStripMenuItem
            // 
            this.saveSceneAsToolStripMenuItem.Name = "saveSceneAsToolStripMenuItem";
            this.saveSceneAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveSceneAsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveSceneAsToolStripMenuItem.Text = "Save Scene As";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.assetsPanel);
            this.dataPanel.Controls.Add(this.hierarchyPanel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(200, 481);
            this.dataPanel.TabIndex = 2;
            // 
            // assetsPanel
            // 
            this.assetsPanel.BackColor = System.Drawing.Color.Transparent;
            this.assetsPanel.Controls.Add(this.Assets);
            this.assetsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetsPanel.Location = new System.Drawing.Point(0, 241);
            this.assetsPanel.Name = "assetsPanel";
            this.assetsPanel.Size = new System.Drawing.Size(200, 240);
            this.assetsPanel.TabIndex = 1;
            // 
            // Assets
            // 
            this.Assets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Assets.Location = new System.Drawing.Point(0, 0);
            this.Assets.Name = "Assets";
            this.Assets.Size = new System.Drawing.Size(200, 240);
            this.Assets.TabIndex = 0;
            this.Assets.Title = "Assets";
            // 
            // hierarchyPanel
            // 
            this.hierarchyPanel.BackColor = System.Drawing.Color.Transparent;
            this.hierarchyPanel.Controls.Add(this.Hierarchy);
            this.hierarchyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchyPanel.Location = new System.Drawing.Point(0, 0);
            this.hierarchyPanel.Name = "hierarchyPanel";
            this.hierarchyPanel.Size = new System.Drawing.Size(200, 240);
            this.hierarchyPanel.TabIndex = 0;
            // 
            // Hierarchy
            // 
            this.Hierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hierarchy.Location = new System.Drawing.Point(0, 0);
            this.Hierarchy.Name = "Hierarchy";
            this.Hierarchy.Size = new System.Drawing.Size(200, 240);
            this.Hierarchy.TabIndex = 0;
            this.Hierarchy.Title = "Hierarchy";
            // 
            // inspectorPanel
            // 
            this.inspectorPanel.BackColor = System.Drawing.Color.Transparent;
            this.inspectorPanel.Controls.Add(this.Inspector);
            this.inspectorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inspectorPanel.Location = new System.Drawing.Point(584, 0);
            this.inspectorPanel.Name = "inspectorPanel";
            this.inspectorPanel.Size = new System.Drawing.Size(200, 481);
            this.inspectorPanel.TabIndex = 3;
            // 
            // Inspector
            // 
            this.Inspector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inspector.Location = new System.Drawing.Point(0, 0);
            this.Inspector.Name = "Inspector";
            this.Inspector.Size = new System.Drawing.Size(200, 481);
            this.Inspector.TabIndex = 1;
            this.Inspector.Title = "Inspector";
            // 
            // renderPanel
            // 
            this.renderPanel.Controls.Add(this.scenePanel);
            this.renderPanel.Controls.Add(this.gameViewPanel);
            this.renderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderPanel.Location = new System.Drawing.Point(200, 0);
            this.renderPanel.Name = "renderPanel";
            this.renderPanel.Size = new System.Drawing.Size(384, 481);
            this.renderPanel.TabIndex = 4;
            // 
            // scenePanel
            // 
            this.scenePanel.BackColor = System.Drawing.Color.Transparent;
            this.scenePanel.Controls.Add(this.SceneView);
            this.scenePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scenePanel.Location = new System.Drawing.Point(0, 241);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(384, 240);
            this.scenePanel.TabIndex = 1;
            // 
            // SceneView
            // 
            this.SceneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SceneView.Location = new System.Drawing.Point(0, 0);
            this.SceneView.Name = "SceneView";
            this.SceneView.Size = new System.Drawing.Size(384, 240);
            this.SceneView.TabIndex = 0;
            this.SceneView.Title = "Scene";
            // 
            // gameViewPanel
            // 
            this.gameViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameViewPanel.Controls.Add(this.GameView);
            this.gameViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameViewPanel.Location = new System.Drawing.Point(0, 0);
            this.gameViewPanel.Name = "gameViewPanel";
            this.gameViewPanel.Size = new System.Drawing.Size(384, 240);
            this.gameViewPanel.TabIndex = 0;
            // 
            // GameView
            // 
            this.GameView.BackColor = System.Drawing.Color.Transparent;
            this.GameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameView.Location = new System.Drawing.Point(0, 0);
            this.GameView.Name = "GameView";
            this.GameView.Size = new System.Drawing.Size(384, 240);
            this.GameView.TabIndex = 0;
            this.GameView.Title = "Game";
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.BackColor = System.Drawing.Color.Transparent;
            this.wrapperPanel.Controls.Add(this.renderPanel);
            this.wrapperPanel.Controls.Add(this.dataPanel);
            this.wrapperPanel.Controls.Add(this.inspectorPanel);
            this.wrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperPanel.Location = new System.Drawing.Point(0, 80);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Size = new System.Drawing.Size(784, 481);
            this.wrapperPanel.TabIndex = 0;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.wrapperPanel);
            this.Controls.Add(this.Appbar);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Editor";
            this.Text = "Hare Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.Resize += new System.EventHandler(this.Editor_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.assetsPanel.ResumeLayout(false);
            this.hierarchyPanel.ResumeLayout(false);
            this.inspectorPanel.ResumeLayout(false);
            this.renderPanel.ResumeLayout(false);
            this.scenePanel.ResumeLayout(false);
            this.gameViewPanel.ResumeLayout(false);
            this.wrapperPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBPanel Appbar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSceneAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private DBPanel dataPanel;
        private DBPanel assetsPanel;
        private DBPanel hierarchyPanel;
        private DBPanel inspectorPanel;
        private DBPanel renderPanel;
        private DBPanel scenePanel;
        private DBPanel gameViewPanel;
        private DBPanel wrapperPanel;
        private Controls.Card Inspector;
        private Controls.Card Assets;
        private Controls.Card Hierarchy;
        private Controls.Card SceneView;
        private Controls.Card GameView;
    }
}