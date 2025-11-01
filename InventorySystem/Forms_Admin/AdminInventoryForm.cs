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
    public partial class AdminInventoryForm : Form
    {
        public AdminInventoryForm()
        {
            InitializeComponent();
            Helper_Classes.PlaceholderHelper.ApplyPlaceholder(tbSearchPerfumeFilter, "Search Perfume...");

            cbxPerfumeNoteFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeNote)));
            cbxPerfumeBranchFilter.Items.AddRange(Enum.GetNames(typeof(PerfumeBranch)));
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnScanQR_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminEditPerfumePopUp editProductPopUp = new AdminEditPerfumePopUp();
            editProductPopUp.ShowDialog();
        }
    }
}
