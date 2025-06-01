using diploma_216273.Services;
using System;
using System.Windows.Forms;
using diploma_216273.Settings;

//Настройки режим Времево.
//Namespace-a не иска да си смени името. Останалите успяха.
//Това е един от най-старите прозорци в приложението, така че след време се отказах
namespace test4
{
    public partial class fSettingsTimed : Form
    {
        private TimedSettings settings;

        public fSettingsTimed(TimedSettings settings)
        {
            InitializeComponent();

            this.settings = settings;

            slTempOn.Value = settings.tempTimeOn;
            slTempOff.Value = settings.tempTimeOff;

            slHumOn.Value = settings.humTimeOn;
            slHumOff.Value = settings.humTimeOff;
        }

        private void bSaveTimed_Click(object sender, EventArgs e)
        {
            settings.tempTimeOn = slTempOn.Value;
            settings.tempTimeOff = slTempOff.Value;

            settings.humTimeOn = slHumOn.Value;
            settings.humTimeOff = slHumOff.Value;

            SettingsStore.Save(); 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancelTimed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
