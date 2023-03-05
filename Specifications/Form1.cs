using Specifications.DataHolder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Specifications
{
    public partial class Specifications : Form
    {
        private List<string> CurrentlyExcluded = new List<string>();
        private ExclusionList m_Exclusions = new ExclusionList();

        /*
         * TODO Bug List - items appearing when scrolling though items
         
         */

        public Specifications()
        {
            InitializeComponent();
            XMLReaderWriter.Read();
        }

        public void DisplayMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDropdowns();
        }

        //TODO Move to own exlusion checking class
        private void GenerateDropdowns()
        {

            /* No Longer inuse
            RemoveExclusion(ref Placements_dropdown);
            RemoveExclusion(ref ItemTypes_dropdown);
            RemoveExclusion(ref ViewedFrom_dropdown);
            RemoveExclusion(ref OpeningSide_dropdown);
            RemoveExclusion(ref BeadingSide_dropdown);
            RemoveExclusion(ref MasterLeaf_dropdown);
            RemoveExclusion(ref FrameColour_dropdown);
            RemoveExclusion(ref IronFinish_dropdown);
            RemoveExclusion(ref Ironmongery_dropdown);
            RemoveExclusion(ref LockType_dropdown);
            RemoveExclusion(ref HingeType_dropdown);
            RemoveExclusion(ref BeadingType_dropdown);
            RemoveExclusion(ref GlassType_dropdown);
            */
            //Creates exclusion list for each element
            CreateExclusionList(ref Placements_dropdown, ref m_Exclusions.selectedPlacement, ref m_Exclusions.selectedPlacementExclusions);
            CreateExclusionList(ref ItemTypes_dropdown, ref m_Exclusions.selectedItemType, ref m_Exclusions.selectedItemTypeExclusions);
            CreateExclusionList(ref ViewedFrom_dropdown, ref m_Exclusions.selectedViewType, ref m_Exclusions.selectedViewTypesExclusions);
            CreateExclusionList(ref OpeningSide_dropdown, ref m_Exclusions.selectedOpeningSide, ref m_Exclusions.selectedOpeningSidesExclusions);
            CreateExclusionList(ref BeadingSide_dropdown, ref m_Exclusions.selectedBeadingSide, ref m_Exclusions.selectedBeadingSidesExclusions);
            CreateExclusionList(ref MasterLeaf_dropdown, ref m_Exclusions.selectedMasterLeafSide, ref m_Exclusions.selectedMasterLeafSidesExclusions);
            CreateExclusionList(ref FrameColour_dropdown, ref m_Exclusions.selectedFrameRalColour, ref m_Exclusions.selectedFrameRalColourExclusions);
            CreateExclusionList(ref IronFinish_dropdown, ref m_Exclusions.selectedIronFinish, ref m_Exclusions.selectedIronFinishesExclusions);
            CreateExclusionList(ref Ironmongery_dropdown, ref m_Exclusions.selectedMongeryType, ref m_Exclusions.selectedMongeryTypesExclusions);
            CreateExclusionList(ref HingeType_dropdown, ref m_Exclusions.selectedHingeType, ref m_Exclusions.selectedHingeTypesExclusions);
            CreateExclusionList(ref LockType_dropdown, ref m_Exclusions.selectedLockType, ref m_Exclusions.selectedLockTypesExclusions);
            CreateExclusionList(ref BeadingType_dropdown, ref m_Exclusions.selectedBeadingType, ref m_Exclusions.selectedBeadingTypesExclusions);
            CreateExclusionList(ref GlassType_dropdown, ref m_Exclusions.selectedGlassType, ref m_Exclusions.selectedGlassTypesExclusions);



            SyphonDropdownData(XMLReaderWriter.PLACEMENT_ELEMENT, ref Placements_dropdown);
            SyphonDropdownData(XMLReaderWriter.ITEMTYPE_ELEMENT, ref ItemTypes_dropdown);
            SyphonDropdownData(XMLReaderWriter.VIEWTYPE_ELEMENT, ref ViewedFrom_dropdown);
            SyphonDropdownData(XMLReaderWriter.OPENINGSIDE_ELEMENT, ref OpeningSide_dropdown);
            SyphonDropdownData(XMLReaderWriter.BEADINGSIDE_ELEMENT, ref BeadingSide_dropdown);
            SyphonDropdownData(XMLReaderWriter.MASTERLEAFSIDE_ELEMENT, ref MasterLeaf_dropdown);
            SyphonDropdownData(XMLReaderWriter.FRAMERALCOLOUR_ELEMENT, ref FrameColour_dropdown);
            SyphonDropdownData(XMLReaderWriter.IRONFINISH_ELEMENT, ref IronFinish_dropdown);
            SyphonDropdownData(XMLReaderWriter.MONGERYTYPE_ELEMENT, ref Ironmongery_dropdown);
            SyphonDropdownData(XMLReaderWriter.LOCKTYPE_ELEMENT, ref LockType_dropdown);
            SyphonDropdownData(XMLReaderWriter.HINGETYPE_ELEMENT, ref HingeType_dropdown);
            SyphonDropdownData(XMLReaderWriter.BEADINGTYPE_ELEMENT, ref BeadingType_dropdown);
            SyphonDropdownData(XMLReaderWriter.GLASSTYPE_ELEMENT, ref GlassType_dropdown);

            ExclusionFilter();
        }

        private void SyphonDropdownData(string attribute, ref ComboBox dropdownList)
        {
            //RemoveExclusion(ref dropdownList);

            var dropdownItems = XMLReaderWriter.XMLData.FindAll(item => item.attribute == attribute);
            foreach (var dropdownItem in dropdownItems)
            {
                if (!dropdownList.Items.Contains(dropdownItem.name))
                {
                    dropdownList.Items.Add(dropdownItem.name);
                }
            }
        }
        private void ExclusionCheck(ref ComboBox dropdown, string exclusionName)
        {
            if (dropdown.Text == exclusionName)
                dropdown.Text = "";

            if (dropdown.Items.Contains(exclusionName))
            {
                dropdown.Items.Remove(exclusionName);
                CurrentlyExcluded.Add(exclusionName);
            }
        }
        private void DefaultCheck(ref ComboBox dropdown, string defaultName)
        {
            if (dropdown.Items.Contains(defaultName) && (dropdown.Text == "" || dropdown.Text != defaultName))
            {
                //dropdown.SelectedText = "";
                dropdown.Text = defaultName;
            }
        }

        /// <summary>
        /// Depreciated No Longer inuse
        /// </summary>
        private void RemoveExclusion(ref ComboBox dropdown)
        {
            CurrentlyExcluded = new List<string>();
            string selectedText = dropdown.Text;
            if (selectedText != "")
            {
                //Run though all the cases
                Data selectedData = selectedText == null ? new Data() : XMLReaderWriter.XMLData.Find(item => item.name == selectedText);
                foreach (var exclusion in selectedData.exclusions)
                {
                    var exclusionName = exclusion.name;
                    ExclusionCheck(ref Placements_dropdown, exclusionName);
                    ExclusionCheck(ref ItemTypes_dropdown, exclusionName);
                    ExclusionCheck(ref ViewedFrom_dropdown, exclusionName);
                    ExclusionCheck(ref OpeningSide_dropdown, exclusionName);
                    ExclusionCheck(ref BeadingSide_dropdown, exclusionName);
                    ExclusionCheck(ref MasterLeaf_dropdown, exclusionName);
                    ExclusionCheck(ref FrameColour_dropdown, exclusionName);
                    ExclusionCheck(ref IronFinish_dropdown, exclusionName);
                    ExclusionCheck(ref Ironmongery_dropdown, exclusionName);
                    ExclusionCheck(ref HingeType_dropdown, exclusionName);
                    ExclusionCheck(ref LockType_dropdown, exclusionName);
                    ExclusionCheck(ref BeadingType_dropdown, exclusionName);
                    ExclusionCheck(ref GlassType_dropdown, exclusionName);
                }
            }
        }

        //TODO Move to own exlusion checking class
        public void ExclusionFilter()
        {
            
            /* Removed for the time being as causing issues - not able to switch to a new item in the list other then the default value
                        //Adds default values
                        AddDefaultValues(ref Placements_dropdown);
                        AddDefaultValues(ref ItemTypes_dropdown);
                        AddDefaultValues(ref ViewedFrom_dropdown);
                        AddDefaultValues(ref OpeningSide_dropdown);
                        AddDefaultValues(ref BeadingSide_dropdown);
                        AddDefaultValues(ref MasterLeaf_dropdown);
                        AddDefaultValues(ref FrameColour_dropdown);
                        AddDefaultValues(ref IronFinish_dropdown);
                        AddDefaultValues(ref Ironmongery_dropdown);
                        AddDefaultValues(ref HingeType_dropdown);
                        AddDefaultValues(ref LockType_dropdown);
                        AddDefaultValues(ref BeadingType_dropdown);
                        AddDefaultValues(ref GlassType_dropdown);
            */

            //Removes excluded items from each list
            UpdateExclusionList(ref Placements_dropdown);
            UpdateExclusionList(ref ItemTypes_dropdown);
            UpdateExclusionList(ref ViewedFrom_dropdown);
            UpdateExclusionList(ref OpeningSide_dropdown);
            UpdateExclusionList(ref BeadingSide_dropdown);
            UpdateExclusionList(ref MasterLeaf_dropdown);
            UpdateExclusionList(ref FrameColour_dropdown);
            UpdateExclusionList(ref IronFinish_dropdown);
            UpdateExclusionList(ref Ironmongery_dropdown);
            UpdateExclusionList(ref HingeType_dropdown);
            UpdateExclusionList(ref LockType_dropdown);
            UpdateExclusionList(ref BeadingType_dropdown);
            UpdateExclusionList(ref GlassType_dropdown);
        }
        private void CreateExclusionList(ref ComboBox dropdown, ref string selectedDropdown, ref List<Data> exclusionList)
        {
            string selected = dropdown.Text;
            if (selected == "")
                return;
            if (selected != selectedDropdown)
            {
                selectedDropdown = selected;
                exclusionList = new List<Data>();
            }

            Data selectedData = selected == "" ? new Data() : XMLReaderWriter.XMLData.Find(item => item.name == selected);
            foreach (var exclusion in selectedData.exclusions)
            {
                if (!exclusionList.Contains(exclusion)){

                    var exclusionAttribute = exclusion.attribute;
                    switch (exclusionAttribute)
                    {
                        case XMLReaderWriter.PLACEMENT_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.ITEMTYPE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.VIEWTYPE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.OPENINGSIDE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.BEADINGSIDE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.MASTERLEAFSIDE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.FRAMERALCOLOUR_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.IRONFINISH_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.MONGERYTYPE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.HINGETYPE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.LOCKTYPE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.BEADINGTYPE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                        case XMLReaderWriter.GLASSTYPE_ELEMENT://Add name to exclusion list
                            exclusionList.Add(exclusion);
                            break;
                    }
                }
            }
        }

        //TODO Move to own exlusion checking class
        private void UpdateExclusionList(ref ComboBox dropdown)
        {
            //All current exclusions based on currently selected
            
            var DataStore = new List<(string selectedText, List<Data> data)>() 
            {
                (m_Exclusions.selectedPlacement, m_Exclusions.selectedPlacementExclusions),
                (m_Exclusions.selectedItemType, m_Exclusions.selectedItemTypeExclusions),
                (m_Exclusions.selectedViewType, m_Exclusions.selectedViewTypesExclusions),
                (m_Exclusions.selectedOpeningSide, m_Exclusions.selectedOpeningSidesExclusions),
                (m_Exclusions.selectedBeadingSide, m_Exclusions.selectedBeadingSidesExclusions),
                (m_Exclusions.selectedMasterLeafSide, m_Exclusions.selectedMasterLeafSidesExclusions),
                (m_Exclusions.selectedFrameRalColour, m_Exclusions.selectedFrameRalColourExclusions),
                (m_Exclusions.selectedIronFinish, m_Exclusions.selectedIronFinishesExclusions),
                (m_Exclusions.selectedMongeryType, m_Exclusions.selectedMongeryTypesExclusions),
                (m_Exclusions.selectedHingeType, m_Exclusions.selectedHingeTypesExclusions),
                (m_Exclusions.selectedLockType, m_Exclusions.selectedLockTypesExclusions),
                (m_Exclusions.selectedBeadingType, m_Exclusions.selectedBeadingTypesExclusions),
                (m_Exclusions.selectedGlassType, m_Exclusions.selectedGlassTypesExclusions),
            };

            foreach(var data in DataStore)
            {
                FilterExclusions(ref dropdown, data);
            }


            /*var itemTypes = m_Exclusions.selectedItemTypeExclusions;
            var viewTypes = m_Exclusions.selectedViewTypesExclusions;
            var openingSides = m_Exclusions.selectedOpeningSidesExclusions;
            var beadingSides = m_Exclusions.selectedBeadingSidesExclusions;
            var masterLeafs = m_Exclusions.selectedMasterLeafSidesExclusions;
            var frameColours = m_Exclusions.selectedFrameRalColourExclusions;
            var ironFinishes = m_Exclusions.selectedIronFinishesExclusions;
            var mongeryTypes = m_Exclusions.selectedMongeryTypesExclusions;
            var hingeTypes = m_Exclusions.selectedHingeTypesExclusions;
            var lockTypes = m_Exclusions.selectedLockTypesExclusions;
            var beadingTypes = m_Exclusions.selectedBeadingTypesExclusions;
            var glassTypes = m_Exclusions.selectedGlassTypesExclusions;*/
            //end of exclusions based on selected



            /*FilterExclusions(ref dropdown, placements);
            FilterExclusions(ref dropdown, itemTypes);
            FilterExclusions(ref dropdown, viewTypes);
            FilterExclusions(ref dropdown, openingSides);
            FilterExclusions(ref dropdown, beadingSides);
            FilterExclusions(ref dropdown, masterLeafs);
            FilterExclusions(ref dropdown, frameColours);
            FilterExclusions(ref dropdown, ironFinishes);
            FilterExclusions(ref dropdown, mongeryTypes);
            FilterExclusions(ref dropdown, hingeTypes);
            FilterExclusions(ref dropdown, lockTypes);
            FilterExclusions(ref dropdown, beadingTypes);
            FilterExclusions(ref dropdown, glassTypes);*/
        }
        private void FilterExclusions(ref ComboBox dropdown, (string selectedText, List<Data> data) exclusions)
        {

            foreach (var item in exclusions.data)
            {
                if (dropdown.Items.Contains(item.name))
                {
                    if (dropdown.Text == exclusions.selectedText)
                        exclusions.selectedText = "";

                    dropdown.Items.Remove(item.name);
                }
            }
        }
        private void AddDefaultValues(ref ComboBox dropdown)
        {
            string selectedText = dropdown.Text;
            if (selectedText != "")
            {
                Data selectedData = selectedText == null ? new Data() : XMLReaderWriter.XMLData.Find(item => item.name == selectedText);
                foreach (var defaultItem in selectedData.defaultItems)
                {

                    DefaultCheck(ref Placements_dropdown, defaultItem.name);
                    DefaultCheck(ref ItemTypes_dropdown, defaultItem.name);
                    DefaultCheck(ref ViewedFrom_dropdown, defaultItem.name);
                    DefaultCheck(ref OpeningSide_dropdown, defaultItem.name);
                    DefaultCheck(ref BeadingSide_dropdown, defaultItem.name);
                    DefaultCheck(ref MasterLeaf_dropdown, defaultItem.name);
                    DefaultCheck(ref FrameColour_dropdown, defaultItem.name);
                    DefaultCheck(ref IronFinish_dropdown, defaultItem.name);
                    DefaultCheck(ref Ironmongery_dropdown, defaultItem.name);
                    DefaultCheck(ref HingeType_dropdown, defaultItem.name);
                    DefaultCheck(ref LockType_dropdown, defaultItem.name);
                    DefaultCheck(ref BeadingType_dropdown, defaultItem.name);
                    DefaultCheck(ref GlassType_dropdown, defaultItem.name);
                }
            }
        }


        #region List Update
        private void Placements_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.PLACEMENT_ELEMENT;

            if (m_Exclusions.selectedPlacement == dropdown.Text)
                if (m_Exclusions.selectedPlacement != "")                
                    return;

            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
        }

        private void ItemTypes_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.ITEMTYPE_ELEMENT;

            if (m_Exclusions.selectedItemType == dropdown.SelectedText)
                if (m_Exclusions.selectedItemType != "")
                    return;

            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            //SyphonDropdownData(element, ref dropdown);
        }

        private void ViewedFrom_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                        ComboBox dropdown = (ComboBox)sender;
                        var element = XMLReaderWriter.VIEWTYPE_ELEMENT;
                        AddDefaultValues(ref dropdown);

                        GenerateDropdowns();
                        SyphonDropdownData(element, ref dropdown);*/
        }

        private void OpeningSide_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.OPENINGSIDE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void BeadingSide_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.BEADINGSIDE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void MasterLeaf_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.MASTERLEAFSIDE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void IronFinish_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.IRONFINISH_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void FrameColour_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.FRAMERALCOLOUR_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void Ironmongery_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.MONGERYTYPE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void LockType_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.LOCKTYPE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void HingeType_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.HINGETYPE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void GlassType_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.GLASSTYPE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }

        private void BeadingType_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox dropdown = (ComboBox)sender;
            var element = XMLReaderWriter.BEADINGTYPE_ELEMENT;
            AddDefaultValues(ref dropdown);

            GenerateDropdowns();
            SyphonDropdownData(element, ref dropdown);*/
        }
        #endregion
    }

}