using diploma_216273.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diploma_216273.Settings;

namespace test4
{
    public partial class fSettingsTimed : Form
    {
        private TimedSettings settings;

        public fSettingsTimed(TimedSettings settings)
        {
            InitializeComponent();

            this.settings = settings; // <-- This line was missing

            slTempOn.Value = settings.tempTimeOn;
            slTempOff.Value = settings.tempTimeOff;

            slHumOn.Value = settings.humTimeOn;
            slHumOff.Value = settings.humTimeOff;
        }

        private void bSaveTimed_Click(object sender, EventArgs e)
        {
            //RoomSettingsDict["Room 1"].Mode = OperationMode.Timed;
            settings.tempTimeOn = slTempOn.Value;
            settings.tempTimeOff = slTempOff.Value;

            settings.humTimeOn = slHumOn.Value;
            settings.humTimeOff = slHumOff.Value;

            SettingsStore.Save(); // <-- Save to JSON

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancelTimed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
