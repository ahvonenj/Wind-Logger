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

        [System.Runtime.InteropServices.DllImport("User32")]
        private static extern bool SetForegroundWindow(
            IntPtr hWnd
        );

        public ssl_windlogger()
        {
            InitializeComponent();
            windlogger = new WindLogger(this);
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

            SetForegroundWindow(Handle);

            TopMost = true;
            TopLevel = true;
        }

        private void ssl_windlogger_FormClosed(object sender, FormClosedEventArgs e)
        {
            InterceptKeys.UnhookWindowsHookEx(InterceptKeys._hookID);
        }

        private void ssl_windlogger_Activated(object sender, EventArgs e)
        {
            TopMost = true;
            TopLevel = true;

        }

        private void ssl_windlogger_Deactivate(object sender, EventArgs e)
        {
            TopMost = true;
            TopLevel = true;
        }

        private void ssl_windlogger_KeyPress(object sender, KeyPressEventArgs e)
        {
            TopMost = true;
            TopLevel = true;
        }

        private void ssl_windlogger_Enter(object sender, EventArgs e)
        {
            TopMost = true;
            TopLevel = true;
        }

        private void ssl_windlogger_Leave(object sender, EventArgs e)
        {
            TopMost = true;
            TopLevel = true;
        }
    }
}
