using System;
using System.Drawing;
using System.Windows.Forms;

namespace C____Windows_ {


    public partial class Form1 : Form {


        public void print(params object[] items) {
            foreach  (object i in items) {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("\n");
        }

        private void showLineNo() {

            // 获得当前坐标信息
            Point p = this.TextView.Location;
            int crntFirstIndex = this.TextView.GetCharIndexFromPosition(p); // 获取左上角第一个字符的索引
            int crntFirstLine = this.TextView.GetLineFromCharIndex(crntFirstIndex); // 从刚刚获取的位置得到目前显示的第一行的行号
            Point crntFirstPos = this.TextView.GetPositionFromCharIndex(crntFirstIndex); // 获取左上角第一个字符的位置

            p.Y += this.TextView.Height;
            int crntLastIndex = this.TextView.GetCharIndexFromPosition(p); // 获取左下角字符的位置索引
            int crntLastLine = this.TextView.GetLineFromCharIndex(crntLastIndex); // 获取最后一行的行号
            Point crntLastPos = this.TextView.GetPositionFromCharIndex(crntLastIndex); // 获取左下角第一个字符的位置

            //准备画图
            Graphics g = this.panel1.CreateGraphics();
            Font font = new Font(this.TextView.Font, this.TextView.Font.Style);
            SolidBrush brush = new SolidBrush(NormalCodeColor);

            //画图开始
            Rectangle rect = this.panel1.ClientRectangle;
            brush.Color = this.panel1.BackColor;
            g.FillRectangle(brush, 0, 0, this.panel1.ClientRectangle.Width, this.panel1.ClientRectangle.Height);
            brush.Color = NormalCodeColor;

            int lineSpace;

            if (crntFirstLine != crntLastLine) {
                lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine);
            } else {
                lineSpace = Convert.ToInt32(this.TextView.Font.Height);
            }

            int brushX = this.panel1.ClientRectangle.Width - Convert.ToInt32(font.Size * 3) - 15;
            int brushY = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21f);
            for (int i = crntLastLine + 1; i >= crntFirstLine; i -= 1) {
                if (i == 0) break;
                g.DrawString(i.ToString(), font, brush, brushX, brushY);
                brushY -= lineSpace;
            }

            g.Dispose();
            font.Dispose();
            brush.Dispose();

        }
    }
}