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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ssl_windlogger));
            this.btn_l30 = new System.Windows.Forms.Button();
            this.btn_l20 = new System.Windows.Forms.Button();
            this.btn_l10 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_r10 = new System.Windows.Forms.Button();
            this.btn_r20 = new System.Windows.Forms.Button();
            this.btn_r30 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_log = new System.Windows.Forms.Button();
            this.txt_wind = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.wind_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_graph = new System.Windows.Forms.Button();
            this.txt_help = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wind_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_l30
            // 
            this.btn_l30.Location = new System.Drawing.Point(3, 3);
            this.btn_l30.Name = "btn_l30";
            this.btn_l30.Size = new System.Drawing.Size(41, 32);
            this.btn_l30.TabIndex = 0;
            this.btn_l30.Text = "◄ 30";
            this.btn_l30.UseVisualStyleBackColor = true;
            this.btn_l30.Click += new System.EventHandler(this.btn_l30_Click);
            // 
            // btn_l20
            // 
            this.btn_l20.Location = new System.Drawing.Point(50, 3);
            this.btn_l20.Name = "btn_l20";
            this.btn_l20.Size = new System.Drawing.Size(41, 32);
            this.btn_l20.TabIndex = 0;
            this.btn_l20.Text = "◄ 20";
            this.btn_l20.UseVisualStyleBackColor = true;
            this.btn_l20.Click += new System.EventHandler(this.btn_l20_Click);
            // 
            // btn_l10
            // 
            this.btn_l10.Location = new System.Drawing.Point(97, 3);
            this.btn_l10.Name = "btn_l10";
            this.btn_l10.Size = new System.Drawing.Size(41, 32);
            this.btn_l10.TabIndex = 0;
            this.btn_l10.Text = "◄ 10";
            this.btn_l10.UseVisualStyleBackColor = true;
            this.btn_l10.Click += new System.EventHandler(this.btn_l10_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(144, 3);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(41, 32);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_r10
            // 
            this.btn_r10.Location = new System.Drawing.Point(191, 3);
            this.btn_r10.Name = "btn_r10";
            this.btn_r10.Size = new System.Drawing.Size(41, 32);
            this.btn_r10.TabIndex = 0;
            this.btn_r10.Text = "10 ►";
            this.btn_r10.UseVisualStyleBackColor = true;
            this.btn_r10.Click += new System.EventHandler(this.btn_r10_Click);
            // 
            // btn_r20
            // 
            this.btn_r20.Location = new System.Drawing.Point(238, 3);
            this.btn_r20.Name = "btn_r20";
            this.btn_r20.Size = new System.Drawing.Size(41, 32);
            this.btn_r20.TabIndex = 0;
            this.btn_r20.Text = "20 ►";
            this.btn_r20.UseVisualStyleBackColor = true;
            this.btn_r20.Click += new System.EventHandler(this.btn_r20_Click);
            // 
            // btn_r30
            // 
            this.btn_r30.Location = new System.Drawing.Point(285, 3);
            this.btn_r30.Name = "btn_r30";
            this.btn_r30.Size = new System.Drawing.Size(41, 32);
            this.btn_r30.TabIndex = 0;
            this.btn_r30.Text = "30 ►";
            this.btn_r30.UseVisualStyleBackColor = true;
            this.btn_r30.Click += new System.EventHandler(this.btn_r30_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_l30);
            this.panel1.Controls.Add(this.btn_r30);
            this.panel1.Controls.Add(this.btn_l20);
            this.panel1.Controls.Add(this.btn_r20);
            this.panel1.Controls.Add(this.btn_l10);
            this.panel1.Controls.Add(this.btn_r10);
            this.panel1.Controls.Add(this.btn_0);
            this.panel1.Location = new System.Drawing.Point(3, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 39);
            this.panel1.TabIndex = 1;
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.Color.White;
            this.txt_log.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(3, 3);
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(329, 258);
            this.txt_log.TabIndex = 2;
            this.txt_log.Text = "";
            this.txt_log.TextChanged += new System.EventHandler(this.txt_log_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_wind);
            this.panel2.Controls.Add(this.btn_graph);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_log);
            this.panel2.Location = new System.Drawing.Point(3, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 35);
            this.panel2.TabIndex = 3;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(97, 3);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 28);
            this.btn_log.TabIndex = 0;
            this.btn_log.Text = "Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // txt_wind
            // 
            this.txt_wind.Location = new System.Drawing.Point(3, 6);
            this.txt_wind.Name = "txt_wind";
            this.txt_wind.Size = new System.Drawing.Size(88, 20);
            this.txt_wind.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(178, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 28);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // wind_chart
            // 
            this.wind_chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.wind_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.wind_chart.Legends.Add(legend1);
            this.wind_chart.Location = new System.Drawing.Point(335, 3);
            this.wind_chart.Name = "wind_chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Wind History";
            series1.Name = "wind_history";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.wind_chart.Series.Add(series1);
            this.wind_chart.Size = new System.Drawing.Size(490, 340);
            this.wind_chart.TabIndex = 4;
            this.wind_chart.Text = "Wind Chart";
            // 
            // btn_graph
            // 
            this.btn_graph.Location = new System.Drawing.Point(259, 3);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(67, 28);
            this.btn_graph.TabIndex = 0;
            this.btn_graph.Text = "Graph";
            this.btn_graph.UseVisualStyleBackColor = true;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // txt_help
            // 
            this.txt_help.BackColor = System.Drawing.Color.White;
            this.txt_help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_help.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_help.Location = new System.Drawing.Point(6, 5);
            this.txt_help.Name = "txt_help";
            this.txt_help.ReadOnly = true;
            this.txt_help.Size = new System.Drawing.Size(323, 256);
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
            this.ClientSize = new System.Drawing.Size(828, 345);
            this.Controls.Add(this.txt_help);
            this.Controls.Add(this.wind_chart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wind_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_l30;
        private System.Windows.Forms.Button btn_l20;
        private System.Windows.Forms.Button btn_l10;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_r10;
        private System.Windows.Forms.Button btn_r20;
        private System.Windows.Forms.Button btn_r30;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_wind;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.DataVisualization.Charting.Chart wind_chart;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.RichTextBox txt_help;
    }
}

