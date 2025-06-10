using diploma_216273.Services;
using System;
using System.Windows.Forms;
using diploma_216273.Settings;
using System.Reflection.Emit;

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

            sliderInit();
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

        void sliderInit()
        {
            sliderScroll("TIME ON", slTempOn.Value, labelHTimeOn);
            sliderScroll("TIME OFF", slTempOff.Value, labelHTimeOff);
            sliderScroll("TIME ON", slHumOn.Value, labelVTimeOn);
            sliderScroll("TIME OFF", slHumOff.Value, labelVTimeOff);
        }

        void sliderScroll(string str, int sliderValue, System.Windows.Forms.Label label)
        {
            label.Text = String.Format("{0}: {1}m", str, sliderValue);
        }

        private void slTempOn_Scroll(object sender, EventArgs e)
        {
            sliderScroll("TIME ON", slTempOn.Value, labelHTimeOn);
        }

        private void slTempOff_Scroll(object sender, EventArgs e)
        {
            sliderScroll("TIME OFF", slTempOff.Value, labelHTimeOff);
        }

        private void slHumOn_Scroll(object sender, EventArgs e)
        {
            sliderScroll("TIME ON", slHumOn.Value, labelVTimeOn);
        }

        private void slHumOff_Scroll(object sender, EventArgs e)
        {
            sliderScroll("TIME OFF", slHumOff.Value, labelVTimeOff);
        }
    }
}
