using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.Data
{
    public static class FileReferences
    {
        /// <summary>
        /// Appdata reference
        /// </summary>
        public static string AppData = string.Format(@"{0}\Specifications\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        /// <summary>
        /// AppData\SavedItemData
        /// </summary>
        public static string Data = @"Data\";
        /// <summary>
        /// AppData\Backup
        /// </summary>
        public static string Backups = @"Backup\";

        public static void CreateDirectories()
        {
            _ = Directory.CreateDirectory(AppData + Data);
            _ = Directory.CreateDirectory(AppData + Backups);
        }
    }
}
