using diploma_216273.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

//Прозорец за графична визуализация на данни. Зарежда в реално време и от дата.

namespace diploma_216273
{
    public partial class fDataChart : Form
    {
        private readonly RoomManager manager;
        private readonly string roomName;
        private bool isLoadingFromFile = false;

        public fDataChart(RoomManager sharedManager, string roomName)
        {
            //нужна е връзка с управляващия клас, за да вземе името на стаята и настройките.
            //Иначе се увеличава броят на формите.
            InitializeComponent();
            this.manager = sharedManager;
            this.roomName = roomName;
            this.Load += fDataChart_Load;
        }

        private void fDataChart_Load(object sender, EventArgs e)
        {
            manager.OnRoomChartDataUpdate += UpdateRoomChartsTask;
            lDataRoom.Text = roomName;
        }

        private void UpdateRoomChartsTask(string room, double[] tempHistory, double[] humHistory)
        {
            if (room != roomName || isLoadingFromFile)
                return;

            Action updateAction = () =>
            {
                UpdateChartSeries(chTemp.Series["seriesTemp"], tempHistory);
                UpdateChartSeries(chHum.Series["seriesHum"], humHistory);
            };

            if (chTemp.InvokeRequired)
                chTemp.Invoke(updateAction);
            else
                updateAction();
        }

        private void UpdateChartSeries(Series series, double[] values)
        {
            series.Points.Clear();
            for (int i = 0; i < values.Length; i++)
                series.Points.AddXY(i, values[i]);
        }

        //Тъй като се рестартира всяка секунда, е достатъчно да се смъкне флагът
        private void bDataCurrent_Click(object sender, EventArgs e)
        {
            isLoadingFromFile = false;
        }

        private void bDataLoad_Click(object sender, EventArgs e)
        {
            isLoadingFromFile = true;

            DateTime selectedDate = dtpSelectDate.Value;
            string fileName = $"{selectedDate:yyyy-MM-dd}.csv";
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dataDirectory = Path.Combine(baseDirectory, "data");
            string filePath = Path.Combine(dataDirectory, fileName);

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"No data found for {selectedDate:yyyy-MM-dd}.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LoadDataFromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Логиката тук подлежи на промяна, ако сменя начина на парсиране.
        private void LoadDataFromFile(string filePath)
        {
            List<string> times = new List<string>();
            List<double> temps = new List<double>();
            List<double> hums = new List<double>();

            try
            {
                var lines = File.ReadAllLines(filePath);
                for (int i = 1; i < lines.Length; i++) 
                {
                    var parts = lines[i].Split(new[] { ":::" }, StringSplitOptions.None);
                    if (parts.Length != 4) continue;

                    string time = parts[0].Trim();
                    if (double.TryParse(parts[2], out double temp) &&
                        double.TryParse(parts[3], out double hum))
                    {
                        times.Add(time);
                        temps.Add(temp);
                        hums.Add(hum);
                    }
                }

                var tempSeries = chTemp.Series["seriesTemp"];
                tempSeries.Points.Clear();
                for (int i = 0; i < temps.Count; i++)
                    tempSeries.Points.AddXY(times[i], temps[i]);

                var humSeries = chHum.Series["seriesHum"];
                humSeries.Points.Clear();
                for (int i = 0; i < hums.Count; i++)
                    humSeries.Points.AddXY(times[i], hums[i]);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading CSV file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            manager.OnRoomChartDataUpdate -= UpdateRoomChartsTask;
            base.OnFormClosing(e);
        }
    }

}
