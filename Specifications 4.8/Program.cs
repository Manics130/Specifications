using Specifications.Data;
using Specifications.Data.SaveLoad;
using Specifications.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specifications
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileReferences.CreateDirectories(); //Create Folders in appdata
            //Try loading SettingsForm            
            Settings.TryLoadSettings();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
