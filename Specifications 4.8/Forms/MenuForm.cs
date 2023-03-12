using Specifications.Data.SaveLoad;
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
    public partial class MenuForm : Form
    {
        NewProject newProject;
        SettingsForm settings;

        public MenuForm()
        {            
            InitializeComponent();

            newProject = new NewProject();
            settings = new SettingsForm();

            techname_lbl.Text = SettingsForm.settingData.TechnicianName;
        }

        private void CreateNewProject(object sender, EventArgs e)
        {
            newProject.ShowDialog();
        }

        private void OpenSettings(object sender, EventArgs e)
        {            
            settings.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
