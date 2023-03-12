using Specifications.Data.SaveLoad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specifications
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
            Location = new Point(Screen.PrimaryScreen.WorkingArea.X / 2 - (this.Size.Width / 2),
                Screen.PrimaryScreen.WorkingArea.Y / 2 - (this.Size.Height / 2));

            techname_txt.Text = SettingsForm.settingData.TechnicianName;
        }

        private void openfile_btn_Click(object sender, EventArgs e)
        {
            openprojectfolder_dialog.ShowDialog();
            folderdirectory_lbl.Text = openprojectfolder_dialog.SelectedPath;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
