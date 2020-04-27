using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

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

        private void TextView_KeyDown(object sender, KeyEventArgs e) {
            /*int Count(string a, string substr) {
                string replacedStr = a.Replace(substr, "");
                return (a.Length - replacedStr.Length) / substr.Length;
            }
            if (e.KeyData == Keys.Enter) {
                button2.Text = TextView.SelectionStart.ToString();
                int location = TextView.SelectionStart;
                string a = TextView.Text.Substring(0, location);
                int b = Count(a, "{") - Count(a, "}");
                TextView.Text = TextView.Text.Insert(location, "\n");
                for (int i = 1; i <= b; i += 1) {
                    TextView.Text = TextView.Text.Insert(TextView.SelectionStart, "    ");
                }
                e.Handled = true;
            }*/
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
    }
}