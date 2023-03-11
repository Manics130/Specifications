using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.DataHolder
{
    internal class ExclusionList
    {
        //Currently Selected Dropdown items
        public string selectedPlacement = "";
        public string selectedItemType = "";
        public string selectedViewType = "";
        public string selectedOpeningSide = "";
        public string selectedBeadingSide = "";
        public string selectedMasterLeafSide = "";
        public string selectedFrameRalColour = "";
        public string selectedIronFinish = "";
        public string selectedMongeryType = "";
        public string selectedHingeType = "";
        public string selectedLockType = "";
        public string selectedBeadingType = "";
        public string selectedGlassType = "";

        //Currently Selected Dropdown items exclusions
        public List<SavedItemData> selectedPlacementExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedItemTypeExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedViewTypesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedOpeningSidesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedBeadingSidesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedMasterLeafSidesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedFrameRalColourExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedIronFinishesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedMongeryTypesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedHingeTypesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedLockTypesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedBeadingTypesExclusions = new List<SavedItemData>();
        public List<SavedItemData> selectedGlassTypesExclusions = new List<SavedItemData>();
    }
}
