using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Windows_ {

    public interface PreferencesDelegate {

        void didSetColor();
        
    }

    public partial class Preferences : Form {

        public PreferencesDelegate Delegate;

        public Preferences() {
            InitializeComponent();
            setup();
        }

        public void setup() {

            Console.WriteLine("SettingUp...");

            var config = ConfigFile.LoadOrCreateFile("C+++Config.config");

            Color lkc = ColorFromString(config.GetConfigValue("LightKeywordColor"));
            Color dkc = ColorFromString(config.GetConfigValue("DarkKeywordColor"));
            Color lncc = ColorFromString(config.GetConfigValue("LightNormalCodeColor"));
            Color dncc = ColorFromString(config.GetConfigValue("DarkNormalCodeColor"));
            Color lsc = ColorFromString(config.GetConfigValue("LightSymbolColor"));
            Color dsc = ColorFromString(config.GetConfigValue("DarkSymbolColor"));
            Color lpc = ColorFromString(config.GetConfigValue("LightPreprocessorColor"));
            Color dpc = ColorFromString(config.GetConfigValue("DarkPreprocessorColor"));
            Color lfc = ColorFromString(config.GetConfigValue("LightBuiltInColor"));
            Color dfc = ColorFromString(config.GetConfigValue("DarkBuiltInColor"));
            Color lstrc = ColorFromString(config.GetConfigValue("LightStringColor"));
            Color dstrc = ColorFromString(config.GetConfigValue("DarkStringColor"));
            Color lcc = ColorFromString(config.GetConfigValue("LightCommentColor"));
            Color dcc = ColorFromString(config.GetConfigValue("DarkCommentColor"));

            Color ColorFromString(string a) {
                return ColorTranslator.FromHtml(a);
            }

            this.LightK.ForeColor = lkc; this.DarkK.ForeColor = dkc;
            this.LightBIF.ForeColor = lfc; this.DarkBIF.ForeColor = dfc;
            this.LightS.ForeColor = lsc; this.DarkS.ForeColor = dsc;
            this.LightPre.ForeColor = lpc; this.DarkPre.ForeColor = dpc;
            this.LightC.ForeColor = lcc; this.DarkC.ForeColor = dcc;
            this.LightStr.ForeColor = lstrc; this.DarkStr.ForeColor = dstrc;
            this.LightCode.ForeColor = lncc; this.DarkCode.ForeColor = dncc;


        }


        public void SetLightTheme(object sender, EventArgs e) {
            var bt = (Label)sender;
            var config = ConfigFile.LoadOrCreateFile("C+++Config.config");
            Color a;
            if (ColorDialog.ShowDialog() != DialogResult.OK) {
                return;
            } else {
                a = ColorDialog.Color;
            }
            string str = ColorTranslator.ToHtml(a);
            
            switch (bt.Text) {
                case "Keyword":
                    config.AddOrSetConfigValue("LightKeywordColor", str);
                    break;
                case "Built-In functions":
                    config.AddOrSetConfigValue("LightBuiltInColor", str);
                    break;
                case "Symbol":
                    config.AddOrSetConfigValue("LightSymbolColor", str);
                    break;
                case "Preprocessor":
                    config.AddOrSetConfigValue("LightPreprocessorColor", str);
                    break;
                case "Comment":
                    config.AddOrSetConfigValue("LightCommentColor", str);
                    break;
                case "String":
                    config.AddOrSetConfigValue("LightStringColor", str);
                    break;
                case "Code":
                    config.AddOrSetConfigValue("LightNormalCodeColor", str);
                    break;
                default:
                    MessageBox.Show("An error ocurred. Please try again.", "Error");
                    break;
            }
            if (this.Delegate == null) {
                return;
            }
            this.Delegate.didSetColor();
            setup();
        }

        public void SetDarkTheme(object sender, EventArgs e) {
            var bt = (Label)sender;
            var config = ConfigFile.LoadOrCreateFile("C+++Config.config");
            Color a;
            if (ColorDialog.ShowDialog() != DialogResult.OK) {
                return;
            } else {
                a = ColorDialog.Color;
            }
            string str = ColorTranslator.ToHtml(a);

            switch (bt.Text) {
                case "Keyword":
                    config.AddOrSetConfigValue("DarkKeywordColor", str);
                    break;
                case "Built-In functions":
                    config.AddOrSetConfigValue("DarkBuiltInColor", str);
                    break;
                case "Symbol":
                    config.AddOrSetConfigValue("DarkSymbolColor", str);
                    break;
                case "Preprocessor":
                    config.AddOrSetConfigValue("DarkPreprocessorColor", str);
                    break;
                case "Comment":
                    config.AddOrSetConfigValue("DarkCommentColor", str);
                    break;
                case "String":
                    config.AddOrSetConfigValue("DarkStringColor", str);
                    break;
                case "Code":
                    config.AddOrSetConfigValue("DarkNormalCodeColor", str);
                    break;
                default:
                    MessageBox.Show("An error ocurred. Please try again.", "Error");
                    break;
            }
            if (this.Delegate == null) {
                return;
            }
            this.Delegate.didSetColor();
            setup();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }


}
