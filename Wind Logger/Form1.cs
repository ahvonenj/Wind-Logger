using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Wind_Logger
{
    public partial class ssl_windlogger : Form
    {
        private WindLogger windlogger = null;

        /*[System.Runtime.InteropServices.DllImport("User32")]
        private static extern bool SetForegroundWindow(
            IntPtr hWnd
        );*/

        public ssl_windlogger()
        {
            InitializeComponent();
            windlogger = new WindLogger(this);
            wind_chart.Hide();
        }

        private void btn_l30_Click(object sender, EventArgs e)
        {
            windlogger.LogWind(-30);
        }

        private void btn_l20_Click(object sender, EventArgs e)
        {
            windlogger.LogWind(-20);
        }

        private void btn_l10_Click(object sender, EventArgs e)
        {
            windlogger.LogWind(-10);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            windlogger.LogWind(0);
        }

        private void btn_r10_Click(object sender, EventArgs e)
        {
            windlogger.LogWind(10);
        }

        private void btn_r20_Click(object sender, EventArgs e)
        {
            windlogger.LogWind(20);
        }

        private void btn_r30_Click(object sender, EventArgs e)
        {
            windlogger.LogWind(30);

            
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            int wind = 0;
            bool success = int.TryParse(txt_wind.Text, out wind);

            if(success)
            {
                windlogger.LogWind(wind);
            }
            else
            {
                windlogger.LogError("Invalid value for wind");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            windlogger.ClearLog();
        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            if (wind_chart.Visible)
                wind_chart.Hide();
            else
                wind_chart.Show();
        }

        private void txt_log_TextChanged(object sender, EventArgs e)
        {
            txt_log.SelectionStart = txt_log.Text.Length;
            txt_log.ScrollToCaret();
        }

        private void ssl_windlogger_Load(object sender, EventArgs e)
        {
            InterceptKeys.form = this;
            InterceptKeys.log = txt_log;
            InterceptKeys.logger = windlogger;
            InterceptKeys._hookID = InterceptKeys.SetHook(InterceptKeys._proc);
    }

        private void ssl_windlogger_FormClosed(object sender, FormClosedEventArgs e)
        {
            InterceptKeys.UnhookWindowsHookEx(InterceptKeys._hookID);
        }

        private void ssl_windlogger_Activated(object sender, EventArgs e)
        {

        }

        private void ssl_windlogger_Deactivate(object sender, EventArgs e)
        {

        }

        private void ssl_windlogger_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            windlogger.SwitchEnemydir();

            if (windlogger.GetEnemyDir() == 1)
                btn_dir.Text = "Enemy dir [►]";
            else
                btn_dir.Text = "Enemy dir [◄]";
        }
    }
}
