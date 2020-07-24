using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace C____Windows_ {

    public class CodeEditor : RichTextBox {

        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
        }

        protected override void OnClick(EventArgs e) {
            base.OnClick(e);
        }

        protected override void OnDoubleClick(EventArgs e) {
            base.OnDoubleClick(e);
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            if (this.Text[this.SelectionStart] == '(') {
                this.AppendText
            }
        }

    }
}