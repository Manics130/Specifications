using Specifications;
using Specifications.DataHolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Specifications_4._8
{
    public partial class SpecificationMainForm : Form
    {
        private ProcessData data = new ProcessData();
        private ExclusionList m_Exclusions = new ExclusionList();
        public SpecificationMainForm()
        {
            InitializeComponent();
            XMLReaderWriter.Read();
            GenerateDropdown();
            dataGridView1.DataSource = XMLReaderWriter.DataBase.Tables[0];
            dataGridView1.MultiSelect = true;
        }

        private void GenerateDropdown()
        {
            data.CreateExclusionList(ref Placements_dropdown, ref m_Exclusions.selectedPlacement, ref m_Exclusions.selectedPlacementExclusions);
            data.CreateExclusionList(ref ItemTypes_dropdown, ref m_Exclusions.selectedItemType, ref m_Exclusions.selectedItemTypeExclusions);
            data.CreateExclusionList(ref ViewedFrom_dropdown, ref m_Exclusions.selectedViewType, ref m_Exclusions.selectedViewTypesExclusions);
            data.CreateExclusionList(ref OpeningSide_dropdown, ref m_Exclusions.selectedOpeningSide, ref m_Exclusions.selectedOpeningSidesExclusions);
            data.CreateExclusionList(ref BeadingSide_dropdown, ref m_Exclusions.selectedBeadingSide, ref m_Exclusions.selectedBeadingSidesExclusions);
            data.CreateExclusionList(ref MasterLeaf_dropdown, ref m_Exclusions.selectedMasterLeafSide, ref m_Exclusions.selectedMasterLeafSidesExclusions);
            data.CreateExclusionList(ref FrameColour_dropdown, ref m_Exclusions.selectedFrameRalColour, ref m_Exclusions.selectedFrameRalColourExclusions);
            data.CreateExclusionList(ref IronFinish_dropdown, ref m_Exclusions.selectedIronFinish, ref m_Exclusions.selectedIronFinishesExclusions);
            data.CreateExclusionList(ref Ironmongery_dropdown, ref m_Exclusions.selectedMongeryType, ref m_Exclusions.selectedMongeryTypesExclusions);
            data.CreateExclusionList(ref HingeType_dropdown, ref m_Exclusions.selectedHingeType, ref m_Exclusions.selectedHingeTypesExclusions);
            data.CreateExclusionList(ref LockType_dropdown, ref m_Exclusions.selectedLockType, ref m_Exclusions.selectedLockTypesExclusions);
            data.CreateExclusionList(ref BeadingType_dropdown, ref m_Exclusions.selectedBeadingType, ref m_Exclusions.selectedBeadingTypesExclusions);
            data.CreateExclusionList(ref GlassType_dropdown, ref m_Exclusions.selectedGlassType, ref m_Exclusions.selectedGlassTypesExclusions);



            data.SyphonDropdownData(XMLReaderWriter.PLACEMENT_ELEMENT, ref Placements_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.ITEMTYPE_ELEMENT, ref ItemTypes_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.VIEWTYPE_ELEMENT, ref ViewedFrom_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.OPENINGSIDE_ELEMENT, ref OpeningSide_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.BEADINGSIDE_ELEMENT, ref BeadingSide_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.MASTERLEAFSIDE_ELEMENT, ref MasterLeaf_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.FRAMERALCOLOUR_ELEMENT, ref FrameColour_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.IRONFINISH_ELEMENT, ref IronFinish_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.MONGERYTYPE_ELEMENT, ref Ironmongery_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.LOCKTYPE_ELEMENT, ref LockType_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.HINGETYPE_ELEMENT, ref HingeType_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.BEADINGTYPE_ELEMENT, ref BeadingType_dropdown);
            data.SyphonDropdownData(XMLReaderWriter.GLASSTYPE_ELEMENT, ref GlassType_dropdown);


            data.ExclusionFilter(ref m_Exclusions, ref Placements_dropdown, ref ItemTypes_dropdown, ref ViewedFrom_dropdown,
                ref OpeningSide_dropdown, ref BeadingSide_dropdown, ref MasterLeaf_dropdown, ref FrameColour_dropdown,
                ref IronFinish_dropdown, ref Ironmongery_dropdown, ref LockType_dropdown, ref HingeType_dropdown,
                ref BeadingType_dropdown, ref GlassType_dropdown);

        }

        private void Placements_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDropdown();
        }

        private void ItemTypes_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateDropdown();
        }

        private void DropdownList_Changed(object sender, EventArgs e)
        {
            ComboBox dropdown = (ComboBox)sender;
            data.AddDefaultValues(ref dropdown, ref Placements_dropdown, ref ItemTypes_dropdown, ref ViewedFrom_dropdown,
                ref OpeningSide_dropdown, ref BeadingSide_dropdown, ref MasterLeaf_dropdown, ref FrameColour_dropdown,
                ref IronFinish_dropdown, ref Ironmongery_dropdown, ref LockType_dropdown, ref HingeType_dropdown,
                ref BeadingType_dropdown, ref GlassType_dropdown);
            GenerateDropdown();
        }

        int m_SelectedRow = -1;

        List<int> SelectedIndexs = new List<int> ();

        private void SelectionChanged(object sender, EventArgs e)
        {
            DataGridView data = (DataGridView)sender;
            var currentCell = data.CurrentCell;
            if (data.SelectedCells.Count <= 1)//Single Select
            {
                if (currentCell.ColumnIndex == 4 && m_SelectedRow != currentCell.RowIndex)
                {
                    ConsoleLine.Text = "Selected " + currentCell.FormattedValue.ToString();
                    SelectedIndexs = new List<int>();
                    m_SelectedRow = currentCell.RowIndex;

                    SelectExcluded(currentCell.FormattedValue.ToString(), data);
                }
            }
            else
            {
                if (m_SelectedRow == -1)
                    return;

                if (!SelectedIndexs.Contains(currentCell.RowIndex))
                {
                    SelectedIndexs.Add(currentCell.RowIndex);
                    ConsoleLine.Text = "Added " + currentCell.FormattedValue.ToString();
                    data.Rows[currentCell.RowIndex].Selected = true;

                }
            }
        }
        private void SelectExcluded(string exclusionString, DataGridView data)
        {
            char[] elementSplit = new char[] { ';' };
            char[] IdSplit = new char[] { '(', ',', ')' };

            string[] elements = exclusionString.Split(elementSplit, StringSplitOptions.RemoveEmptyEntries); //split elements
            foreach (var element in elements)
            {
                string searchAttribute = "";
                List<string> exclusionsIDString = element.Split(IdSplit, StringSplitOptions.RemoveEmptyEntries).ToList(); // split element ID's
                searchAttribute = exclusionsIDString[0];
                exclusionsIDString.RemoveAt(0);

                if (exclusionsIDString.Count < 0)
                    break;

                string[] actualExclusionIds = exclusionsIDString.ToArray();
                foreach (var id in actualExclusionIds)
                {
                    for(int i = 0; i <dataGridView1.Rows.Count; i++)
                    {
                        var gridData = dataGridView1.Rows[i];

                        if (gridData.Cells[0].FormattedValue.ToString() == searchAttribute && gridData.Cells[1].FormattedValue.ToString() == id)
                        {
                            if (!SelectedIndexs.Contains(gridData.Cells[1].RowIndex))
                            {
                                SelectedIndexs.Add(gridData.Cells[0].RowIndex);
                                dataGridView1.Rows[gridData.Cells[0].RowIndex].Selected = true;
                                break;
                            }
                        } 
                    }
                    /*data.Rows[FoundRow.Index].Selected = true;
                    ConsoleLine.Text = FoundRow.Cells["ID"].FormattedValue.ToString();*/
                }

                
            }
        }
        private void CellLeft(object sender, EventArgs e)
        {
            DataGridView data = (DataGridView)sender;
            var currentCell = data.CurrentCell;

            if (m_SelectedRow != -1)
            {
                if (data.Rows[m_SelectedRow].Selected)
                {
                    m_SelectedRow = -1;
                    SelectedIndexs = new List<int>();
                }
            }

            if (SelectedIndexs.Contains(currentCell.RowIndex))
            {
                if (currentCell.Selected)
                    return;

                SelectedIndexs.Remove(currentCell.RowIndex);
                ConsoleLine.Text = "Removed " + currentCell.FormattedValue.ToString();
                data.Rows[currentCell.RowIndex].Selected = false;
            }
        }
        private void MultiSelectionChanged(object sender, EventArgs e)
        {
            DataGridView data = (DataGridView)sender;
            /*if (m_SelectedRow == -1)
                return;*/            
            ConsoleLine.Text = "Multi Selected";
        }
    }
}
