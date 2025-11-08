using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Enums;

namespace InventorySystem
{
    public partial class StaffRequestForm : Form
    {
        public StaffRequestForm()
        {
            InitializeComponent();
            cbxRequestCurrentBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));
            // CBX PERFUME TO REQUEST SHOULD BE GET THE DATABASE LIST OF PERFUMES
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
