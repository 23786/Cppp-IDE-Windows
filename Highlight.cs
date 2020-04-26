using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace C____Windows_ {

    public partial class Form1 {

        RichTextBox tmpTextView = new RichTextBox();


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
            "abs", "sqrt", "atof", "atoi", "system", "qsort", "freopen", "fclose"
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
            tmpTextView.SelectionFont = new Font("Consolas", 10, FontStyle.Regular);
            tmpTextView.Text.Replace("\t", "    ");
            string[] ln = tmpTextView.Text.Split('\n');
            int pos = 0;
            int lnum = 0;
            foreach (string lv in ln) {
                if (lnum >= start) {
                    string ts = lv.Replace("(", " ").Replace(")", " ").Replace(">", " ");
                    ts = ts.Replace("[", " ").Replace("]", " ").Replace("<", " ");
                    ts = ts.Replace("{", " ").Replace("}", " ").Replace(":", " ");
                    ts = ts.Replace(".", " ").Replace("=", " ").Replace(";", " ");
                    if (lv.Trim().StartsWith("//")) {
                        tmpTextView.Select(pos, lv.Length);
                        tmpTextView.SelectionFont = new Font("Consolas", 10, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.Gray;
                        pos += lv.Length + 1;
                        continue;
                    }
                    if (lv.Trim().StartsWith("#")) {
                        tmpTextView.Select(pos, lv.Length);
                        tmpTextView.SelectionFont = new Font("Consolas", 10, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.Green;
                        pos += lv.Length + 1;
                        continue;
                    }
                    ArrayList marks = new ArrayList();
                    string smark = "";
                    string last = "";
                    bool inmark = false;
                    for (int i = 0; i < ts.Length; i++) {
                        if (ts.Substring(i, 1) == "\"" && last != "\\") {
                            if (inmark) {
                                marks.Add(smark + "," + i);
                                smark = "";
                                inmark = false;
                            } else {
                                smark += i;
                                inmark = true;
                            }
                        }
                        last = ts.Substring(i, 1);
                    }
                    if (inmark) {
                        marks.Add(smark + "," + ts.Length);
                    }

                    string[] ta = ts.Split(' ', '\t');
                    int x = 0;
                    foreach (string tv in ta) {
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
                                    tmpTextView.SelectionFont = new Font("Consolas", 10, (FontStyle.Bold));
                                    tmpTextView.SelectionColor = Color.Blue;
                                }
                                if (stantard[tv] != null) {
                                    tmpTextView.Select(pos + x, tv.Length);
                                    tmpTextView.SelectionFont = new Font("Consolas", 10, (FontStyle.Regular));
                                    tmpTextView.SelectionColor = Color.Purple;
                                }
                            }
                            x += tv.Length + 1;
                        }
                    }
                    foreach (string px in marks) {
                        string[] pa = px.Split(',');
                        tmpTextView.Select(pos + int.Parse(pa[0]), int.Parse(pa[1]) - int.Parse(pa[0]) + 1);
                        tmpTextView.SelectionFont = new Font("Consolas", 10, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.DarkRed;
                    }
                }
                pos += lv.Length + 1;
                lnum++;
            }
            // 设置一下，才能恢复；后续正确！
            TextView.Rtf = tmpTextView.Rtf;
            TextView.Select(SelectionStart, SelectionLength);
            //tmpTextView.SelectionFont = new Font("Consolas", 10, (FontStyle.Regular));
            //tmpTextView.SelectionColor = Color.Black;
        }
    }
}