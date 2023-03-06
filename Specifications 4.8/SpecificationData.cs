using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    internal class SpecificationData
    {
        private string m_FinalSpecification = "";

        private string m_ReferenceNumber="11111";
        private string m_Quantity="1";
        private string m_Type="External double doors with side screen";
        private string m_Viewed = "Outside";
        private string m_Opens = "Outside";
        private string m_BeadingSide = "Outside";
        private string m_MasterLeaf = "Left Hand";

        private string m_FrameColour = "RAL";
        private string m_IronFinish = "Matt Black Chrome";
        private string m_IronFinishPrefixx = "(MBC)";
        private string m_Ironmongery = "Matt Black Chrome(MBC)";

        private string m_LockType = "Standard 5 Lever Lock";
        private string m_HandleHeight = "1000";
        private string m_MasterLockbox = "Yes";
        private string m_Handle = "Both Sides";
        private string m_Function = "Both Sides";
        private string m_SlaveLockbox = "None (Option 1)";

        private int m_Hinges = 3;

        private string[] m_Additions = new string[] { "None" };
        private string[] m_SteelAlly = new string[] { "None" };
        private string m_Notes = "None";

        private string m_Glass="18mm Clear";
        private string m_BeadingType = "Silicon";
        private string m_OnsiteWorks = "Supply & Install";

        public SpecificationData()
        { 

        }

        public string DisplayData()
        {
            m_FinalSpecification = string.Format
                ("Ref. No.:          Item{0} Quanitity {1} \n", m_ReferenceNumber, m_Quantity);
            m_FinalSpecification = string.Format
                ("Ref. No.:          Item{0} Quanitity {1} \n", m_ReferenceNumber, m_Quantity);

            return m_FinalSpecification;
        }
    }
}
