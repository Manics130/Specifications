using Specifications.Data.SaveLoad;
using Specifications.DataHolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specifications.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            technicianName_txt.Text = SettingsForm.settingData.TechnicianName;
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            SettingsData setting = new SettingsData(technicianName_txt.Text);

            SettingsForm.SaveSettings(setting);

            this.Close();
        }

        private void CloseSettings(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
