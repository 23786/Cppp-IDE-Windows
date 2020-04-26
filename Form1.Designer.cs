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
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileAndRunMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunMenuBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.TextBox();
            this.SmallLabel = new System.Windows.Forms.Label();
            this.CompilerLabel = new System.Windows.Forms.Label();
            this.CompilerTextBox = new System.Windows.Forms.TextBox();
            this.MenuBar.SuspendLayout();
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
            this.CompileInfo.Location = new System.Drawing.Point(12, 718);
            this.CompileInfo.Name = "CompileInfo";
            this.CompileInfo.ReadOnly = true;
            this.CompileInfo.Size = new System.Drawing.Size(1095, 221);
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
            this.CompileButton.Location = new System.Drawing.Point(1132, 154);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(380, 97);
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
            this.TextView.Location = new System.Drawing.Point(12, 61);
            this.TextView.Name = "TextView";
            this.TextView.Size = new System.Drawing.Size(1095, 637);
            this.TextView.TabIndex = 0;
            this.TextView.Text = "";
            this.TextView.TextChanged += new System.EventHandler(this.TextView_TextChanged);
            this.TextView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextView_KeyDown);
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
            this.compileToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1539, 39);
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
            this.NewFileMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.NewFileMenuBarItem.Text = "New File";
            this.NewFileMenuBarItem.Click += new System.EventHandler(this.NewFileMenuBarItem_Click);
            // 
            // OpenFileMenuBarItem
            // 
            this.OpenFileMenuBarItem.Name = "OpenFileMenuBarItem";
            this.OpenFileMenuBarItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.OpenFileMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.OpenFileMenuBarItem.Text = "Open File";
            this.OpenFileMenuBarItem.Click += new System.EventHandler(this.OpenFileMenuBarItem_Click);
            // 
            // SaveFileMenuBarItem
            // 
            this.SaveFileMenuBarItem.Name = "SaveFileMenuBarItem";
            this.SaveFileMenuBarItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.SaveFileMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.SaveFileMenuBarItem.Text = "Save File";
            this.SaveFileMenuBarItem.Click += new System.EventHandler(this.SaveFileMenuBarItem_Click);
            // 
            // SaveAsMenuBarItem
            // 
            this.SaveAsMenuBarItem.Name = "SaveAsMenuBarItem";
            this.SaveAsMenuBarItem.ShortcutKeyDisplayString = "";
            this.SaveAsMenuBarItem.Size = new System.Drawing.Size(359, 44);
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
            this.CopyMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.CopyMenuBarItem.Text = "Copy";
            this.CopyMenuBarItem.Click += new System.EventHandler(this.CopyMenuBarItem_Click);
            // 
            // PasteMenuBarItem
            // 
            this.PasteMenuBarItem.Name = "PasteMenuBarItem";
            this.PasteMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.PasteMenuBarItem.Text = "Paste";
            this.PasteMenuBarItem.Click += new System.EventHandler(this.PasteMenuBarItem_Click);
            // 
            // UndoMenuBarItem
            // 
            this.UndoMenuBarItem.Name = "UndoMenuBarItem";
            this.UndoMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.UndoMenuBarItem.Text = "Undo";
            this.UndoMenuBarItem.Click += new System.EventHandler(this.UndoMenuBarItem_Click);
            // 
            // RedoMenuBarItem
            // 
            this.RedoMenuBarItem.Name = "RedoMenuBarItem";
            this.RedoMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.RedoMenuBarItem.Text = "Redo";
            this.RedoMenuBarItem.Click += new System.EventHandler(this.RedoMenuBarItem_Click);
            // 
            // CutMenuBarItem
            // 
            this.CutMenuBarItem.Name = "CutMenuBarItem";
            this.CutMenuBarItem.Size = new System.Drawing.Size(359, 44);
            this.CutMenuBarItem.Text = "Cut";
            this.CutMenuBarItem.Click += new System.EventHandler(this.CutMenuBarItem_Click);
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
            this.FileNameLabel.Location = new System.Drawing.Point(1128, 61);
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
            this.StatusBar.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StatusBar.Location = new System.Drawing.Point(1131, 103);
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
            this.SmallLabel.Location = new System.Drawing.Point(1165, 891);
            this.SmallLabel.Name = "SmallLabel";
            this.SmallLabel.Size = new System.Drawing.Size(322, 43);
            this.SmallLabel.TabIndex = 9;
            this.SmallLabel.Text = "C+++ For Windows 1.0.0";
            this.SmallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompilerLabel
            // 
            this.CompilerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompilerLabel.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompilerLabel.Location = new System.Drawing.Point(1128, 280);
            this.CompilerLabel.Name = "CompilerLabel";
            this.CompilerLabel.Size = new System.Drawing.Size(139, 36);
            this.CompilerLabel.TabIndex = 10;
            this.CompilerLabel.Text = "Compiler";
            // 
            // CompilerTextBox
            // 
            this.CompilerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompilerTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompilerTextBox.Location = new System.Drawing.Point(1267, 278);
            this.CompilerTextBox.Name = "CompilerTextBox";
            this.CompilerTextBox.Size = new System.Drawing.Size(244, 39);
            this.CompilerTextBox.TabIndex = 11;
            this.CompilerTextBox.Text = "g++.exe";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1539, 951);
            this.Controls.Add(this.CompilerTextBox);
            this.Controls.Add(this.CompilerLabel);
            this.Controls.Add(this.SmallLabel);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.TextView);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.CompileInfo);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.MenuBar;
            this.MinimumSize = new System.Drawing.Size(1565, 1022);
            this.Name = "Form1";
            this.Text = "Untitled";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
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
        private System.Windows.Forms.Label CompilerLabel;
        private System.Windows.Forms.TextBox CompilerTextBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

