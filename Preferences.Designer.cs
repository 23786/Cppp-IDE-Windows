namespace C____Windows_ {
    partial class Preferences {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.LightK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LightStr = new System.Windows.Forms.Label();
            this.LightCode = new System.Windows.Forms.Label();
            this.LightC = new System.Windows.Forms.Label();
            this.LightPre = new System.Windows.Forms.Label();
            this.LightS = new System.Windows.Forms.Label();
            this.LightBIF = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DarkStr = new System.Windows.Forms.Label();
            this.DarkCode = new System.Windows.Forms.Label();
            this.DarkC = new System.Windows.Forms.Label();
            this.DarkPre = new System.Windows.Forms.Label();
            this.DarkS = new System.Windows.Forms.Label();
            this.DarkBIF = new System.Windows.Forms.Label();
            this.DarkK = new System.Windows.Forms.Label();
            this.PreferencesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LightK
            // 
            this.LightK.Location = new System.Drawing.Point(24, 19);
            this.LightK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightK.Name = "LightK";
            this.LightK.Size = new System.Drawing.Size(274, 56);
            this.LightK.TabIndex = 0;
            this.LightK.Text = "Keyword";
            this.LightK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightK.Click += new System.EventHandler(this.SetLightTheme);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LightStr);
            this.panel1.Controls.Add(this.LightCode);
            this.panel1.Controls.Add(this.LightC);
            this.panel1.Controls.Add(this.LightPre);
            this.panel1.Controls.Add(this.LightS);
            this.panel1.Controls.Add(this.LightBIF);
            this.panel1.Controls.Add(this.LightK);
            this.panel1.Location = new System.Drawing.Point(47, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 424);
            this.panel1.TabIndex = 2;
            // 
            // LightStr
            // 
            this.LightStr.Location = new System.Drawing.Point(24, 299);
            this.LightStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightStr.Name = "LightStr";
            this.LightStr.Size = new System.Drawing.Size(274, 56);
            this.LightStr.TabIndex = 6;
            this.LightStr.Text = "String";
            this.LightStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightStr.Click += new System.EventHandler(this.SetLightTheme);
            // 
            // LightCode
            // 
            this.LightCode.Location = new System.Drawing.Point(24, 355);
            this.LightCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightCode.Name = "LightCode";
            this.LightCode.Size = new System.Drawing.Size(274, 56);
            this.LightCode.TabIndex = 5;
            this.LightCode.Text = "Code";
            this.LightCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightCode.Click += new System.EventHandler(this.SetLightTheme);
            // 
            // LightC
            // 
            this.LightC.Location = new System.Drawing.Point(24, 243);
            this.LightC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightC.Name = "LightC";
            this.LightC.Size = new System.Drawing.Size(274, 56);
            this.LightC.TabIndex = 4;
            this.LightC.Text = "Comment";
            this.LightC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightC.Click += new System.EventHandler(this.SetLightTheme);
            // 
            // LightPre
            // 
            this.LightPre.Location = new System.Drawing.Point(24, 187);
            this.LightPre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightPre.Name = "LightPre";
            this.LightPre.Size = new System.Drawing.Size(274, 56);
            this.LightPre.TabIndex = 3;
            this.LightPre.Text = "Preprocessor";
            this.LightPre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightPre.Click += new System.EventHandler(this.SetLightTheme);
            // 
            // LightS
            // 
            this.LightS.Location = new System.Drawing.Point(24, 131);
            this.LightS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightS.Name = "LightS";
            this.LightS.Size = new System.Drawing.Size(274, 56);
            this.LightS.TabIndex = 2;
            this.LightS.Text = "Symbol";
            this.LightS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightS.Click += new System.EventHandler(this.SetLightTheme);
            // 
            // LightBIF
            // 
            this.LightBIF.Location = new System.Drawing.Point(24, 75);
            this.LightBIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LightBIF.Name = "LightBIF";
            this.LightBIF.Size = new System.Drawing.Size(274, 56);
            this.LightBIF.TabIndex = 1;
            this.LightBIF.Text = "Built-In functions";
            this.LightBIF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightBIF.Click += new System.EventHandler(this.SetLightTheme);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.DarkStr);
            this.panel2.Controls.Add(this.DarkCode);
            this.panel2.Controls.Add(this.DarkC);
            this.panel2.Controls.Add(this.DarkPre);
            this.panel2.Controls.Add(this.DarkS);
            this.panel2.Controls.Add(this.DarkBIF);
            this.panel2.Controls.Add(this.DarkK);
            this.panel2.Location = new System.Drawing.Point(435, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 424);
            this.panel2.TabIndex = 7;
            // 
            // DarkStr
            // 
            this.DarkStr.Location = new System.Drawing.Point(24, 299);
            this.DarkStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DarkStr.Name = "DarkStr";
            this.DarkStr.Size = new System.Drawing.Size(274, 56);
            this.DarkStr.TabIndex = 6;
            this.DarkStr.Text = "String";
            this.DarkStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkStr.Click += new System.EventHandler(this.SetDarkTheme);
            // 
            // DarkCode
            // 
            this.DarkCode.Location = new System.Drawing.Point(24, 355);
            this.DarkCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DarkCode.Name = "DarkCode";
            this.DarkCode.Size = new System.Drawing.Size(274, 56);
            this.DarkCode.TabIndex = 5;
            this.DarkCode.Text = "Code";
            this.DarkCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkCode.Click += new System.EventHandler(this.SetDarkTheme);
            // 
            // DarkC
            // 
            this.DarkC.Location = new System.Drawing.Point(24, 243);
            this.DarkC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DarkC.Name = "DarkC";
            this.DarkC.Size = new System.Drawing.Size(274, 56);
            this.DarkC.TabIndex = 4;
            this.DarkC.Text = "Comment";
            this.DarkC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkC.Click += new System.EventHandler(this.SetDarkTheme);
            // 
            // DarkPre
            // 
            this.DarkPre.Location = new System.Drawing.Point(24, 187);
            this.DarkPre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DarkPre.Name = "DarkPre";
            this.DarkPre.Size = new System.Drawing.Size(274, 56);
            this.DarkPre.TabIndex = 3;
            this.DarkPre.Text = "Preprocessor";
            this.DarkPre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkPre.Click += new System.EventHandler(this.SetDarkTheme);
            // 
            // DarkS
            // 
            this.DarkS.Location = new System.Drawing.Point(24, 131);
            this.DarkS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DarkS.Name = "DarkS";
            this.DarkS.Size = new System.Drawing.Size(274, 56);
            this.DarkS.TabIndex = 2;
            this.DarkS.Text = "Symbol";
            this.DarkS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkS.Click += new System.EventHandler(this.SetDarkTheme);
            // 
            // DarkBIF
            // 
            this.DarkBIF.Location = new System.Drawing.Point(24, 75);
            this.DarkBIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DarkBIF.Name = "DarkBIF";
            this.DarkBIF.Size = new System.Drawing.Size(274, 56);
            this.DarkBIF.TabIndex = 1;
            this.DarkBIF.Text = "Built-In functions";
            this.DarkBIF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkBIF.Click += new System.EventHandler(this.SetDarkTheme);
            // 
            // DarkK
            // 
            this.DarkK.Location = new System.Drawing.Point(24, 19);
            this.DarkK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DarkK.Name = "DarkK";
            this.DarkK.Size = new System.Drawing.Size(274, 56);
            this.DarkK.TabIndex = 0;
            this.DarkK.Text = "Keyword";
            this.DarkK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkK.Click += new System.EventHandler(this.SetDarkTheme);
            // 
            // PreferencesLabel
            // 
            this.PreferencesLabel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PreferencesLabel.Location = new System.Drawing.Point(38, 20);
            this.PreferencesLabel.Name = "PreferencesLabel";
            this.PreferencesLabel.Size = new System.Drawing.Size(306, 64);
            this.PreferencesLabel.TabIndex = 8;
            this.PreferencesLabel.Text = "Preferences";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Syntax Highlight";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(71, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "Light";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(459, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dark";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(713, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 52);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 675);
            this.ControlBox = false;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreferencesLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LightK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LightPre;
        private System.Windows.Forms.Label LightS;
        private System.Windows.Forms.Label LightBIF;
        private System.Windows.Forms.Label LightC;
        private System.Windows.Forms.Label LightCode;
        private System.Windows.Forms.Label LightStr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DarkStr;
        private System.Windows.Forms.Label DarkCode;
        private System.Windows.Forms.Label DarkC;
        private System.Windows.Forms.Label DarkPre;
        private System.Windows.Forms.Label DarkS;
        private System.Windows.Forms.Label DarkBIF;
        private System.Windows.Forms.Label DarkK;
        private System.Windows.Forms.Label PreferencesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button SaveButton;
    }
}