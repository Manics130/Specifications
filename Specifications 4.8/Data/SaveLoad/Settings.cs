using Specifications.DataHolder;
using Specifications.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Specifications.Data.SaveLoad
{
    public static class Settings
    {
        public static SettingsData settingData;

        public static void TryLoadSettings()
        {
            //Set default data
            settingData = new SettingsData("New User");


            if (File.Exists(FileReferences.AppData + FileReferences.Data + "SettingsForm.dat"))
            {
                LoadSettings();
            }
            else
            {
                SaveSettings(settingData);
            }
        }
        private static void LoadSettings()
        {
            var doc = XDocument.Load(FileReferences.AppData + FileReferences.Data + "SettingsForm.dat");

            var decendants = doc.Descendants();
            var s = nameof(settingData.TechnicianName); 
            var tech = decendants.Select(i => i.Element(nameof(settingData.TechnicianName)));
            foreach(var t in tech)
            {
                if(t != null)
                {
                    settingData.TechnicianName = t.Value;
                }
            }
        }
        public static void SaveSettings(SettingsData settings)
        {
            settings.TechnicianName = settings.TechnicianName != string.Empty && settings.TechnicianName != null ? settings.TechnicianName : "New User";



            XmlSerializer writer = new XmlSerializer(typeof(SettingsData));
            FileStream file = File.Create(FileReferences.AppData + FileReferences.Data + "SettingsForm.dat");

            writer.Serialize(file, settings);
            file.Close();
        }
    }
}
