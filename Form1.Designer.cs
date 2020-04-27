namespace C____Windows_ {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CompileInfo = new System.Windows.Forms.RichTextBox();
            this.CompileButton = new System.Windows.Forms.Button();
            this.TextView = new System.Windows.Forms.RichTextBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreferencesMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseFontMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileAndRunMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.TextBox();
            this.SmallLabel = new System.Windows.Forms.Label();
            this.CompilerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CompileInfo
            // 
            this.CompileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileInfo.BackColor = System.Drawing.Color.White;
            this.CompileInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompileInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompileInfo.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompileInfo.ForeColor = System.Drawing.Color.Black;
            this.CompileInfo.Location = new System.Drawing.Point(12, 752);
            this.CompileInfo.Name = "CompileInfo";
            this.CompileInfo.ReadOnly = true;
            this.CompileInfo.Size = new System.Drawing.Size(1130, 265);
            this.CompileInfo.TabIndex = 7;
            this.CompileInfo.Text = "";
            // 
            // CompileButton
            // 
            this.CompileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CompileButton.FlatAppearance.BorderSize = 0;
            this.CompileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompileButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompileButton.Location = new System.Drawing.Point(1167, 154);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(380, 83);
            this.CompileButton.TabIndex = 1;
            this.CompileButton.Text = "Compile and Run";
            this.CompileButton.UseVisualStyleBackColor = false;
            this.CompileButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // TextView
            // 
            this.TextView.AcceptsTab = true;
            this.TextView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextView.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextView.Location = new System.Drawing.Point(64, 61);
            this.TextView.Name = "TextView";
            this.TextView.Size = new System.Drawing.Size(1078, 667);
            this.TextView.TabIndex = 0;
            this.TextView.Text = "";
            this.TextView.VScroll += new System.EventHandler(this.TextView_VScroll);
            this.TextView.TextChanged += new System.EventHandler(this.TextView_TextChanged);
            this.TextView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextView_KeyDown);
            this.TextView.Resize += new System.EventHandler(this.TextView_Resize);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.White;
            this.MenuBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.compileToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1574, 39);
            this.MenuBar.TabIndex = 5;
            this.MenuBar.Text = "MenuBar";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuBarItem,
            this.PreferencesMenuBarItem,
            this.HideMenuBarItem,
            this.QuitMenuBarItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(104, 35);
            this.cToolStripMenuItem.Text = "C+++";
            // 
            // AboutMenuBarItem
            // 
            this.AboutMenuBarItem.Name = "AboutMenuBarItem";
            this.AboutMenuBarItem.Size = new System.Drawing.Size(378, 44);
            this.AboutMenuBarItem.Text = "About C+++";
            this.AboutMenuBarItem.Click += new System.EventHandler(this.AboutMenuBarItem_Click);
            // 
            // PreferencesMenuBarItem
            // 
            this.PreferencesMenuBarItem.Name = "PreferencesMenuBarItem";
            this.PreferencesMenuBarItem.ShortcutKeyDisplayString = "Ctrl+,";
            this.PreferencesMenuBarItem.Size = new System.Drawing.Size(378, 44);
            this.PreferencesMenuBarItem.Text = "Preferences...";
            // 
            // HideMenuBarItem
            // 
            this.HideMenuBarItem.Name = "HideMenuBarItem";
            this.HideMenuBarItem.Size = new System.Drawing.Size(378, 44);
            this.HideMenuBarItem.Text = "Hide";
            this.HideMenuBarItem.Click += new System.EventHandler(this.HideMenuBarItem_Click);
            // 
            // QuitMenuBarItem
            // 
            this.QuitMenuBarItem.Name = "QuitMenuBarItem";
            this.QuitMenuBarItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.QuitMenuBarItem.Size = new System.Drawing.Size(378, 44);
            this.QuitMenuBarItem.Text = "Quit";
            this.QuitMenuBarItem.Click += new System.EventHandler(this.QuitMenuBarItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileMenuBarItem,
            this.OpenFileMenuBarItem,
            this.SaveFileMenuBarItem,
            this.SaveAsMenuBarItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 35);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewFileMenuBarItem
            // 
            this.NewFileMenuBarItem.Name = "NewFileMenuBarItem";
            this.NewFileMenuBarItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.NewFileMenuBarItem.Size = new System.Drawing.Size(349, 44);
            this.NewFileMenuBarItem.Text = "New File";
            this.NewFileMenuBarItem.Click += new System.EventHandler(this.NewFileMenuBarItem_Click);
            // 
            // OpenFileMenuBarItem
            // 
            this.OpenFileMenuBarItem.Name = "OpenFileMenuBarItem";
            this.OpenFileMenuBarItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.OpenFileMenuBarItem.Size = new System.Drawing.Size(349, 44);
            this.OpenFileMenuBarItem.Text = "Open File";
            this.OpenFileMenuBarItem.Click += new System.EventHandler(this.OpenFileMenuBarItem_Click);
            // 
            // SaveFileMenuBarItem
            // 
            this.SaveFileMenuBarItem.Name = "SaveFileMenuBarItem";
            this.SaveFileMenuBarItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.SaveFileMenuBarItem.Size = new System.Drawing.Size(349, 44);
            this.SaveFileMenuBarItem.Text = "Save File";
            this.SaveFileMenuBarItem.Click += new System.EventHandler(this.SaveFileMenuBarItem_Click);
            // 
            // SaveAsMenuBarItem
            // 
            this.SaveAsMenuBarItem.Name = "SaveAsMenuBarItem";
            this.SaveAsMenuBarItem.ShortcutKeyDisplayString = "";
            this.SaveAsMenuBarItem.Size = new System.Drawing.Size(349, 44);
            this.SaveAsMenuBarItem.Text = "Save As";
            this.SaveAsMenuBarItem.Click += new System.EventHandler(this.SaveAsMenuBarItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenuBarItem,
            this.PasteMenuBarItem,
            this.UndoMenuBarItem,
            this.RedoMenuBarItem,
            this.CutMenuBarItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShowShortcutKeys = false;
            this.editToolStripMenuItem.Size = new System.Drawing.Size(77, 35);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // CopyMenuBarItem
            // 
            this.CopyMenuBarItem.Name = "CopyMenuBarItem";
            this.CopyMenuBarItem.ShowShortcutKeys = false;
            this.CopyMenuBarItem.Size = new System.Drawing.Size(210, 44);
            this.CopyMenuBarItem.Text = "Copy";
            this.CopyMenuBarItem.Click += new System.EventHandler(this.CopyMenuBarItem_Click);
            // 
            // PasteMenuBarItem
            // 
            this.PasteMenuBarItem.Name = "PasteMenuBarItem";
            this.PasteMenuBarItem.Size = new System.Drawing.Size(210, 44);
            this.PasteMenuBarItem.Text = "Paste";
            this.PasteMenuBarItem.Click += new System.EventHandler(this.PasteMenuBarItem_Click);
            // 
            // UndoMenuBarItem
            // 
            this.UndoMenuBarItem.Name = "UndoMenuBarItem";
            this.UndoMenuBarItem.Size = new System.Drawing.Size(210, 44);
            this.UndoMenuBarItem.Text = "Undo";
            this.UndoMenuBarItem.Click += new System.EventHandler(this.UndoMenuBarItem_Click);
            // 
            // RedoMenuBarItem
            // 
            this.RedoMenuBarItem.Name = "RedoMenuBarItem";
            this.RedoMenuBarItem.Size = new System.Drawing.Size(210, 44);
            this.RedoMenuBarItem.Text = "Redo";
            this.RedoMenuBarItem.Click += new System.EventHandler(this.RedoMenuBarItem_Click);
            // 
            // CutMenuBarItem
            // 
            this.CutMenuBarItem.Name = "CutMenuBarItem";
            this.CutMenuBarItem.Size = new System.Drawing.Size(210, 44);
            this.CutMenuBarItem.Text = "Cut";
            this.CutMenuBarItem.Click += new System.EventHandler(this.CutMenuBarItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseFontMenuBarItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(89, 35);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // ChooseFontMenuBarItem
            // 
            this.ChooseFontMenuBarItem.Name = "ChooseFontMenuBarItem";
            this.ChooseFontMenuBarItem.Size = new System.Drawing.Size(307, 44);
            this.ChooseFontMenuBarItem.Text = "Choose a font";
            this.ChooseFontMenuBarItem.Click += new System.EventHandler(this.ChooseFontMenuBarItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompileAndRunMenuBarItem,
            this.CompileMenuBarItem,
            this.RunMenuBarItem});
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(128, 35);
            this.compileToolStripMenuItem.Text = "Compile";
            // 
            // CompileAndRunMenuBarItem
            // 
            this.CompileAndRunMenuBarItem.Name = "CompileAndRunMenuBarItem";
            this.CompileAndRunMenuBarItem.Size = new System.Drawing.Size(450, 44);
            this.CompileAndRunMenuBarItem.Text = "Compile and Run (Default)";
            this.CompileAndRunMenuBarItem.Click += new System.EventHandler(this.CompileAndRunMenuBarItem_Click);
            // 
            // CompileMenuBarItem
            // 
            this.CompileMenuBarItem.Name = "CompileMenuBarItem";
            this.CompileMenuBarItem.Size = new System.Drawing.Size(450, 44);
            this.CompileMenuBarItem.Text = "Compile";
            this.CompileMenuBarItem.Click += new System.EventHandler(this.CompileMenuBarItem_Click);
            // 
            // RunMenuBarItem
            // 
            this.RunMenuBarItem.Name = "RunMenuBarItem";
            this.RunMenuBarItem.Size = new System.Drawing.Size(450, 44);
            this.RunMenuBarItem.Text = "Run";
            this.RunMenuBarItem.Click += new System.EventHandler(this.RunMenuBarItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "C++ Source File|*.cpp|C Source File|*.c|C++ Source File|*.cxx|C++ Header|*.h|All " +
    "Files|*.*";
            this.OpenFileDialog.Title = "Open File";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "C++ Source File|*.cpp|C Source File|*.c|C++ Source File|*.cxx|C++ Header|*.h|All " +
    "Files|*.*";
            this.SaveFileDialog.Title = "Save File";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileNameLabel.Location = new System.Drawing.Point(1163, 61);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(385, 36);
            this.FileNameLabel.TabIndex = 6;
            this.FileNameLabel.Text = "Untitled";
            // 
            // StatusBar
            // 
            this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.StatusBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusBar.Enabled = false;
            this.StatusBar.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StatusBar.Location = new System.Drawing.Point(1166, 103);
            this.StatusBar.Multiline = true;
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.ReadOnly = true;
            this.StatusBar.Size = new System.Drawing.Size(380, 43);
            this.StatusBar.TabIndex = 8;
            this.StatusBar.Text = "0 Lines | 0 Characters";
            // 
            // SmallLabel
            // 
            this.SmallLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SmallLabel.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SmallLabel.Location = new System.Drawing.Point(1200, 969);
            this.SmallLabel.Name = "SmallLabel";
            this.SmallLabel.Size = new System.Drawing.Size(322, 43);
            this.SmallLabel.TabIndex = 9;
            this.SmallLabel.Text = "C+++ For Windows 1.0.0";
            this.SmallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompilerTextBox
            // 
            this.CompilerTextBox.AcceptsTab = true;
            this.CompilerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompilerTextBox.BackColor = System.Drawing.Color.White;
            this.CompilerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompilerTextBox.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompilerTextBox.Location = new System.Drawing.Point(1166, 250);
            this.CompilerTextBox.Name = "CompilerTextBox";
            this.CompilerTextBox.Size = new System.Drawing.Size(146, 35);
            this.CompilerTextBox.TabIndex = 11;
            this.CompilerTextBox.Text = "g++.exe";
            this.CompilerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(1308, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "New File";
            this.label1.Click += new System.EventHandler(this.NewFileMenuBarItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(1313, 383);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 69);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Create a new C++ source file\r\n";
            this.textBox1.Click += new System.EventHandler(this.NewFileMenuBarItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1166, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 137);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NewFileMenuBarItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(1313, 536);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(218, 69);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Open an exsisting C++ file\r\n\r\n";
            this.textBox2.Click += new System.EventHandler(this.OpenFileMenuBarItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(1308, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "Open File";
            this.label2.Click += new System.EventHandler(this.OpenFileMenuBarItem_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(1166, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 137);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.OpenFileMenuBarItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(1313, 688);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(190, 69);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "Save the current C++ file";
            this.textBox3.Click += new System.EventHandler(this.SaveFileMenuBarItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(1308, 648);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 26;
            this.label3.Text = "Save File";
            this.label3.Click += new System.EventHandler(this.SaveFileMenuBarItem_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(1166, 633);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(380, 137);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.SaveFileMenuBarItem_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(1313, 841);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(190, 69);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "Duplicate the current C++ file";
            this.textBox4.Click += new System.EventHandler(this.SaveAsMenuBarItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(1308, 801);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 36);
            this.label4.TabIndex = 30;
            this.label4.Text = "Save As";
            this.label4.Click += new System.EventHandler(this.SaveAsMenuBarItem_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(1166, 786);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(380, 137);
            this.button5.TabIndex = 33;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.SaveAsMenuBarItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox4.Image = global::C____Windows_.Properties.Resources.DuplicateFile;
            this.pictureBox4.Location = new System.Drawing.Point(1184, 800);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 104);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.SaveAsMenuBarItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.Image = global::C____Windows_.Properties.Resources.SaveFile;
            this.pictureBox3.Location = new System.Drawing.Point(1184, 647);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.SaveFileMenuBarItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::C____Windows_.Properties.Resources.OpenFile;
            this.pictureBox1.Location = new System.Drawing.Point(1184, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OpenFileMenuBarItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Image = global::C____Windows_.Properties.Resources.NewFile;
            this.pictureBox2.Location = new System.Drawing.Point(1184, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.NewFileMenuBarItem_Click);
            // 
            // FontDialog
            // 
            this.FontDialog.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontDialog.MaxSize = 100;
            this.FontDialog.MinSize = 5;
            this.FontDialog.ShowEffects = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(5, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 667);
            this.panel1.TabIndex = 34;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1574, 1029);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompilerTextBox);
            this.Controls.Add(this.SmallLabel);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.TextView);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.CompileInfo);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MinimumSize = new System.Drawing.Size(1600, 1100);
            this.Name = "Form1";
            this.Text = "Untitled";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox CompileInfo;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.RichTextBox TextView;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem PreferencesMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem QuitMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFileMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuBarItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem RedoMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompileAndRunMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem CompileMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem RunMenuBarItem;
        private System.Windows.Forms.ToolStripMenuItem HideMenuBarItem;
        private System.Windows.Forms.TextBox StatusBar;
        private System.Windows.Forms.ToolStripMenuItem CutMenuBarItem;
        private System.Windows.Forms.Label SmallLabel;
        private System.Windows.Forms.TextBox CompilerTextBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseFontMenuBarItem;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.Panel panel1;
    }
}

