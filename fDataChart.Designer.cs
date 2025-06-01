namespace diploma_216273
{
    partial class fDataChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chHum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bExit = new System.Windows.Forms.Button();
            this.bDataCurrent = new System.Windows.Forms.Button();
            this.bDataLoad = new System.Windows.Forms.Button();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.tabData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTemp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chHum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tabPage1);
            this.tabData.Controls.Add(this.tabPage2);
            this.tabData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabData.Location = new System.Drawing.Point(12, 12);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(970, 549);
            this.tabData.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chTemp);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "seriesTemp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chTemp
            // 
            this.chTemp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.chTemp.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisX.LineColor = System.Drawing.Color.CadetBlue;
            chartArea5.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.MajorGrid.Interval = 1D;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX.Maximum = 60D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.PowderBlue;
            chartArea5.AxisY.LineColor = System.Drawing.Color.CadetBlue;
            chartArea5.AxisY.MajorGrid.Interval = 10D;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea5.AxisY.MajorGrid.LineWidth = 2;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightCyan;
            chartArea5.AxisY.Maximum = 120D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.AxisY2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea5.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea5.BackSecondaryColor = System.Drawing.Color.CadetBlue;
            chartArea5.BorderColor = System.Drawing.Color.PowderBlue;
            chartArea5.Name = "ChartArea1";
            this.chTemp.ChartAreas.Add(chartArea5);
            this.chTemp.Location = new System.Drawing.Point(-4, 0);
            this.chTemp.Name = "chTemp";
            this.chTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Salmon;
            series5.Name = "seriesTemp";
            this.chTemp.Series.Add(series5);
            this.chTemp.Size = new System.Drawing.Size(970, 527);
            this.chTemp.TabIndex = 9;
            this.chTemp.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chHum);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "seriesHum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chHum
            // 
            this.chHum.BackColor = System.Drawing.Color.DarkSlateGray;
            this.chHum.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.Interval = 1D;
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisX.LineColor = System.Drawing.Color.CadetBlue;
            chartArea6.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisX.MajorGrid.Interval = 1D;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisX.Maximum = 60D;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.PowderBlue;
            chartArea6.AxisY.LineColor = System.Drawing.Color.CadetBlue;
            chartArea6.AxisY.MajorGrid.Interval = 10D;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea6.AxisY.MajorGrid.LineWidth = 2;
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightCyan;
            chartArea6.AxisY.Maximum = 100D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.AxisY2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea6.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea6.BackSecondaryColor = System.Drawing.Color.CadetBlue;
            chartArea6.BorderColor = System.Drawing.Color.PowderBlue;
            chartArea6.Name = "ChartArea2";
            this.chHum.ChartAreas.Add(chartArea6);
            this.chHum.Location = new System.Drawing.Point(-4, 0);
            this.chHum.Name = "chHum";
            this.chHum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea2";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series6.Name = "seriesHum";
            this.chHum.Series.Add(series6);
            this.chHum.Size = new System.Drawing.Size(970, 527);
            this.chHum.TabIndex = 10;
            this.chHum.Text = "chart1";
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(810, 600);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(172, 48);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bDataCurrent
            // 
            this.bDataCurrent.Location = new System.Drawing.Point(593, 600);
            this.bDataCurrent.Name = "bDataCurrent";
            this.bDataCurrent.Size = new System.Drawing.Size(172, 48);
            this.bDataCurrent.TabIndex = 2;
            this.bDataCurrent.Text = "Load Current";
            this.bDataCurrent.UseVisualStyleBackColor = true;
            this.bDataCurrent.Click += new System.EventHandler(this.bDataCurrent_Click);
            // 
            // bDataLoad
            // 
            this.bDataLoad.Location = new System.Drawing.Point(380, 600);
            this.bDataLoad.Name = "bDataLoad";
            this.bDataLoad.Size = new System.Drawing.Size(172, 48);
            this.bDataLoad.TabIndex = 3;
            this.bDataLoad.Text = "Load from Date";
            this.bDataLoad.UseVisualStyleBackColor = true;
            this.bDataLoad.Click += new System.EventHandler(this.bDataLoad_Click);
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpSelectDate.Location = new System.Drawing.Point(380, 574);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(172, 20);
            this.dtpSelectDate.TabIndex = 4;
            // 
            // fDataChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(994, 678);
            this.Controls.Add(this.dtpSelectDate);
            this.Controls.Add(this.bDataLoad);
            this.Controls.Add(this.bDataCurrent);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tabData);
            this.Name = "fDataChart";
            this.Text = "fDataChart";
            this.tabData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chTemp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chHum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTemp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHum;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bDataCurrent;
        private System.Windows.Forms.Button bDataLoad;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
    }
}