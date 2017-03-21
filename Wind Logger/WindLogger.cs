using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Wind_Logger
{
    class WindLogger
    {
        private ssl_windlogger form = null;
        private RichTextBox log = null;
        private RichTextBox help = null;

        private int x = 0;

        public WindLogger(ssl_windlogger form)
        {
            this.form = form;
            log = form.Controls.Find("txt_log", false)[0] as RichTextBox;
            help = form.Controls.Find("txt_help", false)[0] as RichTextBox;
        }

        public void LogWind(int wind)
        {
            if(wind > 0)
                log.AppendText(wind + " ►" + Environment.NewLine);
            else if(wind < 0)
                log.AppendText("◄ " + (-1*wind) + Environment.NewLine);
            else
                log.AppendText(wind + Environment.NewLine);
        }

        public void HandleHotkey(string key)
        {
            switch(key)
            {
                case "F1":
                    LogWind(-30);
                    break;

                case "F2":
                    LogWind(-20);
                    break;

                case "F3":
                    LogWind(-10);
                    break;

                case "F4":
                    LogWind(0);
                    break;

                case "F5":
                    LogWind(10);
                    break;

                case "F6":
                    LogWind(20);
                    break;

                case "F7":
                    LogWind(30);
                    break;

                case "F8":
                    ClearLog();
                    break;

                case "F10":
                    if (help.Visible)
                        help.Hide();
                    else
                        help.Show();
                    break;

                default:
                    break;
            }
        }

        public void LogError(string error)
        {
            log.AppendText(error + Environment.NewLine);
        }

        public void ClearLog()
        {
            log.Clear();
        }
    }
}
