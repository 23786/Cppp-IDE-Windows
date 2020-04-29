using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

struct CDColor {

    public Color CurrColor;
    public Color LightColor;
    public Color DarkColor;

    public CDColor(Color curr, Color light, Color dark) {
        CurrColor = curr;
        LightColor = light;
        DarkColor = dark;
    }

}


namespace C____Windows_ {

    public partial class Form1 : Form {

        bool Appearance = false;
        
        CDColor NormalCodeColor = new CDColor(Color.Black, Color.Black, Color.White);
        CDColor KeyWordColor = new CDColor(Color.DarkOrange, Color.DarkOrange, Color.LightBlue);
        CDColor SymbolColor = new CDColor(Color.Blue, Color.Blue, Color.Pink);
        CDColor FunctionColor = new CDColor(Color.Brown, Color.Brown, Color.Yellow);
        CDColor PreColor = new CDColor(Color.Purple, Color.Purple, Color.Orange);
        CDColor StringColor = new CDColor(Color.OrangeRed, Color.OrangeRed, Color.LightCoral);
        CDColor CommentColor = new CDColor(Color.Gray, Color.Gray, Color.Gray);


        void SwitchToDarkMode() {

            Appearance = true;

            Color GrayColor = Color.FromArgb(255, 60, 60, 60);

            this.BackColor = GrayColor;
            this.FileNameLabel.ForeColor = Color.White;
            this.FileNameLabel.BackColor = GrayColor;
            this.StatusBar.ForeColor = Color.White;
            this.StatusBar.BackColor = GrayColor;
            this.TextView.BackColor = Color.Black;
            this.CompileInfo.BackColor = Color.Black;
            this.CompileInfo.ForeColor = Color.White;
            this.panel1.BackColor = GrayColor;
            this.CompileButton.BackColor = Color.DimGray;
            this.CompileButton.ForeColor = Color.White;
            this.CompilerTextBox.BackColor = Color.DimGray;
            this.CompilerTextBox.ForeColor = Color.White;

            this.SaveAsBgButton.BackColor = Color.DimGray;
            this.SaveAsImage.BackColor = Color.DimGray;
            this.SaveAsLabel.BackColor = Color.DimGray;
            this.SaveAsLabel.ForeColor = Color.White;
            this.SaveAsExplanation.ForeColor = Color.White;
            this.SaveAsExplanation.BackColor = Color.DimGray;

            this.SaveFileBgButton.BackColor = Color.DimGray;
            this.SaveFileImage.BackColor = Color.DimGray;
            this.SaveFileLabel.BackColor = Color.DimGray;
            this.SaveFileLabel.ForeColor = Color.White;
            this.SaveFileExplanation.ForeColor = Color.White;
            this.SaveFileExplanation.BackColor = Color.DimGray;

            this.OpenFileBgButton.BackColor = Color.DimGray;
            this.OpenFileImage.BackColor = Color.DimGray;
            this.OpenFileLabel.BackColor = Color.DimGray;
            this.OpenFileLabel.ForeColor = Color.White;
            this.OpenFileExplanation.ForeColor = Color.White;
            this.OpenFileExplanation.BackColor = Color.DimGray;

            this.NewFileBgButton.BackColor = Color.DimGray;
            this.NewFileImage.BackColor = Color.DimGray;
            this.NewFileLabel.BackColor = Color.DimGray;
            this.NewFileLabel.ForeColor = Color.White;
            this.NewFileExplanation.ForeColor = Color.White;
            this.NewFileExplanation.BackColor = Color.DimGray;

            this.ChangeAppearanceButton.BackColor = GrayColor;
            this.SmallLabel.ForeColor = Color.White;

            this.MenuBar.BackColor = GrayColor;
            this.MenuBar.ForeColor = Color.White;

            NormalCodeColor.CurrColor = NormalCodeColor.DarkColor;
            PreColor.CurrColor = PreColor.DarkColor;
            KeyWordColor.CurrColor = KeyWordColor.DarkColor;
            StringColor.CurrColor = StringColor.DarkColor;
            CommentColor.CurrColor = CommentColor.DarkColor;
            SymbolColor.CurrColor = SymbolColor.DarkColor;
            FunctionColor.CurrColor = FunctionColor.DarkColor;

            RichHighlight(0);
            showLineNo();


        }

        void SwitchToLightMode() {

            Appearance = false;

            Color LightColor = Color.FromKnownColor(System.Drawing.KnownColor.Control);
            Color ControlLight = Color.FromKnownColor(System.Drawing.KnownColor.ControlLight);

            this.BackColor = LightColor;
            this.FileNameLabel.ForeColor = Color.Black;
            this.FileNameLabel.BackColor = LightColor;
            this.StatusBar.ForeColor = Color.Black;
            this.StatusBar.BackColor = LightColor;
            this.TextView.BackColor = Color.White;
            this.CompileInfo.BackColor = Color.White;
            this.CompileInfo.ForeColor = Color.Black;
            this.panel1.BackColor = LightColor;
            this.CompileButton.BackColor = ControlLight;
            this.CompileButton.ForeColor = Color.Black;
            this.CompilerTextBox.BackColor = ControlLight;
            this.CompilerTextBox.ForeColor = Color.Black;

            this.SaveAsBgButton.BackColor = ControlLight;
            this.SaveAsImage.BackColor = ControlLight;
            this.SaveAsLabel.BackColor = ControlLight;
            this.SaveAsLabel.ForeColor = Color.Black;
            this.SaveAsExplanation.ForeColor = Color.Black;
            this.SaveAsExplanation.BackColor = ControlLight;

            this.SaveFileBgButton.BackColor = ControlLight;
            this.SaveFileImage.BackColor = ControlLight;
            this.SaveFileLabel.BackColor = ControlLight;
            this.SaveFileLabel.ForeColor = Color.Black;
            this.SaveFileExplanation.ForeColor = Color.Black;
            this.SaveFileExplanation.BackColor = ControlLight;

            this.OpenFileBgButton.BackColor = ControlLight;
            this.OpenFileImage.BackColor = ControlLight;
            this.OpenFileLabel.BackColor = ControlLight;
            this.OpenFileLabel.ForeColor = Color.Black;
            this.OpenFileExplanation.ForeColor = Color.Black;
            this.OpenFileExplanation.BackColor = ControlLight;

            this.NewFileBgButton.BackColor = ControlLight;
            this.NewFileImage.BackColor = ControlLight;
            this.NewFileLabel.BackColor = ControlLight;
            this.NewFileLabel.ForeColor = Color.Black;
            this.NewFileExplanation.ForeColor = Color.Black;
            this.NewFileExplanation.BackColor = ControlLight;

            this.ChangeAppearanceButton.BackColor = LightColor;
            this.SmallLabel.ForeColor = Color.Black;

            this.MenuBar.BackColor = LightColor;
            this.MenuBar.ForeColor = Color.Black;

            NormalCodeColor.CurrColor = NormalCodeColor.LightColor;
            PreColor.CurrColor = PreColor.LightColor;
            KeyWordColor.CurrColor = KeyWordColor.LightColor;
            StringColor.CurrColor = StringColor.LightColor;
            CommentColor.CurrColor = CommentColor.LightColor;
            SymbolColor.CurrColor = SymbolColor.LightColor;
            FunctionColor.CurrColor = FunctionColor.LightColor;

            RichHighlight(0);
            showLineNo();

        }

    }
}
