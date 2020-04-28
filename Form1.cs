using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace C____Windows_ {
    
    public partial class Form1 : Form { 

        private string FileName = "Untitled";
        private bool Compiled = false;

        protected void OpenFile(string path) {

            Form1 newForm = new Form1(null);
            newForm.TextView.Clear();
            newForm.TextView.Text = File.ReadAllText(path);
            newForm.FileNameLabel.Text = path;
            newForm.FileName = path;
            newForm.Text = path;
            newForm.RichHighlight(0);
            newForm.CountCharacters();
            if (Appearance) {
                newForm.SwitchToDarkMode();
            }
            newForm.showLineNo();
            newForm.Show();


        }

        private void CountCharacters() {
            this.StatusBar.Text = this.TextView.Lines.Length.ToString() + " Lines | " + this.TextView.TextLength.ToString() + " Characters";
        }

        private void SaveFile() {
            try {
                File.WriteAllText(FileName, TextView.Text);
            } catch(IOException EX) {
                MessageBox.Show(EX.Message, "Error");
            }
            this.FileNameLabel.Text = FileName;
            this.Text = FileName;
        }

        private void CompileFile() {
            if (FileName == "Untitled") {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK) {
                    FileName = SaveFileDialog.FileName;
                    SaveFile();
                } else {
                    return;
                }
            }
            SaveFile();
            Compiled = true;
            CompileInfo.Text = "Compiling...";
            string outputFilePath = DeleteSuffix(FileName);
            string command = CompilerTextBox.Text + " \"" + FileName + "\" -o \"" + outputFilePath + ".exe\"";

            string compileResult = RunCmd(command, 0, true, true);
            string res;
            if (compileResult == "") {
                res = "Compile Succeed!\nCompile Command:\n" + command;
            } else if (!compileResult.Contains("error")) {
                res = "Compile Succeed!\nCompile Command:\n" + command + "\n\n" + compileResult;
            } else {
                res = "Compile Failed.\nCompile Command:\n" + command + "\n\n" + compileResult;
            }
            CompileInfo.Text = res;
        }

        private string DeleteSuffix(string s) {
            return Path.GetDirectoryName(s) + @"\" + Path.GetFileNameWithoutExtension(s);
        }

        private void RunExe() {

            if (Compiled == false) {
                MessageBox.Show("The file hasn't been compiled yet. Please save the file and compile it.", "Not Compiled");
                return;
            }

            string outputFilePath = DeleteSuffix(FileName);

            Process.Start(outputFilePath);

        }

        private string RunCmd(string command, int milliseconds, bool errorOrOutput, bool createNoWindow) {
            Process p = new Process();
            string res = string.Empty;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + command;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = createNoWindow;
            try {
                if (p.Start()) {
                    if (milliseconds == 0)
                        p.WaitForExit();
                    else
                        p.WaitForExit(milliseconds);
                    if (errorOrOutput) res = p.StandardError.ReadToEnd();
                    else res = p.StandardOutput.ReadToEnd();
                }
            } catch {
                this.CompileInfo.Text = "Error";
            } finally {
                if (p != null)
                    p.Close();
            }
            return res;
        }



        public Form1(string fileName) {
            InitializeComponent();
            KeywordsInitialize();
            if (fileName != null) {
                this.TextView.Clear();
                this.TextView.Text = File.ReadAllText(fileName);
                this.FileNameLabel.Text = fileName;
                this.FileName = fileName;
                this.Text = fileName;
                this.RichHighlight(0);
                this.CountCharacters();
                this.Show();
                this.showLineNo();
            }
        }




        // Menu Bar

        private void ButtonClicked(object sender, EventArgs e) {
            CompileFile();
            RunExe();
        }

        private void QuitMenuBarItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void AboutMenuBarItem_Click(object sender, EventArgs e) {
            MessageBox.Show("C+++ is an C++ IDE on Windows and macOS Platform.\nDeveloped by 23786.\nCopyright (C) 2020 Zhu Yixuan. All Rights Reserved.", @"About C+++");
        }

        private void NewFileMenuBarItem_Click(object sender, EventArgs e) {
            Form1 newForm = new Form1(null);
            if (Appearance) {
                newForm.SwitchToDarkMode();
            }
            newForm.Show();
        }

        private void OpenFileMenuBarItem_Click(object sender, EventArgs e) {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
                OpenFile(OpenFileDialog.FileName);
            }
        }

        private void SaveAsMenuBarItem_Click(object sender, EventArgs e) {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK) {
                FileName = SaveFileDialog.FileName;
                SaveFile();
            }
        }

        private void SaveFileMenuBarItem_Click(object sender, EventArgs e) {
            if (FileName == "Untitled") {
                SaveAsMenuBarItem_Click(sender, e);
            } else {
                SaveFile();
            }
        }

        private void CopyMenuBarItem_Click(object sender, EventArgs e) {
            TextView.Copy();
        }

        private void PasteMenuBarItem_Click(object sender, EventArgs e) {
            TextView.Paste();
        }

        private void UndoMenuBarItem_Click(object sender, EventArgs e) {
            TextView.Undo();
        }

        private void RedoMenuBarItem_Click(object sender, EventArgs e) {
            TextView.Redo();
        }

        private void CompileAndRunMenuBarItem_Click(object sender, EventArgs e) {
            CompileFile();
            RunExe();
        }

        private void CompileMenuBarItem_Click(object sender, EventArgs e) {
            CompileFile();
        }

        private void RunMenuBarItem_Click(object sender, EventArgs e) {
            RunExe();
        }

        // TextChanged()
        private void TextView_TextChanged(object sender, EventArgs e) {

            RichHighlight(0);
            CountCharacters();
            showLineNo();
            
        }

        // KeyDown()
        private void TextView_KeyDown(object sender, KeyEventArgs e) {

            int Count(string a, string substr) {
                string replacedStr = a.Replace(substr, "");
                return (a.Length - replacedStr.Length) / substr.Length;
            }

            int Match(string str, string a) {
                int _cnt = 0;
                int times = str.Length > a.Length ? a.Length : str.Length;
                for (int i = 0; i < times; i += 1) {
                    if (str[i] == a[i]) {
                        _cnt += 1;
                    } else {
                        return _cnt;
                    }
                }
                return _cnt;
            }

            // 自动缩进
            if (e.KeyData == Keys.Enter) {
                int location = TextView.SelectionStart;
                string a = TextView.Text.Substring(0, location);
                int b = Count(a, "{") - Count(a, "}");
                insertText(TextView, "\n");
                for (int i = 1; i <= b; i += 1) {
                    insertText(TextView, "\t");
                }
                e.Handled = true;
                return;
            }

            // 自动补全提示
            try {
                var array = TextView.Text.Substring(0, TextView.SelectionStart).Split('\n', '\t', ' ', '(', ')', '[', ']', '{', '}', ';', ':');
                currWord = array[array.Length - 1];
            } catch {
                return;
            }
            Control[] controls = TextView.Controls.Find("__",false);
            if (controls.Length > 0)
                controls[0].Dispose();
            ListBox ListBox = new ListBox();
            ListBox.Name = "__";
            ListBox.TabIndex = 100;
            ListBox.Location = TextView.GetPositionFromCharIndex(TextView.SelectionStart);
            ListBox.Height = 200; ListBox.Width = 200;
            ListBox.BackColor = System.Drawing.Color.Black; ListBox.ForeColor = System.Drawing.Color.White;
            ListBox.Font = new Font("Microsoft Yahei UI", 8.0F, FontStyle.Regular);
            ListBox.Click += HintListClicked;
            var cnt = 0;
            foreach (string key in completion) {
                if (Match(key, currWord.Replace("(", "").Replace(")", "")) >= currWord.Length && currWord.Length >= 3) {
                    ListBox.Items.Add(key);
                    cnt += 1;
                }
            }
            if (cnt >= 1) {
                ListBox.Left += 20;
                ListBox.Show();
                TextView.Controls.Add(ListBox);
            }
        }
        private string currWord = "";
        private void HintListClicked(object sender, EventArgs a) {
            var lb = (ListBox)sender;
            string title = lb.SelectedItem.ToString();
            try {
                insertText(TextView, title.Substring(currWord.Length, title.Length - currWord.Length));
            } catch {

            }
            lb.Dispose();
        }
        private void insertText(RichTextBox TextBox, string a) {
            int i = TextBox.SelectionStart;
            TextBox.Focus();
            TextBox.Text = TextBox.Text.Insert(i, a);
            TextBox.Select(i + a.Length, 0);
        }

        private void HideMenuBarItem_Click(object sender, EventArgs e) {
            this.Hide();
        }
        
        // FormClosing();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (FileName == "Untitled") {
                if (TextView.Text == "") {
                    return;
                } else {
                    if (MessageBox.Show("Do you want to save the file?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        SaveAsMenuBarItem_Click(sender, e);
                    }
                }
            } else {
                SaveFile();
            }
        }

        private void CutMenuBarItem_Click(object sender, EventArgs e) {
            TextView.Cut();
        }

        private void ChooseFontMenuBarItem_Click(object sender, EventArgs e) {
            if (FontDialog.ShowDialog() == DialogResult.OK) {
                FontName = FontDialog.Font.Name;
                FontSize = FontDialog.Font.Size;
                RichHighlight(0);
            }
        }

        private void TextView_VScroll(object sender, EventArgs e) {
            showLineNo();
        }

        private void TextView_Resize(object sender, EventArgs e) {
            showLineNo();
        }

        private void ChangeAppearanceButton_Click(object sender, EventArgs e) {
            if (Appearance) {
                SwitchToLightMode();
            } else {
                SwitchToDarkMode();
            }
            showLineNo();
        }

        private void TextView_Click(object sender, EventArgs e) {
            Control[] controls = TextView.Controls.Find("__", false);
            if (controls.Length > 0)
                controls[0].Dispose();
        }

        private void TextView_SelectionChanged(object sender, EventArgs e) {
            try {
                var array = TextView.Text.Substring(0, TextView.SelectionStart).Split('\n','\t', ' ', '(', ')', '[', ']', '{', '}', ';', ':');
                currWord = array[array.Length - 1];
            } catch {
                return;
            }
        }
    }
}