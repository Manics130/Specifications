using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.DataHolder
{
    public struct SavedItemData
    {
        //public string displayName;
        public string attribute;
        public int id;
        public string name;
        public string prefix;
        public string exclusionString;        
        public List<SavedItemData> exclusions;

        public string defaultItemsString;
        public List<SavedItemData> defaultItems; 
        public Color textColour;

        public SavedItemData(string attribute, int id, string name, string prefix, string exclusionString, List<SavedItemData> exclusions, 
            string defaultItemsString, List<SavedItemData> defaultItems, string textColour="black")
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
