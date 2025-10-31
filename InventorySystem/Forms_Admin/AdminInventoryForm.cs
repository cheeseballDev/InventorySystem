using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class AdminInventoryForm : Form
    {
        public AdminInventoryForm()
        {
            InitializeComponent();
            // SHOULD I ADD ENUMS?
            cbxPerfumeNoteFilter.Items.AddRange(new string[] { "Premium", "Classic" });
            cbxPerfumeBranchFilter.Items.AddRange(new string[] { "Sta. Lucia", "Riverbanks" });
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {

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
