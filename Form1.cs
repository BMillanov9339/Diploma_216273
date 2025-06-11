using diploma_216273.Managers;
using diploma_216273.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using test4;
using diploma_216273.Settings;
using System.Drawing;
using System.Linq;
using diploma_216273.Properties;

//Тук се зарежда интерфейсът на цялата програма. По възможност, единственото, което се контролира тук, е дизайн
//Всяка друга логика сочи към друг модул

namespace diploma_216273
{ 
    
    public partial class fDashboadMain : Form
    {
        private RoomManager manager;
        private fDataChart chart;
        private fLogin login;
        private fChangePassword changePassword;
        private Dictionary<string, RoomUI> roomUIs;

        bool suppressFlag = false;
        
        public fDashboadMain()
        {
            SettingsStore.Load();
            manager = new RoomManager();
            login = new fLogin();
            changePassword = new fChangePassword();

            InitializeComponent();

            roomUIs = new Dictionary<string, RoomUI>
            {
                ["Room 1"] = new RoomUI
                {
                    LabelTemp = labelTempR1,
                    LabelHum = labelHumR1,
                    LabelHeaterState = labelHeaterStateR1,
                    LabelVentState = labelVentStateR1,
                    Chart = chDataR1,
                    RBMaintain = rbMaintainR1,
                    RBTimed = rbTimedR1,
                },
                ["Room 2"] = new RoomUI
                {
                    LabelTemp = labelTempR2,
                    LabelHum = labelHumR2,
                    LabelHeaterState = labelHeaterStateR2,
                    LabelVentState = labelVentStateR2,
                    Chart = chDataR2,
                    RBMaintain = rbMaintainR2,
                    RBTimed = rbTimedR2,
                },
                ["Room 3"] = new RoomUI
                {
                    LabelTemp = labelTempR3,
                    LabelHum = labelHumR3,
                    LabelHeaterState = labelHeaterStateR3,
                    LabelVentState = labelVentStateR3,
                    Chart = chDataR3,
                    RBMaintain = rbMaintainR3,
                    RBTimed = rbTimedR3,
                },
                ["Room 4"] = new RoomUI
                {
                    LabelTemp = labelTempR4,
                    LabelHum = labelHumR4,
                    LabelHeaterState = labelHeaterStateR4,
                    LabelVentState = labelVentStateR4,
                    Chart = chDataR4,
                    RBMaintain = rbMaintainR4,
                    RBTimed = rbTimedR4,
                }
            };

            foreach (var room in SettingsStore.RoomSettingsDict.Keys)
            {
                var settings = SettingsStore.RoomSettingsDict[room];

                suppressFlag = true;

                if (settings.Mode == OperationMode.Timed)
                {
                    roomUIs[room].RBMaintain.Checked = false;
                    roomUIs[room].RBTimed.Checked = true;
                }

                else
                {
                    roomUIs[room].RBMaintain.Checked = true;
                    roomUIs[room].RBTimed.Checked = false;
                }
                    

                suppressFlag = false;
            }

            manager.OnRoomSensorUpdate += UpdateSingleRoomUI;
            manager.OnChartDataUpdate += UpdateChartForRoom;



        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        //Различните прозорци за настройки, в зависимост от режима.
        private bool OpenTimedSettings(string room)
        {
            if (!SettingsStore.RoomSettingsDict.TryGetValue(room, out var roomSettings))
            {
                MessageBox.Show($"Settings for '{room}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (var form = new fSettingsTimed(roomSettings.TimedSettings))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SettingsStore.RoomSettingsDict[room].Mode = OperationMode.Timed;
                    SettingsStore.Save(); 
                }
                return true;

            }
        }

        private bool OpenMaintainSettings(string room)
        {
            if (!SettingsStore.RoomSettingsDict.TryGetValue(room, out var roomSettings))
            {
                MessageBox.Show($"Settings for '{room}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (var form = new fSettingsMaintain(roomSettings.MaintainSettings))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SettingsStore.RoomSettingsDict[room].Mode = OperationMode.Maintain;
                    SettingsStore.Save(); 
                    
                }

                else 
                {
                    return false;
                }

                return true;
                
            }
        }

       

        //10-те елемента отговарят за графиките над помещенията.
        //Пълната хронология от 60 е за графиките, които се отварят в пълен прозорец
        private void UpdateChartSeries(Series series, double[] values, double addition)
        {
            series.Points.Clear();
            for (int i = 0; i < values.Length; i++)
                series.Points.AddXY(i, values[i] + addition);
        }

        private void UpdateChartForRoom(string room, double[] temps, double[] hums)
        {
            if (roomUIs == null || !roomUIs.ContainsKey(room))
                return;

            RoomUI ui = roomUIs[room];

            double[] temps10 = temps.Skip(Math.Max(0, temps.Length - 10)).ToArray();
            double[] hums10 = hums.Skip(Math.Max(0, hums.Length - 10)).ToArray();

            Action updateCharts = () =>
            {
                try 
                { 
                    var seriesTemp = ui.Chart.Series.FindByName("seriesTemp");
                    if (seriesTemp != null)
                        UpdateChartSeries(seriesTemp, temps10, 250);

                    var seriesHum = ui.Chart.Series.FindByName("seriesHum");
                    if (seriesHum != null)
                        UpdateChartSeries(seriesHum, hums10, 0);
                }

                catch { }
            };

            if (InvokeRequired)
                Invoke(updateCharts);
            else
                updateCharts();
        }

        private void setSettingUI(bool flag)
        {
            bLogout.Visible = flag;
            bChangePassword.Visible = flag;

            bSettingsR1.Visible = flag;
            bSettingsR2.Visible = flag;
            bSettingsR3.Visible = flag;
            bSettingsR4.Visible = flag;

            rbMaintainR1.Visible = flag;
            rbMaintainR2.Visible = flag;
            rbMaintainR3.Visible = flag;
            rbMaintainR4.Visible = flag;

            rbTimedR1.Visible = flag;
            rbTimedR2.Visible = flag;
            rbTimedR3.Visible = flag;
            rbTimedR4.Visible = flag;
        }
        private void checkAdminFlag()
        {
            bool adminFlagCheck = login.adminFlag;

            switch (adminFlagCheck)
            {
                case true:
                    labelLoginStatus.Text = "ADMIN";
                    break;

                case false:
                    labelLoginStatus.Text = "GUEST";
                    break;

                default:
                    break;
            }

            setSettingUI(adminFlagCheck);
        }
        //Контролира интерфейса за всяко помещение.
        private void UpdateSingleRoomUI(string room, double temp, double hum)
        {
            if (!roomUIs.ContainsKey(room))
                return;

            

            var ui = roomUIs[room];
            string tempString = string.Format("{0:F2}°C", temp);
            string humString = string.Format("{0:F2}%", hum);

            Action updateAction = () =>
            {
                checkAdminFlag();
                ui.LabelTemp.Text = tempString;
                ui.LabelHum.Text = humString;

                bool heaterOn = manager.HeatStatus.ContainsKey(room) && manager.HeatStatus[room];
                bool ventOn = manager.VentStatus.ContainsKey(room) && manager.VentStatus[room];

                ui.LabelHeaterState.Text = heaterOn ? "Heater: ON" : "Heater: OFF";
                ui.LabelHeaterState.ForeColor = heaterOn ? Color.Lime : Color.Red;

                ui.LabelVentState.Text = ventOn ? "Ventilation: ON" : "Ventilation: OFF";
                ui.LabelVentState.ForeColor = ventOn ? Color.Lime : Color.Red;

                
                var settings = SettingsStore.RoomSettingsDict[room];

                suppressFlag = true;

                if (settings.Mode == OperationMode.Timed)
                {
                    roomUIs[room].RBMaintain.Checked = false;
                    roomUIs[room].RBTimed.Checked = true;
                }

                else
                {
                    roomUIs[room].RBMaintain.Checked = true;
                    roomUIs[room].RBTimed.Checked = false;
                }

                suppressFlag = false;
                
            };

            if (InvokeRequired)
                Invoke(updateAction);
            else
                updateAction();
        }


        //Функции за бутоните
        private void buttonSettings_Click(string room, System.Windows.Forms.RadioButton button)
        {
            RoomSettings roomSettings = SettingsStore.RoomSettingsDict[room];

            if (!button.Checked)
            {
                fSettingsTimed form = new fSettingsTimed(roomSettings.TimedSettings);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SettingsStore.Save(); 
                }
            }
            else
            {
                fSettingsMaintain form = new fSettingsMaintain(roomSettings.MaintainSettings);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SettingsStore.Save(); 
                }
            }
        }

