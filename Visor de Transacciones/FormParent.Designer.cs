using System.Windows.Forms;

namespace Visor_de_Transacciones
{
    partial class FormParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParent));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.ViewMenu,
            this.ToolsMenu,
            this.WindowsMenu,
            this.HelpMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.MdiWindowListItem = this.WindowsMenu;
            this.MenuStrip.Name = "menuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(632, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.ToolStripSeparator3,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ToolStripSeparator4,
            this.PrintToolStripMenuItem,
            this.PrintPreviewToolStripMenuItem,
            this.PrintSetupToolStripMenuItem,
            this.ToolStripSeparator5,
            this.ExitToolStripMenuItem});
            this.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.FileMenu.Name = "fileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.NewToolStripMenuItem.Name = "newToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.NewToolStripMenuItem.Text = "&New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenToolStripMenuItem.Name = "openToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "toolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SaveAsToolStripMenuItem.Text = "Save &As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "toolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.PrintToolStripMenuItem.Name = "printToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.PrintPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.PrintPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.PrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.PrintPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printSetupToolStripMenuItem
            // 
            this.PrintSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.PrintSetupToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.PrintSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // toolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "toolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.ToolStripSeparator6,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.ToolStripSeparator7,
            this.SelectAllToolStripMenuItem});
            this.EditMenu.Name = "editMenu";
            this.EditMenu.Size = new System.Drawing.Size(39, 20);
            this.EditMenu.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.UndoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.UndoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.RedoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.RedoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "toolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(161, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.CutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CutToolStripMenuItem.Text = "Cu&t";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.CopyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CopyToolStripMenuItem.Text = "&Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.PasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "toolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SelectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarToolStripMenuItem,
            this.StatusBarToolStripMenuItem});
            this.ViewMenu.Name = "viewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(44, 20);
            this.ViewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.ToolBarToolStripMenuItem.Checked = true;
            this.ToolBarToolStripMenuItem.CheckOnClick = true;
            this.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.ToolBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ToolBarToolStripMenuItem.Text = "&Toolbar";
            this.ToolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.StatusBarToolStripMenuItem.Checked = true;
            this.StatusBarToolStripMenuItem.CheckOnClick = true;
            this.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.StatusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.StatusBarToolStripMenuItem.Text = "&Status Bar";
            this.StatusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
            this.ToolsMenu.Name = "toolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(48, 20);
            this.ToolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.OptionsToolStripMenuItem.Text = "&Options";
            // 
            // windowsMenu
            // 
            this.WindowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWindowToolStripMenuItem,
            this.CascadeToolStripMenuItem,
            this.TileVerticalToolStripMenuItem,
            this.TileHorizontalToolStripMenuItem,
            this.CloseAllToolStripMenuItem,
            this.ArrangeIconsToolStripMenuItem});
            this.WindowsMenu.Name = "windowsMenu";
            this.WindowsMenu.Size = new System.Drawing.Size(68, 20);
            this.WindowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.NewWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.NewWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.NewWindowToolStripMenuItem.Text = "&New Window";
            this.NewWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.CascadeToolStripMenuItem.Text = "&Cascade";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.TileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.TileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.TileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.TileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.TileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.TileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.TileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.CloseAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.CloseAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.CloseAllToolStripMenuItem.Text = "C&lose All";
            this.CloseAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.ArrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.ArrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.ArrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContentsToolStripMenuItem,
            this.IndexToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.ToolStripSeparator8,
            this.AboutToolStripMenuItem});
            this.HelpMenu.Name = "helpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.ContentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.ContentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ContentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ContentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.IndexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.IndexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.IndexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.IndexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.SearchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.SearchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "toolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // toolStrip
            // 
            this.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.ToolStripComboBox1,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.ToolStripSeparator1,
            this.PrintToolStripButton,
            this.PrintPreviewToolStripButton,
            this.ToolStripSeparator2,
            this.HelpToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "toolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(632, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.NewToolStripButton.Name = "newToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "New";
            this.NewToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // toolStripComboBox1
            // 
            this.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox1.Name = "toolStripComboBox1";
            this.ToolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // openToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenToolStripButton.Name = "openToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "Open";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveToolStripButton.Name = "saveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "toolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.PrintToolStripButton.Name = "printToolStripButton";
            this.PrintToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrintToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            this.PrintPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.PrintPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.PrintPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrintPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "toolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.HelpToolStripButton.Name = "helpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HelpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 431);
            this.StatusStrip.Name = "statusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(632, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "toolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.ToolStripStatusLabel.Text = "Status";
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FormParent";
            this.Text = "FormParent";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;


    }
}



