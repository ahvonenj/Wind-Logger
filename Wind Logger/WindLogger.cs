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
        private Chart windChart = null;

        private int x = 0;
        private int enemyDir = 1;

        private int? lastWind = null;

        public WindLogger(ssl_windlogger form)
        {
            this.form = form;
            log = form.Controls.Find("txt_log", false)[0] as RichTextBox;
            help = form.Controls.Find("txt_help", false)[0] as RichTextBox;
            windChart = form.Controls.Find("wind_chart", false)[0] as Chart;
        }

        public void LogWind(int wind)
        {
            int deltaWind = 0;

            if (lastWind == null)
            {
                deltaWind = wind;
            }
            else
            {
                deltaWind = wind - (int)lastWind;
            }

            lastWind = wind;

            string dws = "";

            if (deltaWind > 0)
                if(enemyDir == 1)
                    dws = "\t(∆ = " + deltaWind + " ►, ∆ѳ = ◄ " + (deltaWind / 10) + "°)";
                else
                    dws = "\t(∆ = ◄ " + (-1 * deltaWind) + ", ∆ѳ = " + (deltaWind / 10) + "° ►)";

            else if (deltaWind < 0)
                if(enemyDir == 1)
                    dws = "\t(∆ = ◄ " + (-1 * deltaWind) + ", ∆ѳ = " + Math.Abs(deltaWind / 10) + "° ►)";
                else
                    dws = "\t(∆ = ◄ " + (-1 * deltaWind) + ", ∆ѳ = ◄ " + Math.Abs(deltaWind / 10) + "°)";
            else
                dws = "\t(∆ = " + deltaWind + ", ∆ѳ = 0°)";

            /*if (deltaWind > 0)
                dws = "\t(∆ = " + deltaWind + " ►)";
            else if (deltaWind < 0)
                dws = "\t(∆ = ◄ " + (-1 * deltaWind) + ")";
            else
                dws = "\t(∆ = " + deltaWind + ")";*/

           if (wind > 0)
                log.AppendText(wind + " ►" + dws + Environment.NewLine);
            else if(wind < 0)
                log.AppendText("◄ " + (-1 * wind) + dws + Environment.NewLine);
            else
                log.AppendText(wind + dws + Environment.NewLine);

            windChart.Series["wind_history"].Points.Add(new DataPoint(x, wind));
            x++;
        }

        public void SwitchEnemydir()
        {
            enemyDir *= -1;

            if(enemyDir == -1)
                log.AppendText("Expecting enemy to be on the left" + Environment.NewLine);
            else
                log.AppendText("Expecting enemy to be on the right" + Environment.NewLine);
        }

        public int GetEnemyDir()
        {
            return enemyDir;
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

                case "F9":
                    if (windChart.Visible)
                        windChart.Hide();
                    else
                        windChart.Show();
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
            windChart.Series["wind_history"].Points.Clear();
            x = 0;
        }
    }
}
