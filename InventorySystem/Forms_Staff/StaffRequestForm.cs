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

            List<string> parfumList = new List<string>();
            parfumList = Helper_Classes.DatabaseHelper.GetListQuery("SELECT Perfume FROM perfumetable GROUP BY Perfume");

            cbxRequestParfumFilter.Items.AddRange(parfumList.ToArray());
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
