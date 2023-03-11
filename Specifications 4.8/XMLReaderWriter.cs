using Specifications.DataHolder;
using Specifications.Extentions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Specifications
{
    internal static class XMLReaderWriter
    {
        //Const Element Identifiers
        public const string PLACEMENT_ELEMENT        = "Placement";
        public const string ITEMTYPE_ELEMENT         = "ItemType";
        public const string VIEWTYPE_ELEMENT         = "ViewType";
        public const string OPENINGSIDE_ELEMENT      = "OpeningSide";
        public const string BEADINGSIDE_ELEMENT      = "BeadingSide";
        public const string MASTERLEAFSIDE_ELEMENT   = "MasterLeaf";
        public const string FRAMERALCOLOUR_ELEMENT   = "RalColour";
        public const string IRONFINISH_ELEMENT       = "IronFinish";
        public const string MONGERYTYPE_ELEMENT      = "MongeryType";
        public const string HINGETYPE_ELEMENT        = "HingeType";
        public const string LOCKTYPE_ELEMENT         = "LockType";
        public const string BEADINGTYPE_ELEMENT      = "BeadingType";
        public const string GLASSTYPE_ELEMENT        = "GlassType";

        //Const Attribute Identifiers
        public const string ID_ATTRIBUTE             = "id";
        public const string NAME_ATTRIBUTE           = "name";
        public const string PREFIX_ATTRIBUTE         = "prefix";
        public const string EXCLUSIONS_ATTRIBUTE      = "exclusions";
        public const string DEFAULTITEMS_ATTRIBUTE   = "defaults";
        public const string TEXTCOLOUR_ATTRIBUTE     = "textcolour";


        public static DataSet DataBase = new DataSet();
        public static DataTable dataTable;

        //SavedItemData holder
        public static List<SavedItemData> XMLData = new List<SavedItemData>();

        private const string ItemType = "ItemType";

        //TODO create Dataset for eachtype?

        internal static void Read()
        {
            string path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            path += "\\SavedItemData.XML";

             dataTable = new DataTable("XML SavedItemData");
            //setup data colums
            dataTable.Columns.Add("Attribute");
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Prefix");
            dataTable.Columns.Add("Exclusions");
            dataTable.Columns.Add("Default Items");
            dataTable.Columns.Add("Text Colours");


            if (File.Exists(path))
            {
                //Loading XML Document
                XDocument xdoc = XDocument.Load(path);

                //Finding Inital SavedItemData
                var PlacementData       = xdoc.Descendants(PLACEMENT_ELEMENT).ToList();
                var ItemTypesData       = xdoc.Descendants(ITEMTYPE_ELEMENT).ToList();
                var ViewTypesData       = xdoc.Descendants(VIEWTYPE_ELEMENT).ToList();
                var OpeningSidesData    = xdoc.Descendants(OPENINGSIDE_ELEMENT).ToList();
                var BeadingSidesData    = xdoc.Descendants(BEADINGSIDE_ELEMENT).ToList();
                var MasterLeafSidesData = xdoc.Descendants(MASTERLEAFSIDE_ELEMENT).ToList();
                var RalColoursData      = xdoc.Descendants(FRAMERALCOLOUR_ELEMENT).ToList();
                var IronFinishesData    = xdoc.Descendants(IRONFINISH_ELEMENT).ToList();
                var MongeryTypesData    = xdoc.Descendants(MONGERYTYPE_ELEMENT).ToList();
                var HingeTypesData      = xdoc.Descendants(HINGETYPE_ELEMENT).ToList();
                var LockTypesData       = xdoc.Descendants(LOCKTYPE_ELEMENT).ToList();
                var BeadingTypesData    = xdoc.Descendants(BEADINGTYPE_ELEMENT).ToList();
                var GlassTypesData      = xdoc.Descendants(GLASSTYPE_ELEMENT).ToList();

                //Find and assign SavedItemData
                XMLData.AddRange(CalculateData(PLACEMENT_ELEMENT, PlacementData));
                XMLData.AddRange(CalculateData(ITEMTYPE_ELEMENT, ItemTypesData));
                XMLData.AddRange(CalculateData(VIEWTYPE_ELEMENT, ViewTypesData));
                XMLData.AddRange(CalculateData(OPENINGSIDE_ELEMENT, OpeningSidesData));
                XMLData.AddRange(CalculateData(BEADINGSIDE_ELEMENT, BeadingSidesData));
                XMLData.AddRange(CalculateData(MASTERLEAFSIDE_ELEMENT, MasterLeafSidesData));
                XMLData.AddRange(CalculateData(FRAMERALCOLOUR_ELEMENT, RalColoursData));
                XMLData.AddRange(CalculateData(IRONFINISH_ELEMENT, IronFinishesData));
                XMLData.AddRange(CalculateData(MONGERYTYPE_ELEMENT, MongeryTypesData));
                XMLData.AddRange(CalculateData(HINGETYPE_ELEMENT, HingeTypesData));
                XMLData.AddRange(CalculateData(LOCKTYPE_ELEMENT, LockTypesData));
                XMLData.AddRange(CalculateData(BEADINGTYPE_ELEMENT, BeadingTypesData));
                XMLData.AddRange(CalculateData(GLASSTYPE_ELEMENT, GlassTypesData));

                //Find and assign exclusions
                CalculateExclusions();
                CalculateDefaults();

                DataBase.Tables.Add(dataTable);
            }
        }
        private static List<SavedItemData> CalculateData(string attribute, List<XElement> elements)
        {            
            List<SavedItemData> data = new List<SavedItemData>();

            for (int i = 0; i < elements.Count; i++)
            {
                XElement element = elements[i];
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string idString = element.Attribute(ID_ATTRIBUTE) != null ?
                    element.Attribute(ID_ATTRIBUTE).Value.ToString() : "";

                string name = element.Attribute(NAME_ATTRIBUTE).Value.ToString() != null ?
                    element.Attribute(NAME_ATTRIBUTE).Value.ToString() : "";

                string prefix = element.Attribute(PREFIX_ATTRIBUTE) != null ?
                    element.Attribute(PREFIX_ATTRIBUTE).Value.ToString() : "";
                string textColour = element.Attribute(TEXTCOLOUR_ATTRIBUTE) != null ?
                    element.Attribute(TEXTCOLOUR_ATTRIBUTE).Value.ToString() : "";

                string exclusionString = "";
                string defaultsString = "";

                exclusionString = element.Attribute(EXCLUSIONS_ATTRIBUTE) != null ?
                element.Attribute(EXCLUSIONS_ATTRIBUTE).Value.ToString() : "";

                defaultsString = element.Attribute(DEFAULTITEMS_ATTRIBUTE) != null ?
                    element.Attribute(DEFAULTITEMS_ATTRIBUTE).Value.ToString() : "";

                exclusionString = exclusionString.RemoveWhitespace();
                defaultsString = defaultsString.RemoveWhitespace();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                //Convert string ID to Int ID
                int id = -1;
                int.TryParse(idString, out id);

                //Save SavedItemData
                data.Add(new SavedItemData(attribute ,id, name, prefix, exclusionString, new List<SavedItemData>(0), defaultsString, new List<SavedItemData>(0), textColour));

                dataTable.Rows.Add(attribute, id, name, prefix, exclusionString, defaultsString);
            }
            return data;
        }
        
        private static void CalculateExclusions()
        {
            char[] elementSplit = new char[] {';' };
            char[] IdSplit = new char[] {'(',',',')'};

            for(int i = 0; i < XMLData.Count; i++)
            {
                SavedItemData data = XMLData[i];

                string[] elements = data.exclusionString.Split(elementSplit, StringSplitOptions.RemoveEmptyEntries ); //split elements
                foreach(var element in elements)
                {
                    string searchAttribute = "";
                    List<string> exclusionsIDString = element.Split(IdSplit,StringSplitOptions.RemoveEmptyEntries).ToList(); // split element ID's
                    searchAttribute = exclusionsIDString[0];
                    exclusionsIDString.RemoveAt(0);

                    if (exclusionsIDString.Count < 0)
                        break;

                    
                
                    string[] actualExclusionIds = exclusionsIDString.ToArray();
                    int[] idsToExclude = Array.ConvertAll(actualExclusionIds, s => int.Parse(s));
                    if (idsToExclude.Length > 0)
                    {
                        var exclusionAttributes = XMLData.FindAll(item => item.attribute == searchAttribute);
                        if(exclusionAttributes.Count>0)
                        {
                            for (int x = 0; x < idsToExclude.Length; x++)
                            {
                                int id = idsToExclude[x];
                                foreach (var exclusionAttribute in exclusionAttributes)
                                {
                                    if(exclusionAttribute.id == id)
                                    {
                                        SavedItemData exclusionData = new SavedItemData(
                                            exclusionAttribute.attribute,
                                            exclusionAttribute.id,
                                            exclusionAttribute.name, 
                                            exclusionAttribute.prefix, 
                                            "",new List<SavedItemData>(),
                                            "",new List<SavedItemData>());

                                        data.exclusions.Add(exclusionData);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }            
        }
        private static void CalculateDefaults()
        {
            char[] elementSplit = new char[] { ';' };
            char[] IdSplit = new char[] { '(',',', ')' };

            for (int i = 0; i < XMLData.Count; i++)
            {
                SavedItemData data = XMLData[i];

                string[] elements = data.defaultItemsString.Split(elementSplit, StringSplitOptions.RemoveEmptyEntries); //split elements
                foreach (var element in elements)
                {
                    string searchAttribute = "";
                    List<string> DefaultsIDString = element.Split(IdSplit, StringSplitOptions.RemoveEmptyEntries).ToList(); // split element ID's
                    searchAttribute = DefaultsIDString[0];
                    DefaultsIDString.RemoveAt(0);

                    if (DefaultsIDString.Count <= 0 || DefaultsIDString.Count > 1)
                    {
                        if (DefaultsIDString.Count > 1)
                            MessageBox.Show(string.Format("{0}({1}) Issue reading Default items: found {2} in {3}. There can only be 1 Id per element", data.attribute,data.name, DefaultsIDString.Count,searchAttribute));
                        break;
                    }

                    string defaultIdString = DefaultsIDString[0];

                    int defaultId = -1;
                    int.TryParse(defaultIdString, out defaultId);

                    if (defaultId != -1)
                    {
                        var defaultData = XMLData.FindAll(item => item.attribute == searchAttribute);
                        if (defaultData.Count <= 0)
                            break;
                        foreach (var defaultAttributeData in defaultData)
                        {
                            if(defaultAttributeData.id == defaultId)
                            {
                                SavedItemData newDefaultData = new SavedItemData(
                                    defaultAttributeData.attribute,
                                    defaultAttributeData.id,
                                    defaultAttributeData.name,
                                    defaultAttributeData.prefix,
                                    "", new List<SavedItemData>(),
                                    "", new List<SavedItemData>());
                                data.defaultItems.Add(newDefaultData);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}