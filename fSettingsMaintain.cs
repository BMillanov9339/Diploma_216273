using diploma_216273.Services;
using System;
using System.Windows.Forms;
using diploma_216273.Settings;


//Настройки за режим поддържане

namespace diploma_216273
{
    public partial class fSettingsMaintain : Form
    {
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
            settings.targetTemperature = float.Parse(tTempMaintain.Text);
            settings.targetHumidity = float.Parse(tHumMaintain.Text);
            SettingsStore.Save(); 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancelMaintain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
