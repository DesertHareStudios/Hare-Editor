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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.buildSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.componentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrapperPanel = new HareEditor.DBPanel();
            this.renderPanel = new HareEditor.DBPanel();
            this.scenePanel = new HareEditor.DBPanel();
            this.Scene = new HareEditor.Sceneview();
            this.lblScene = new System.Windows.Forms.Label();
            this.gameViewPanel = new HareEditor.DBPanel();
            this.Gameview = new HareEditor.Game();
            this.lblGame = new System.Windows.Forms.Label();
            this.dataPanel = new HareEditor.DBPanel();
            this.assetsPanel = new HareEditor.DBPanel();
            this.Assets = new HareEditor.Assets();
            this.lblAssets = new System.Windows.Forms.Label();
            this.hierarchyPanel = new HareEditor.DBPanel();
            this.Hierarchy = new HareEditor.Hierarchy();
            this.lblHierarchy = new System.Windows.Forms.Label();
            this.inspectorPanel = new HareEditor.DBPanel();
            this.Inspector = new HareEditor.Inspector();
            this.lblInspector = new System.Windows.Forms.Label();
            this.Appbar = new HareEditor.DBPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.wrapperPanel.SuspendLayout();
            this.renderPanel.SuspendLayout();
            this.scenePanel.SuspendLayout();
            this.Scene.SuspendLayout();
            this.gameViewPanel.SuspendLayout();
            this.Gameview.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.assetsPanel.SuspendLayout();
            this.hierarchyPanel.SuspendLayout();
            this.inspectorPanel.SuspendLayout();
            this.Appbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.assetsToolStripMenuItem,
            this.gameObjectToolStripMenuItem,
            this.componentToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            // openSceneToolStripMenuItem
            // 
            this.openSceneToolStripMenuItem.Name = "openSceneToolStripMenuItem";
            this.openSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openSceneToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openSceneToolStripMenuItem.Text = "Open Scene";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(175, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(175, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(175, 6);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(175, 6);
            // 
            // projectSettingsToolStripMenuItem
            // 
            this.projectSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicsToolStripMenuItem});
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.projectSettingsToolStripMenuItem.Text = "Project Settings";
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
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
            this.createEmptyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.createEmptyToolStripMenuItem.Text = "Create Empty";
            // 
            // dObjectToolStripMenuItem
            // 
            this.dObjectToolStripMenuItem.Name = "dObjectToolStripMenuItem";
            this.dObjectToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dObjectToolStripMenuItem.Text = "3D Object";
            // 
            // dObjectToolStripMenuItem1
            // 
            this.dObjectToolStripMenuItem1.Name = "dObjectToolStripMenuItem1";
            this.dObjectToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.dObjectToolStripMenuItem1.Text = "2D Object";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.audioToolStripMenuItem.Text = "Audio";
            // 
            // componentToolStripMenuItem
            // 
            this.componentToolStripMenuItem.Name = "componentToolStripMenuItem";
            this.componentToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.componentToolStripMenuItem.Text = "Component";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            this.scenePanel.Controls.Add(this.Scene);
            this.scenePanel.Controls.Add(this.lblScene);
            this.scenePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scenePanel.Location = new System.Drawing.Point(0, 241);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(384, 240);
            this.scenePanel.TabIndex = 1;
            // 
            // Scene
            // 
            this.Scene.Controls.Add(this.button9);
            this.Scene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scene.Location = new System.Drawing.Point(0, 28);
            this.Scene.Name = "Scene";
            this.Scene.Size = new System.Drawing.Size(384, 212);
            this.Scene.TabIndex = 3;
            // 
            // lblScene
            // 
            this.lblScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblScene.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblScene.Location = new System.Drawing.Point(0, 0);
            this.lblScene.Name = "lblScene";
            this.lblScene.Size = new System.Drawing.Size(384, 28);
            this.lblScene.TabIndex = 2;
            this.lblScene.Text = "Scene";
            this.lblScene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameViewPanel
            // 
            this.gameViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameViewPanel.Controls.Add(this.Gameview);
            this.gameViewPanel.Controls.Add(this.lblGame);
            this.gameViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameViewPanel.Location = new System.Drawing.Point(0, 0);
            this.gameViewPanel.Name = "gameViewPanel";
            this.gameViewPanel.Size = new System.Drawing.Size(384, 240);
            this.gameViewPanel.TabIndex = 0;
            // 
            // Gameview
            // 
            this.Gameview.Controls.Add(this.button8);
            this.Gameview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gameview.Location = new System.Drawing.Point(0, 28);
            this.Gameview.Name = "Gameview";
            this.Gameview.Size = new System.Drawing.Size(384, 212);
            this.Gameview.TabIndex = 4;
            // 
            // lblGame
            // 
            this.lblGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblGame.Location = new System.Drawing.Point(0, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(384, 28);
            this.lblGame.TabIndex = 3;
            this.lblGame.Text = "Game";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.assetsPanel.Controls.Add(this.lblAssets);
            this.assetsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetsPanel.Location = new System.Drawing.Point(0, 241);
            this.assetsPanel.Name = "assetsPanel";
            this.assetsPanel.Size = new System.Drawing.Size(200, 240);
            this.assetsPanel.TabIndex = 1;
            // 
            // Assets
            // 
            this.Assets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Assets.Location = new System.Drawing.Point(0, 28);
            this.Assets.Name = "Assets";
            this.Assets.Size = new System.Drawing.Size(200, 212);
            this.Assets.TabIndex = 2;
            // 
            // lblAssets
            // 
            this.lblAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblAssets.Location = new System.Drawing.Point(0, 0);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(200, 28);
            this.lblAssets.TabIndex = 1;
            this.lblAssets.Text = "Assets";
            this.lblAssets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hierarchyPanel
            // 
            this.hierarchyPanel.BackColor = System.Drawing.Color.Transparent;
            this.hierarchyPanel.Controls.Add(this.Hierarchy);
            this.hierarchyPanel.Controls.Add(this.lblHierarchy);
            this.hierarchyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchyPanel.Location = new System.Drawing.Point(0, 0);
            this.hierarchyPanel.Name = "hierarchyPanel";
            this.hierarchyPanel.Size = new System.Drawing.Size(200, 240);
            this.hierarchyPanel.TabIndex = 0;
            // 
            // Hierarchy
            // 
            this.Hierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hierarchy.Location = new System.Drawing.Point(0, 28);
            this.Hierarchy.Name = "Hierarchy";
            this.Hierarchy.Size = new System.Drawing.Size(200, 212);
            this.Hierarchy.TabIndex = 1;
            // 
            // lblHierarchy
            // 
            this.lblHierarchy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblHierarchy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHierarchy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHierarchy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblHierarchy.Location = new System.Drawing.Point(0, 0);
            this.lblHierarchy.Name = "lblHierarchy";
            this.lblHierarchy.Size = new System.Drawing.Size(200, 28);
            this.lblHierarchy.TabIndex = 0;
            this.lblHierarchy.Text = "Hierarchy";
            this.lblHierarchy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inspectorPanel
            // 
            this.inspectorPanel.BackColor = System.Drawing.Color.Transparent;
            this.inspectorPanel.Controls.Add(this.Inspector);
            this.inspectorPanel.Controls.Add(this.lblInspector);
            this.inspectorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inspectorPanel.Location = new System.Drawing.Point(584, 0);
            this.inspectorPanel.Name = "inspectorPanel";
            this.inspectorPanel.Size = new System.Drawing.Size(200, 481);
            this.inspectorPanel.TabIndex = 3;
            // 
            // Inspector
            // 
            this.Inspector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inspector.Location = new System.Drawing.Point(0, 28);
            this.Inspector.Name = "Inspector";
            this.Inspector.Size = new System.Drawing.Size(200, 453);
            this.Inspector.TabIndex = 5;
            // 
            // lblInspector
            // 
            this.lblInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInspector.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblInspector.Location = new System.Drawing.Point(0, 0);
            this.lblInspector.Name = "lblInspector";
            this.lblInspector.Size = new System.Drawing.Size(200, 28);
            this.lblInspector.TabIndex = 4;
            this.lblInspector.Text = "Inspector";
            this.lblInspector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Appbar.Controls.Add(this.button7);
            this.Appbar.Controls.Add(this.button6);
            this.Appbar.Controls.Add(this.button5);
            this.Appbar.Controls.Add(this.button4);
            this.Appbar.Controls.Add(this.button3);
            this.Appbar.Controls.Add(this.button2);
            this.Appbar.Controls.Add(this.button1);
            this.Appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appbar.Location = new System.Drawing.Point(0, 24);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(784, 56);
            this.Appbar.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackgroundImage = global::HareEditor.Properties.Resources.pause;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(368, 10);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.MaximumSize = new System.Drawing.Size(36, 36);
            this.button7.MinimumSize = new System.Drawing.Size(36, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 36);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackgroundImage = global::HareEditor.Properties.Resources.play;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(332, 10);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.MaximumSize = new System.Drawing.Size(36, 36);
            this.button6.MinimumSize = new System.Drawing.Size(36, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 36);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::HareEditor.Properties.Resources.Transform;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(164, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 36);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::HareEditor.Properties.Resources.resize;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(128, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 36);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::HareEditor.Properties.Resources.reload;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(93, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 36);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::HareEditor.Properties.Resources.directions;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(57, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 1;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HareEditor.Properties.Resources.grab2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(21, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(384, 212);
            this.button8.TabIndex = 0;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(384, 212);
            this.button9.TabIndex = 1;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.Resize += new System.EventHandler(this.Editor_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.wrapperPanel.ResumeLayout(false);
            this.renderPanel.ResumeLayout(false);
            this.scenePanel.ResumeLayout(false);
            this.Scene.ResumeLayout(false);
            this.gameViewPanel.ResumeLayout(false);
            this.Gameview.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.assetsPanel.ResumeLayout(false);
            this.hierarchyPanel.ResumeLayout(false);
            this.inspectorPanel.ResumeLayout(false);
            this.Appbar.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblHierarchy;
        private System.Windows.Forms.Label lblInspector;
        private System.Windows.Forms.Label lblScene;
        private System.Windows.Forms.Label lblGame;
        private Assets Assets;
        private Hierarchy Hierarchy;
        private Inspector Inspector;
        private Sceneview Scene;
        private Game Gameview;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem componentToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button8;
  }
}