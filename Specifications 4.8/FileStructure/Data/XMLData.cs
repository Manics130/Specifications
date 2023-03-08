using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications_4._8.FileStructure.Data
{
    public struct XMLData
    {
        //public string displayName;
        public string attribute;
        public string id;
        public string name;
        public string prefix;
        public List<(string,string)> exclusionList;
        public List<(string, string)> defaultList;
        public Color textColour;

        public XMLData(string attribute, string id, string name, string prefix, List<(string, string)> exclusionList, List<(string, string)> defaultList, string textColour = "black")
        {
            this.attribute = attribute;
            this.id = id;

            this.name = name;
            this.prefix = prefix;

            this.exclusionList = exclusionList;
            this.defaultList = defaultList;

            if (prefix != "")
                this.name = string.Format("{0} - ({1})", name, prefix);

            if (textColour == "")
                textColour = "black";
            this.textColour = Color.FromName(textColour);
        }
    }
}
