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
            int pos = 0, lineNo = 0;
            foreach (string currentLine in everyLine) {
                if (lineNo >= start) {
                    string replacedCurrentLine = currentLine.Replace("(", " ").Replace(")", " ").Replace(">", " ");
                    replacedCurrentLine = replacedCurrentLine.Replace("[", " ").Replace("]", " ").Replace("<", " ");
                    replacedCurrentLine = replacedCurrentLine.Replace("{", " ").Replace("}", " ").Replace(":", " ");
                    replacedCurrentLine = replacedCurrentLine.Replace(".", " ").Replace("=", " ").Replace(";", " ");

                    // 注释
                    if (currentLine.Trim().StartsWith("//")) {
                        tmpTextView.Select(pos, currentLine.Length);
                        tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.Gray;
                        pos += currentLine.Length + 1;
                        continue;
                    }

                    // 预处理
                    if (currentLine.Trim().StartsWith("#")) {
                        tmpTextView.Select(pos, currentLine.Length);
                        tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.Purple;
                        pos += currentLine.Length + 1;
                        continue;
                    }


                    // 新建一个字符串数组，然后把当前行出现的所有的双引号所包住的内容存储在里面
                    // 格式为"<开始的位置>,<结束的位置>"
                    ArrayList marks = new ArrayList();
                    string smark = "";
                    string last = "";
                    bool isInQuote = false;
                    for (int i = 0; i < replacedCurrentLine.Length; i += 1) {
                        if (replacedCurrentLine.Substring(i, 1) == "\"" && last != "\\") {
                            if (isInQuote) {
                                marks.Add(smark + "," + i);
                                smark = "";
                                isInQuote = false;
                            } else {
                                smark += i;
                                isInQuote = true;
                            }
                        }
                        last = replacedCurrentLine.Substring(i, 1);
                    }
                    if (isInQuote) {
                        marks.Add(smark + "," + replacedCurrentLine.Length);
                    }




                    // 标点符号 
                    for (int i = 0; i < currentLine.Length; i += 1) {
                        bool find = false;
                        foreach (string px in marks) {
                            string[] pa = px.Split(',');
                            if (i >= int.Parse(pa[0]) && i < int.Parse(pa[1])) {
                                find = true;
                                break;
                            }
                        }
                        if (!find) {
                            if (currentLine[i] == '+' || currentLine[i] == '-'
                                || currentLine[i] == '/' || currentLine[i] == '*'
                                || currentLine[i] == '=' || currentLine[i] == '&'
                                || currentLine[i] == '^' || currentLine[i] == '<'
                                || currentLine[i] == '>' || currentLine[i] == '|'
                                || currentLine[i] == '!' || currentLine[i] == '%') {
                                tmpTextView.Select(pos + i, 1);
                                tmpTextView.SelectionColor = Color.Blue;
                            }
                        }
                    }




                    string[] everyWord = replacedCurrentLine.Split(' ', '\t');
                    int x = 0;
                    foreach (string currentWord in everyWord) {
                        if (currentWord.Length < 2) {
                            x += currentWord.Length + 1;
                            continue;
                        } else {
                            bool find = false;

                            // 判断这个字符串是否被双引号包住
                            foreach (string px in marks) {
                                string[] pa = px.Split(',');
                                if (x >= int.Parse(pa[0]) && x < int.Parse(pa[1])) {
                                    find = true;
                                    break;
                                }
                            }

                            if (!find) {

                                // 关键字
                                if (keywords[currentWord] != null) {
                                    tmpTextView.Select(pos + x, currentWord.Length);
                                    tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Bold));
                                    tmpTextView.SelectionColor = Color.DarkOrange;
                                }

                                // 常用库函数
                                if (stantard[currentWord] != null) {
                                    tmpTextView.Select(pos + x, currentWord.Length);
                                    tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                                    tmpTextView.SelectionColor = Color.Brown;
                                }
                            }
                            x += currentWord.Length + 1;
                        }
                    }

                    // 被引号包住的内容
                    foreach (string px in marks) {
                        string[] pa = px.Split(',');
                        tmpTextView.Select(pos + int.Parse(pa[0]), int.Parse(pa[1]) - int.Parse(pa[0]) + 1);
                        tmpTextView.SelectionFont = new Font(FontName, FontSize, (FontStyle.Regular));
                        tmpTextView.SelectionColor = Color.OrangeRed;
                    }

                }
                pos += currentLine.Length + 1;
                lineNo += 1;
            }
            TextView.Rtf = tmpTextView.Rtf;
            TextView.Select(SelectionStart, SelectionLength);
        }
    }
}