        private void bSettingsR1_Click(object sender, EventArgs e)
        {
            buttonSettings_Click("Room 1", rbMaintainR1);
        }

        private void bSettingsR2_Click(object sender, EventArgs e)
        {
            buttonSettings_Click("Room 2", rbMaintainR2);
        }

        private void bSettingsR3_Click(object sender, EventArgs e)
        {
            buttonSettings_Click("Room 3", rbMaintainR3);
        }

        private void bSettingsR4_Click(object sender, EventArgs e)
        {
            buttonSettings_Click("Room 4", rbMaintainR4);
        }


        //Визуализира графиките в пълен прозорец
        private void chDataR1_Click(object sender, EventArgs e)
        {
            chart = new fDataChart(this.manager, "Room 1");
            chart.Show();
        }

        private void chDataR2_Click(object sender, EventArgs e)
        {
            chart = new fDataChart(this.manager, "Room 2");
            chart.Show();

        }

        private void chDataR3_Click(object sender, EventArgs e)
        {
            chart = new fDataChart(this.manager, "Room 3");
            chart.Show();
        }

        private void chDataR4_Click(object sender, EventArgs e)
        {
            chart = new fDataChart(this.manager, "Room 4");
            chart.Show();
        }


        //Кликане на радио бутона отваря меню за настройки

        private void radioButtonSwitch(System.Windows.Forms.RadioButton button,string room)
        {
            bool settingsChanged = false;
            var roomSettings = SettingsStore.RoomSettingsDict[room];

            if (!suppressFlag)
            {
                if (roomSettings.Mode == OperationMode.Maintain)
                {
                    settingsChanged = OpenTimedSettings(room);
                }

                else
                {
                    settingsChanged = OpenMaintainSettings(room);
                }
            }

        }
        private void rbMaintainR1_CheckedChanged(object sender, EventArgs e)
        {
            string selectedRoom = "Room 1";

            radioButtonSwitch(rbMaintainR1, selectedRoom);
        }

        private void rbMaintainR2_CheckedChanged(object sender, EventArgs e)
        {
            string selectedRoom = "Room 2";

            radioButtonSwitch(rbMaintainR2, selectedRoom);

        }

        private void rbMaintainR3_CheckedChanged(object sender, EventArgs e)
        {
            string selectedRoom = "Room 3";

            radioButtonSwitch(rbMaintainR3, selectedRoom);

        }

        private void rbMaintainR4_CheckedChanged(object sender, EventArgs e)
        {
            string selectedRoom = "Room 4";

            radioButtonSwitch(rbMaintainR4, selectedRoom);
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            //fSettingsTimed form = new fSettingsTimed(roomSettings.TimedSettings);
            login = new fLogin();
            login.ShowDialog();
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            login.adminFlag = false;
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            changePassword = new fChangePassword();
            changePassword.ShowDialog();
        }
    }
}
