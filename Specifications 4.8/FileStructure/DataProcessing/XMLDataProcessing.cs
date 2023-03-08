using Specifications_4._8.Extentions;
using Specifications_4._8.FileStructure.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Specifications_4._8.FileStructure.DataProcessing
{
    public class XMLDataProcessing
    {
        private string PATH = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Data.XML";
        private XDocument _document;
        public List<XMLData> xmlData = new List<XMLData>();
        public XMLDataProcessing()
        {
            //TODO Read on Initialise
            //call reading data here
            ReadXML();
        }

        /// <summary>
        /// Reads from the XML Data Sheet
        /// </summary>
        private void ReadXML()
        {
            
            //TODO Write to dataset WriteDataSet();
            //Checks Xml file exists
            if(!File.Exists(PATH)) 
            { 
                //Checks to see if XML file exists if it doesnt warnings will show
                var result = MessageBox.Show(string.Format("Couldnt Find Data at {0}, Please make sure the XML file is stored in this location", PATH),"", MessageBoxButtons.RetryCancel); 
                if(result == DialogResult.Retry) {ReadXML();return;}
                else if(result == DialogResult.Cancel) Application.Exit();
                return;
            }

            List<XElement> data = new List<XElement>();
            data.AddRange(GetDescendants(Element.PLACEMENT));
            data.AddRange(_document.Descendants(Element.ITEMTYPE).ToList());
            data.AddRange(_document.Descendants(Element.VIEWTYPE).ToList());
            data.AddRange(_document.Descendants(Element.OPENINGSIDE).ToList());
            data.AddRange(_document.Descendants(Element.BEADINGSIDE).ToList());
            data.AddRange(_document.Descendants(Element.MASTERLEAFSIDE).ToList());
            data.AddRange(_document.Descendants(Element.FRAMERALCOLOUR).ToList());
            data.AddRange(_document.Descendants(Element.IRONFINISH).ToList());
            data.AddRange(_document.Descendants(Element.MONGERYTYPE).ToList());
            data.AddRange(_document.Descendants(Element.HINGETYPE).ToList());
            data.AddRange(_document.Descendants(Element.LOCKTYPE).ToList());
            data.AddRange(_document.Descendants(Element.BEADINGTYPE).ToList());
            data.AddRange(_document.Descendants(Element.GLASSTYPE).ToList());


        }
        private List<XElement> GetDescendants(string elementName)
        {
            char[] elementSplit = new char[] { ';' };
            char[] IdSplit = new char[] { '(', ',', ')' };
            var data = _document.Descendants(elementName).ToList();

            foreach(var element in data)
            {
                string id = element.Attribute(Attributes.ID).ToString();
                string name = element.Attribute(Attributes.NAME).ToString();
                string prefix = element.Attribute(Attributes.PREFIX).ToString();
                string exclusions = element.Attribute(Attributes.EXCLUSIONS).ToString();
                string defaults = element.Attribute(Attributes.DEFAULTITEMS).ToString();
                string textColour = element.Attribute(Attributes.TEXTCOLOUR).ToString();

                exclusions = exclusions.RemoveWhitespace();
                defaults = defaults.RemoveWhitespace();

                //Gets an array of attributes found in the exclusion list
                string[] exclusionAttributes =exclusions.Split(elementSplit,StringSplitOptions.RemoveEmptyEntries);
                foreach (var exclusionAttribute in exclusionAttributes)
                {
                    List<string> exclusionIds = exclusionAttribute.Split(IdSplit,StringSplitOptions.RemoveEmptyEntries).ToList();
                    exclusionIds.RemoveAt(0);
                    if(exclusionIds.Count > 0)
                    {

                    }
                }
                /*xmlData.Add(new XMLData
                    (
                    elementName,
                    id,
                    name,
                    prefix,

                    ));*/
            }

            return data;
        }

        /// <summary>
        /// Writes to the XML Data Sheet
        /// </summary>
        private void WriteXML()
        {
            //TODO Read from dataset ReadDataSet(); and save to XML
        }
    }
}
