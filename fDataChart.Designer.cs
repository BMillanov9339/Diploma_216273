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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chHum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bExit = new System.Windows.Forms.Button();
            this.bDataCurrent = new System.Windows.Forms.Button();
            this.bDataLoad = new System.Windows.Forms.Button();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.lDataRoom = new System.Windows.Forms.Label();
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
            this.tabPage1.Text = "Temperature History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chTemp
            // 
            this.chTemp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.chTemp.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.LineColor = System.Drawing.Color.CadetBlue;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.Maximum = 60D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.PowderBlue;
            chartArea3.AxisY.LineColor = System.Drawing.Color.CadetBlue;
            chartArea3.AxisY.MajorGrid.Interval = 10D;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea3.AxisY.MajorGrid.LineWidth = 2;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightCyan;
            chartArea3.AxisY.Maximum = 120D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea3.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea3.BackSecondaryColor = System.Drawing.Color.CadetBlue;
            chartArea3.BorderColor = System.Drawing.Color.PowderBlue;
            chartArea3.Name = "ChartArea1";
            this.chTemp.ChartAreas.Add(chartArea3);
            this.chTemp.Location = new System.Drawing.Point(-4, 0);
            this.chTemp.Name = "chTemp";
            this.chTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Salmon;
            series3.Name = "seriesTemp";
            this.chTemp.Series.Add(series3);
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
            this.tabPage2.Text = "Humidity History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chHum
            // 
            this.chHum.BackColor = System.Drawing.Color.DarkSlateGray;
            this.chHum.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.Interval = 1D;
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.LineColor = System.Drawing.Color.CadetBlue;
            chartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorGrid.Interval = 1D;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.Maximum = 60D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.PowderBlue;
            chartArea4.AxisY.LineColor = System.Drawing.Color.CadetBlue;
            chartArea4.AxisY.MajorGrid.Interval = 10D;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.SteelBlue;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea4.AxisY.MajorGrid.LineWidth = 2;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightCyan;
            chartArea4.AxisY.Maximum = 100D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.CadetBlue;
            chartArea4.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea4.BackSecondaryColor = System.Drawing.Color.CadetBlue;
            chartArea4.BorderColor = System.Drawing.Color.PowderBlue;
            chartArea4.Name = "ChartArea2";
            this.chHum.ChartAreas.Add(chartArea4);
            this.chHum.Location = new System.Drawing.Point(-4, 0);
            this.chHum.Name = "chHum";
            this.chHum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series4.Name = "seriesHum";
            this.chHum.Series.Add(series4);
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
            // lDataRoom
            // 
            this.lDataRoom.AutoSize = true;
            this.lDataRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDataRoom.Location = new System.Drawing.Point(112, 600);
            this.lDataRoom.Name = "lDataRoom";
            this.lDataRoom.Size = new System.Drawing.Size(148, 37);
            this.lDataRoom.TabIndex = 13;
            this.lDataRoom.Text = "ROOM 3";
            // 
            // fDataChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(994, 678);
            this.Controls.Add(this.lDataRoom);
            this.Controls.Add(this.dtpSelectDate);
            this.Controls.Add(this.bDataLoad);
            this.Controls.Add(this.bDataCurrent);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tabData);
            this.Name = "fDataChart";
            this.Text = "Data";
            this.tabData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chTemp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chHum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lDataRoom;
    }
}