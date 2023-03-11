using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.DataHolder
{
    public struct SettingsData
    {
        public string TechnicianName;

        public SettingsData(string technicianName)
        {
            TechnicianName = technicianName;
        }
    }
}
