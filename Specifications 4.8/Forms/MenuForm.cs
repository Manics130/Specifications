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
        }

        private void CreateNewProject(object sender, EventArgs e)
        {
            newProject.Show();
        }

        private void OpenSettings(object sender, EventArgs e)
        {            
            settings.Show();
        }

        
    }
}
