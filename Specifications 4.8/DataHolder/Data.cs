using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.DataHolder
{
    public struct Data
    {
        //public string displayName;
        public string attribute;
        public int id;
        public string name;
        public string prefix;
        public string exclusionString;        
        public List<Data> exclusions;

        public string defaultItemsString;
        public List<Data> defaultItems; 
        public Color textColour;

        public Data(string attribute, int id, string name, string prefix, string exclusionString, List<Data> exclusions, 
            string defaultItemsString, List<Data> defaultItems, string textColour="black")
        {
            this.attribute = attribute;
            this.id = id;

            this.name = name;
            this.prefix = prefix;

            this.exclusionString = exclusionString;
            this.exclusions = exclusions;

            this.defaultItemsString = defaultItemsString;
            this.defaultItems = defaultItems;

            if (prefix != "")
                this.name = string.Format("{0} - ({1})",name,prefix);

            if (textColour == "")
                textColour = "black";
            this.textColour = Color.FromName(textColour);
        }
    }
}
