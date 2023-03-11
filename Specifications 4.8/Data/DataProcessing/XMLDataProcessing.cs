using Specifications.Extentions;
using Specifications.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Specifications.DataProcessing
{
    public class XMLDataProcessing
    {
        private string PATH = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\SavedItemData.XML";
        private XDocument _document;
        public List<XMLData> xmlData = new List<XMLData>();
        public XMLDataProcessing()
        {
            //TODO Read on Initialise
            //call reading data here
            ReadXML();
        }

        /// <summary>
        /// Reads from the XML SavedItemData Sheet
        /// </summary>
        private void ReadXML()
        {
            
            //TODO Write to dataset WriteDataSet();
            //Checks Xml file exists
            if(!File.Exists(PATH)) 
            { 
                //Checks to see if XML file exists if it doesnt warnings will show
                var result = MessageBox.Show(string.Format("Couldnt Find SavedItemData at {0}, Please make sure the XML file is stored in this location", PATH),"", MessageBoxButtons.RetryCancel); 
                if(result == DialogResult.Retry) {ReadXML();return;}
                else if(result == DialogResult.Cancel) Application.Exit();
                return;
            }
            _document = XDocument.Load(PATH);

            List<XElement> data = new List<XElement>();
            data.AddRange(GetDescendants(Element.PLACEMENT));
            data.AddRange(GetDescendants(Element.ITEMTYPE).ToList());
            data.AddRange(GetDescendants(Element.VIEWTYPE).ToList());
            data.AddRange(GetDescendants(Element.OPENINGSIDE).ToList());
            data.AddRange(GetDescendants(Element.BEADINGSIDE).ToList());
            data.AddRange(GetDescendants(Element.MASTERLEAFSIDE).ToList());
            data.AddRange(GetDescendants(Element.FRAMERALCOLOUR).ToList());
            data.AddRange(GetDescendants(Element.IRONFINISH).ToList());
            data.AddRange(GetDescendants(Element.MONGERYTYPE).ToList());
            data.AddRange(GetDescendants(Element.HINGETYPE).ToList());
            data.AddRange(GetDescendants(Element.LOCKTYPE).ToList());
            data.AddRange(GetDescendants(Element.BEADINGTYPE).ToList());
            data.AddRange(GetDescendants(Element.GLASSTYPE).ToList());


        }
        private List<XElement> GetDescendants(string elementName)
        {
            char[] elementSplit = new char[] { ';' };
            char[] IdSplit = new char[] { '(', ',', ')' };
            var data =  _document.Descendants(elementName).ToList();

            foreach(var element in data)
            {
                string id = element.Attribute(Attributes.ID) != null ? element.Attribute(Attributes.ID).Value.ToString() : "";
                string name = element.Attribute(Attributes.NAME) != null ? element.Attribute(Attributes.NAME).Value.ToString() : "";
                string prefix = element.Attribute(Attributes.PREFIX) != null ? element.Attribute(Attributes.PREFIX).Value.ToString() : "";
                string exclusions = element.Attribute(Attributes.EXCLUSIONS) != null ? element.Attribute(Attributes.EXCLUSIONS).Value.ToString() : "";
                string defaults = element.Attribute(Attributes.DEFAULTITEMS) != null ? element.Attribute(Attributes.DEFAULTITEMS).Value.ToString() : "";
                string textColour = element.Attribute(Attributes.TEXTCOLOUR) != null ? element.Attribute(Attributes.TEXTCOLOUR).Value.ToString() : "";

                exclusions = exclusions.RemoveWhitespace();
                defaults = defaults.RemoveWhitespace();

                //Gets an array of attributes found in the exclusion list
                var item = new XMLData(elementName, id, name, prefix, new List<(string, string)>(), new List<(string, string)>(), textColour);
                
                string[] exclusionAttributes =exclusions.Split(elementSplit,StringSplitOptions.RemoveEmptyEntries);
                foreach (var exclusionAttribute in exclusionAttributes)
                {
                    string attribute = "";
                    List<string> exclusionIds = exclusionAttribute.Split(IdSplit,StringSplitOptions.RemoveEmptyEntries).ToList();
                    attribute = exclusionIds[0];
                    exclusionIds.RemoveAt(0);
                    
                    foreach(var exclusionId in exclusionIds)
                    {
                        item.exclusionList.Add((attribute, exclusionId));
                    }
                }
                            

                xmlData.Add(item);
            }

            return data;
        }

        /// <summary>
        /// Writes to the XML SavedItemData Sheet
        /// </summary>
        private void WriteXML()
        {
            //TODO Read from dataset ReadDataSet(); and save to XML
        }
    }
}
