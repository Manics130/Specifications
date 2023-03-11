using Specifications.DataHolder;
using Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specifications
{
    internal class ProcessData
    {  
        /*
         * TODO Bug List - items appearing when scrolling though items
         
         */

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
            
        }

        public void SyphonDropdownData(string attribute, ref ComboBox dropdownList)
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
        {/*
            if (dropdown.Text == exclusionName)
                dropdown.Text = "";

            if (dropdown.Items.Contains(exclusionName))
            {
                dropdown.Items.Remove(exclusionName);
                CurrentlyExcluded.Add(exclusionName);
            }*/
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
            /*CurrentlyExcluded = new List<string>();
            string selectedText = dropdown.Text;
            if (selectedText != "")
            {
                //Run though all the cases
                SavedItemData selectedData = selectedText == null ? new SavedItemData() : XMLReaderWriter.XMLData.Find(item => item.name == selectedText);
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
            }*/
        }

        //TODO Move to own exlusion checking class
        public void ExclusionFilter(ref ExclusionList exclusions, ref ComboBox placement, ref ComboBox itemTypes, ref ComboBox viewedfrom, ref ComboBox openingSides, 
            ref ComboBox beadingSides, ref ComboBox masterLeafs, ref ComboBox frameColours, ref ComboBox ironFinishs, ref ComboBox ironMongerys, 
            ref ComboBox hingeTypes, ref ComboBox lockTypes, ref ComboBox beadingTypes, ref ComboBox glassTypes)
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
            UpdateExclusionList(ref exclusions, ref placement);
            UpdateExclusionList(ref exclusions, ref itemTypes);
            UpdateExclusionList(ref exclusions, ref viewedfrom);
            UpdateExclusionList(ref exclusions, ref openingSides);
            UpdateExclusionList(ref exclusions, ref beadingSides);
            UpdateExclusionList(ref exclusions, ref masterLeafs);
            UpdateExclusionList(ref exclusions, ref frameColours);
            UpdateExclusionList(ref exclusions, ref ironFinishs);
            UpdateExclusionList(ref exclusions, ref ironMongerys);
            UpdateExclusionList(ref exclusions, ref hingeTypes);
            UpdateExclusionList(ref exclusions, ref lockTypes);
            UpdateExclusionList(ref exclusions, ref beadingTypes);
            UpdateExclusionList(ref exclusions, ref glassTypes);
        }
        public void CreateExclusionList(ref ComboBox dropdown, ref string selectedDropdown, ref List<SavedItemData> exclusionList)
        {
            string selected = dropdown.Text;
            if (selected == "")
                return;
            if (selected != selectedDropdown)
            {
                selectedDropdown = selected;
                exclusionList = new List<SavedItemData>();
            }

            SavedItemData selectedData = selected == "" ? new SavedItemData() : XMLReaderWriter.XMLData.Find(item => item.name == selected);
            foreach (var exclusion in selectedData.exclusions)
            {
                if (!exclusionList.Contains(exclusion))
                {

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
        private void UpdateExclusionList(ref ExclusionList exclusions, ref ComboBox dropdown)
        {
            //All current exclusions based on currently selected

            var DataStore = new List<(string selectedText, List<SavedItemData> data)>()
            {
                (exclusions.selectedPlacement, exclusions.selectedPlacementExclusions),
                (exclusions.selectedItemType, exclusions.selectedItemTypeExclusions),
                (exclusions.selectedViewType, exclusions.selectedViewTypesExclusions),
                (exclusions.selectedOpeningSide, exclusions.selectedOpeningSidesExclusions),
                (exclusions.selectedBeadingSide, exclusions.selectedBeadingSidesExclusions),
                (exclusions.selectedMasterLeafSide, exclusions.selectedMasterLeafSidesExclusions),
                (exclusions.selectedFrameRalColour, exclusions.selectedFrameRalColourExclusions),
                (exclusions.selectedIronFinish, exclusions.selectedIronFinishesExclusions),
                (exclusions.selectedMongeryType, exclusions.selectedMongeryTypesExclusions),
                (exclusions.selectedHingeType, exclusions.selectedHingeTypesExclusions),
                (exclusions.selectedLockType, exclusions.selectedLockTypesExclusions),
                (exclusions.selectedBeadingType, exclusions.selectedBeadingTypesExclusions),
                (exclusions.selectedGlassType, exclusions.selectedGlassTypesExclusions),
            };

            foreach (var data in DataStore)
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
        private void FilterExclusions(ref ComboBox dropdown, (string selectedText, List<SavedItemData> data) exclusions)
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
        public void AddDefaultValues(ref ComboBox currentDropdown, ref ComboBox placement, ref ComboBox itemTypes, ref ComboBox viewedfrom, ref ComboBox openingSides,
            ref ComboBox beadingSides, ref ComboBox masterLeafs, ref ComboBox frameColours, ref ComboBox ironFinishs, ref ComboBox ironMongerys,
            ref ComboBox hingeTypes, ref ComboBox lockTypes, ref ComboBox beadingTypes, ref ComboBox glassTypes)
        {
            string selectedText = currentDropdown.Text;
            if (selectedText != "")
            {
                SavedItemData selectedData = selectedText == null ? new SavedItemData() : XMLReaderWriter.XMLData.Find(item => item.name == selectedText);
                foreach (var defaultItem in selectedData.defaultItems)
                {

                    DefaultCheck(ref placement, defaultItem.name);
                    DefaultCheck(ref itemTypes, defaultItem.name);
                    DefaultCheck(ref viewedfrom, defaultItem.name);
                    DefaultCheck(ref openingSides, defaultItem.name);
                    DefaultCheck(ref beadingSides, defaultItem.name);
                    DefaultCheck(ref masterLeafs, defaultItem.name);
                    DefaultCheck(ref frameColours, defaultItem.name);
                    DefaultCheck(ref ironFinishs, defaultItem.name);
                    DefaultCheck(ref ironMongerys, defaultItem.name);
                    DefaultCheck(ref hingeTypes, defaultItem.name);
                    DefaultCheck(ref lockTypes, defaultItem.name);
                    DefaultCheck(ref beadingTypes, defaultItem.name);
                    DefaultCheck(ref glassTypes, defaultItem.name);
                }
            }
        }


    }
}
