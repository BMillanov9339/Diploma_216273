using diploma_216273.Services;
using System;
using System.Windows.Forms;
using diploma_216273.Settings;


//Настройки за режим поддържане

namespace diploma_216273
{
    public partial class fSettingsMaintain : Form
    {
        float maxTemp = 80;
        float minTemp = -20;

        float maxHum = 100;
        float minHum = 0;

        private MaintainSettings settings;
        public fSettingsMaintain(MaintainSettings settings)
        {
            InitializeComponent();

            this.settings = settings; 

            tTempMaintain.Text = settings.targetTemperature.ToString();
            tHumMaintain.Text = settings.targetHumidity.ToString();
        }

        private void bSaveMaintain_Click(object sender, EventArgs e)
        {
            float tempInput = 0;
            float humInput = 0;
            bool validTemp = false;
            bool validHum = false;



            try
            {
                tempInput = float.Parse(tTempMaintain.Text);
                humInput = float.Parse(tHumMaintain.Text);
                validTemp = (tempInput >= minTemp && tempInput <= maxTemp);
                validHum = (humInput >= minHum && humInput <= maxHum);
            }
            catch
            {
                
            }

            if (validTemp && validHum)
            {
                settings.targetTemperature = tempInput;
                settings.targetHumidity = humInput;
                SettingsStore.Save();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else 
            {
                MessageBox.Show("Invalid Values");
                tTempMaintain.Text = settings.targetTemperature.ToString();
                tHumMaintain.Text = settings.targetHumidity.ToString();
            }
            
        }

        private void bCancelMaintain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
