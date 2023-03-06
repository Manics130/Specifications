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
        public List<Data> selectedPlacementExclusions = new List<Data>();
        public List<Data> selectedItemTypeExclusions = new List<Data>();
        public List<Data> selectedViewTypesExclusions = new List<Data>();
        public List<Data> selectedOpeningSidesExclusions = new List<Data>();
        public List<Data> selectedBeadingSidesExclusions = new List<Data>();
        public List<Data> selectedMasterLeafSidesExclusions = new List<Data>();
        public List<Data> selectedFrameRalColourExclusions = new List<Data>();
        public List<Data> selectedIronFinishesExclusions = new List<Data>();
        public List<Data> selectedMongeryTypesExclusions = new List<Data>();
        public List<Data> selectedHingeTypesExclusions = new List<Data>();
        public List<Data> selectedLockTypesExclusions = new List<Data>();
        public List<Data> selectedBeadingTypesExclusions = new List<Data>();
        public List<Data> selectedGlassTypesExclusions = new List<Data>();
    }
}
