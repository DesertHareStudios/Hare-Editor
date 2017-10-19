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
            this.openSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.projectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dObjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.editToolStripMenuItem,
            this.assetsToolStripMenuItem,
            this.gameObjectToolStripMenuItem});
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
            this.openSceneToolStripMenuItem,
            this.saveSceneToolStripMenuItem,
            this.saveSceneAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.buildSettingsToolStripMenuItem,
            this.buildRunToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
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
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.preferencesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripMenuItem6,
            this.projectSettingsToolStripMenuItem});
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
            // openSceneToolStripMenuItem
            // 
            this.openSceneToolStripMenuItem.Name = "openSceneToolStripMenuItem";
            this.openSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openSceneToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openSceneToolStripMenuItem.Text = "Open Scene";
            // 
            // buildSettingsToolStripMenuItem
            // 
            this.buildSettingsToolStripMenuItem.Name = "buildSettingsToolStripMenuItem";
            this.buildSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.buildSettingsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.buildSettingsToolStripMenuItem.Text = "Build Settings";
            // 
            // buildRunToolStripMenuItem
            // 
            this.buildRunToolStripMenuItem.Name = "buildRunToolStripMenuItem";
            this.buildRunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buildRunToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.buildRunToolStripMenuItem.Text = "Build && Run";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(153, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(153, 6);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(153, 6);
            // 
            // projectSettingsToolStripMenuItem
            // 
            this.projectSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicsToolStripMenuItem});
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.projectSettingsToolStripMenuItem.Text = "Project Settings";
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.physicsToolStripMenuItem.Text = "Physics";
            // 
            // assetsToolStripMenuItem
            // 
            this.assetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.showInExplorerToolStripMenuItem,
            this.toolStripMenuItem7,
            this.importToolStripMenuItem,
            this.toolStripMenuItem8,
            this.refreshToolStripMenuItem});
            this.assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            this.assetsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.assetsToolStripMenuItem.Text = "Assets";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // showInExplorerToolStripMenuItem
            // 
            this.showInExplorerToolStripMenuItem.Name = "showInExplorerToolStripMenuItem";
            this.showInExplorerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showInExplorerToolStripMenuItem.Text = "Show in Explorer";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(158, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(158, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // gameObjectToolStripMenuItem
            // 
            this.gameObjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmptyToolStripMenuItem,
            this.dObjectToolStripMenuItem,
            this.dObjectToolStripMenuItem1,
            this.lightToolStripMenuItem,
            this.audioToolStripMenuItem});
            this.gameObjectToolStripMenuItem.Name = "gameObjectToolStripMenuItem";
            this.gameObjectToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.gameObjectToolStripMenuItem.Text = "GameObject";
            // 
            // createEmptyToolStripMenuItem
            // 
            this.createEmptyToolStripMenuItem.Name = "createEmptyToolStripMenuItem";
            this.createEmptyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createEmptyToolStripMenuItem.Text = "Create Empty";
            // 
            // dObjectToolStripMenuItem
            // 
            this.dObjectToolStripMenuItem.Name = "dObjectToolStripMenuItem";
            this.dObjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dObjectToolStripMenuItem.Text = "3D Object";
            // 
            // dObjectToolStripMenuItem1
            // 
            this.dObjectToolStripMenuItem1.Name = "dObjectToolStripMenuItem1";
            this.dObjectToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dObjectToolStripMenuItem1.Text = "2D Object";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.audioToolStripMenuItem.Text = "Audio";
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
        private System.Windows.Forms.ToolStripMenuItem openSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dObjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
    }
}