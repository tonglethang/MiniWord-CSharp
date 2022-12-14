namespace TongLeThang_MiniWord
{
    partial class frmThang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuUndo = new System.Windows.Forms.ToolStripButton();
            this.menuRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbbFontText = new System.Windows.Forms.ToolStripComboBox();
            this.cbbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFontColor = new System.Windows.Forms.ToolStripButton();
            this.btnHighLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLeft = new System.Windows.Forms.ToolStripButton();
            this.btnCenter = new System.Windows.Forms.ToolStripButton();
            this.btnRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.desingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuClose,
            this.toolStripSeparator1,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Image = global::TongLeThang_MiniWord.Properties.Resources.iconnew;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(233, 26);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = global::TongLeThang_MiniWord.Properties.Resources.iconopen1;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(233, 26);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Image = global::TongLeThang_MiniWord.Properties.Resources.iconsave1;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(233, 26);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Image = global::TongLeThang_MiniWord.Properties.Resources.iconsaveas;
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuSaveAs.Size = new System.Drawing.Size(233, 26);
            this.menuSaveAs.Text = "Save As";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuClose
            // 
            this.menuClose.Image = global::TongLeThang_MiniWord.Properties.Resources.iconclose1;
            this.menuClose.Name = "menuClose";
            this.menuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuClose.Size = new System.Drawing.Size(233, 26);
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // menuExit
            // 
            this.menuExit.Image = global::TongLeThang_MiniWord.Properties.Resources.iconexit1;
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuExit.Size = new System.Drawing.Size(233, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.iconToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Image = global::TongLeThang_MiniWord.Properties.Resources.iconimage;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // iconToolStripMenuItem
            // 
            this.iconToolStripMenuItem.Image = global::TongLeThang_MiniWord.Properties.Resources.iconicon;
            this.iconToolStripMenuItem.Name = "iconToolStripMenuItem";
            this.iconToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iconToolStripMenuItem.Text = "Icon";
            this.iconToolStripMenuItem.Click += new System.EventHandler(this.iconToolStripMenuItem_Click);
            // 
            // desingToolStripMenuItem
            // 
            this.desingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFind,
            this.menuSelectAll});
            this.desingToolStripMenuItem.Name = "desingToolStripMenuItem";
            this.desingToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.desingToolStripMenuItem.Text = "Edit";
            this.desingToolStripMenuItem.Click += new System.EventHandler(this.desingToolStripMenuItem_Click);
            // 
            // menuFind
            // 
            this.menuFind.Image = global::TongLeThang_MiniWord.Properties.Resources.iconsearch;
            this.menuFind.Name = "menuFind";
            this.menuFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuFind.Size = new System.Drawing.Size(255, 26);
            this.menuFind.Text = "Find and Replace";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Image = global::TongLeThang_MiniWord.Properties.Resources.iconselect;
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuSelectAll.Size = new System.Drawing.Size(255, 26);
            this.menuSelectAll.Text = "Select all";
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.menuUndo,
            this.menuRedo,
            this.toolStripSeparator3,
            this.cbbFontText,
            this.cbbFontSize,
            this.toolStripSeparator4,
            this.btnBold,
            this.btnUnderline,
            this.btnItalic,
            this.toolStripSeparator7,
            this.btnFontColor,
            this.btnHighLight,
            this.toolStripSeparator5,
            this.btnLeft,
            this.btnCenter,
            this.btnRight,
            this.toolStripSeparator6,
            this.btnIn,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(902, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TongLeThang_MiniWord.Properties.Resources.iconpaste;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "Paste";
            this.toolStripButton1.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TongLeThang_MiniWord.Properties.Resources.iconcopy;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton2.Text = "Copy";
            this.toolStripButton2.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::TongLeThang_MiniWord.Properties.Resources.iconcut;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton3.Text = "Cut";
            this.toolStripButton3.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // menuUndo
            // 
            this.menuUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuUndo.Image = global::TongLeThang_MiniWord.Properties.Resources.iconundo1;
            this.menuUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.Size = new System.Drawing.Size(29, 25);
            this.menuUndo.Text = "Undo";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // menuRedo
            // 
            this.menuRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuRedo.Image = global::TongLeThang_MiniWord.Properties.Resources.iconredo;
            this.menuRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.Size = new System.Drawing.Size(29, 25);
            this.menuRedo.Text = "Redo";
            this.menuRedo.Click += new System.EventHandler(this.menuRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // cbbFontText
            // 
            this.cbbFontText.Name = "cbbFontText";
            this.cbbFontText.Size = new System.Drawing.Size(140, 28);
            this.cbbFontText.SelectedIndexChanged += new System.EventHandler(this.cbbFontText_SelectedIndexChanged);
            // 
            // cbbFontSize
            // 
            this.cbbFontSize.Items.AddRange(new object[] {
            "10",
            "12 ",
            "13",
            "14",
            "16",
            "17",
            "19",
            "20"});
            this.cbbFontSize.Name = "cbbFontSize";
            this.cbbFontSize.Size = new System.Drawing.Size(75, 28);
            this.cbbFontSize.Text = "13";
            this.cbbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbbFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = global::TongLeThang_MiniWord.Properties.Resources.iconb;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(29, 25);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = global::TongLeThang_MiniWord.Properties.Resources.iconu;
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(29, 25);
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = global::TongLeThang_MiniWord.Properties.Resources.iconi3;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(29, 25);
            this.btnItalic.Text = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // btnFontColor
            // 
            this.btnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFontColor.Image = global::TongLeThang_MiniWord.Properties.Resources.iconfontcolor;
            this.btnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(29, 25);
            this.btnFontColor.Text = "Text Color";
            this.btnFontColor.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // btnHighLight
            // 
            this.btnHighLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHighLight.Image = global::TongLeThang_MiniWord.Properties.Resources.iconhighlinght;
            this.btnHighLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHighLight.Name = "btnHighLight";
            this.btnHighLight.Size = new System.Drawing.Size(29, 25);
            this.btnHighLight.Text = "Text HighLight";
            this.btnHighLight.Click += new System.EventHandler(this.btnHighLight_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Aqua;
            this.btnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLeft.Image = global::TongLeThang_MiniWord.Properties.Resources.iconleft1;
            this.btnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(29, 25);
            this.btnLeft.Text = "Left";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCenter.Image = global::TongLeThang_MiniWord.Properties.Resources.iconcenter;
            this.btnCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(29, 25);
            this.btnCenter.Text = "Center";
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnRight
            // 
            this.btnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRight.Image = global::TongLeThang_MiniWord.Properties.Resources.iconright;
            this.btnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(29, 25);
            this.btnRight.Text = "Right";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // btnIn
            // 
            this.btnIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIn.Image = global::TongLeThang_MiniWord.Properties.Resources.iconin;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(29, 25);
            this.btnIn.Text = "Zoom In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOut.Image = global::TongLeThang_MiniWord.Properties.Resources.iconout;
            this.btnOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(29, 25);
            this.btnOut.Text = "Zoom Out";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // richText
            // 
            this.richText.ContextMenuStrip = this.contextMenuStrip1;
            this.richText.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richText.Location = new System.Drawing.Point(37, 74);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(826, 751);
            this.richText.TabIndex = 2;
            this.richText.Text = "";
            this.richText.TextChanged += new System.EventHandler(this.richText_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 82);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::TongLeThang_MiniWord.Properties.Resources.iconcut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::TongLeThang_MiniWord.Properties.Resources.iconcopy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::TongLeThang_MiniWord.Properties.Resources.iconpaste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(181, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 378);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseLeave += new System.EventHandler(this.listView1_MouseLeave);
            // 
            // frmThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 873);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniWord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThang_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThang_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbbFontText;
        private System.Windows.Forms.ToolStripComboBox cbbFontSize;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton menuUndo;
        private System.Windows.Forms.ToolStripButton menuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnCenter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnLeft;
        private System.Windows.Forms.ToolStripButton btnRight;
        private System.Windows.Forms.ToolStripButton btnFontColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripButton btnHighLight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton btnOut;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}

