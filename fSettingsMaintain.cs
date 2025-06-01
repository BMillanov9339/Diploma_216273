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

namespace diploma_216273
{
    public partial class fSettingsMaintain : Form
    {
        private MaintainSettings settings;
        public fSettingsMaintain(MaintainSettings settings)
        {
            InitializeComponent();

            this.settings = settings; // <-- This line was missing

            tTempMaintain.Text = settings.targetTemperature.ToString();
            tHumMaintain.Text = settings.targetHumidity.ToString();
        }

        private void bSaveMaintain_Click(object sender, EventArgs e)
        {
            settings.targetTemperature = float.Parse(tTempMaintain.Text);
            settings.targetHumidity = float.Parse(tHumMaintain.Text);
            SettingsStore.Save(); // <-- Save to JSON

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancelMaintain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
