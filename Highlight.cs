using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace C____Windows_ {

    public partial class Form1 {

        RichTextBox tmpTextView = new RichTextBox();
        string FontName = "Consolas";
        float FontSize = 10.0F;


        string[] keyword = {
             "if", "else", "while", "signed", "throw", "union", "this",
             "int", "char", "double", "unsigned", "const", "goto", "virtual",
              "for", "float", "break", "auto", "class", "operator", "case",
              "do", "long", "typedef", "static", "friend", "template", "default",
              "new", "void", "register", "extern", "return", "enum", "inline",
              "try", "short", "continue", "sizeof", "switch", "private", "protected",
              "asm", "catch", "delete", "public", "voltaile", "struct", "using", 
              "namespace"
        };
        string[] Stantard = {
            "std", "string", "cin", "cout", "printf", "scanf", "fin",
            "fout", "sprintf", "sscanf", "strlen", "strcmp", "strcpy", "memcpy",
            "sort", "swap", "memset", "pow", "gets", "puts", "cos", "tan",
            "sin", "floor", "toupper", "tolower", "getline", "min", "max",
            "abs", "sqrt", "atof", "atoi", "system", "qsort", "freopen", "fclose",
            "endl", "stdin", "stdout"
        };
        Hashtable keywords = new Hashtable();
        Hashtable stantard = new Hashtable();
        private void KeywordsInitialize() {
            foreach (string s in keyword) {
                keywords.Add(s, "1");
            }
            foreach (string s in Stantard) {
                stantard.Add(s, "1");
            }
        }


        /// <summary>
        /// C++语法高亮
        /// </summary>
        /// <param name="start">起始行号</param>
        private void RichHighlight(int start) {

            // 记录一开始的选中位置和长度
            int SelectionStart = TextView.SelectionStart;
            int SelectionLength = TextView.SelectionLength;

            tmpTextView.Rtf = this.TextView.Rtf;

            tmpTextView.SelectAll();
            tmpTextView.SelectionColor = Color.Black;
            tmpTextView.SelectionFont = new Font(FontName, FontSize, FontStyle.Regular);
            tmpTextView.Text.Replace("\t", "    ");
            string[] everyLine = tmpTextView.Text.Split('\n');
            int pos = 0;
            int lnum = 0;
            foreach (string currentLine in everyLine) {
                if (lnum >= start) {
                    string replacedCurrentLine = currentLine.Replace("(", " ").Replace(")", " ").Replace(">", " ");
                    replacedCurrentLine = replacedCurrentLine.Replace("[", " ").Replace("]", " ").Replace("<", " ");
                    replacedCurrentLine = replacedCurrentLine.Replace("{", " ").Replace("}", " ").Replace(":", " ");
                    replacedCurrentLine = replacedCurrentLine.Replace(".", " ").Replace("=", " ").Replace(";", " ");
                    if (currentLine.Trim().StartsWith("//")) {
                        tmpTextView.Select(pos, currentLine.Length);
                        tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.Gray;
                        pos += currentLine.Length + 1;
                        continue;
                    }
                    if (currentLine.Trim().StartsWith("#")) {
                        tmpTextView.Select(pos, currentLine.Length);
                        tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.Purple;
                        pos += currentLine.Length + 1;
                        continue;
                    }
                    ArrayList marks = new ArrayList();
                    string smark = "";
                    string last = "";
                    bool inmark = false;
                    for (int i = 0; i < replacedCurrentLine.Length; i += 1) {
                        if (replacedCurrentLine.Substring(i, 1) == "\"" && last != "\\") {
                            if (inmark) {
                                marks.Add(smark + "," + i);
                                smark = "";
                                inmark = false;
                            } else {
                                smark += i;
                                inmark = true;
                            }
                        }
                        last = replacedCurrentLine.Substring(i, 1);
                    }
                    if (inmark) {
                        marks.Add(smark + "," + replacedCurrentLine.Length);
                    }

                    string[] everyWord = replacedCurrentLine.Split(' ', '\t');
                    int x = 0;
                    foreach (string tv in everyWord) {
                        if (tv.Length < 2) {
                            x += tv.Length + 1;
                            continue;
                        } else {
                            bool find = false;
                            foreach (string px in marks) {
                                string[] pa = px.Split(',');
                                if (x >= int.Parse(pa[0]) && x < int.Parse(pa[1])) {
                                    find = true;
                                    break;
                                }
                            }
                            if (!find) {
                                if (keywords[tv] != null) {
                                    tmpTextView.Select(pos + x, tv.Length);
                                    tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Bold));
                                    tmpTextView.SelectionColor = Color.DarkOrange;
                                }
                                if (stantard[tv] != null) {
                                    tmpTextView.Select(pos + x, tv.Length);
                                    tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                                    tmpTextView.SelectionColor = Color.Brown;
                                }
                            }
                            x += tv.Length + 1;
                        }
                    }
                    foreach (string px in marks) {
                        string[] pa = px.Split(',');
                        tmpTextView.Select(pos + int.Parse(pa[0]), int.Parse(pa[1]) - int.Parse(pa[0]) + 1);
                        tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.OrangeRed;
                    }
                }
                pos += currentLine.Length + 1;
                lnum += 1;
            }
            TextView.Rtf = tmpTextView.Rtf;
            TextView.Select(SelectionStart, SelectionLength);
        }
    }
}