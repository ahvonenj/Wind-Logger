namespace Wind_Logger
{
    partial class ssl_windlogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ssl_windlogger));
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.txt_help = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.Color.White;
            this.txt_log.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(3, 3);
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(134, 197);
            this.txt_log.TabIndex = 2;
            this.txt_log.Text = "";
            this.txt_log.TextChanged += new System.EventHandler(this.txt_log_TextChanged);
            // 
            // txt_help
            // 
            this.txt_help.BackColor = System.Drawing.Color.White;
            this.txt_help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_help.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_help.Location = new System.Drawing.Point(6, 5);
            this.txt_help.Name = "txt_help";
            this.txt_help.ReadOnly = true;
            this.txt_help.Size = new System.Drawing.Size(131, 195);
            this.txt_help.TabIndex = 5;
            this.txt_help.Text = "F1 ◄30\nF2 ◄20\nF3 ◄10\nF4 0\nF5 10 ►\nF6 20 ►\nF7 30 ►\nF8 Clear\nF9 Chart\nF10 Show help" +
    "";
            this.txt_help.Visible = false;
            // 
            // ssl_windlogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(140, 201);
            this.Controls.Add(this.txt_help);
            this.Controls.Add(this.txt_log);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ssl_windlogger";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ShellShock Live Wind Logger 1.0";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.ssl_windlogger_Activated);
            this.Deactivate += new System.EventHandler(this.ssl_windlogger_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ssl_windlogger_FormClosed);
            this.Load += new System.EventHandler(this.ssl_windlogger_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssl_windlogger_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.RichTextBox txt_help;
    }
}

