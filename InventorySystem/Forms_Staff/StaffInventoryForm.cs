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
    public partial class StaffInventoryForm : Form
    {
        public StaffInventoryForm()
        {
            InitializeComponent();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StaffEditPerfumePopUp editProductPopUp = new StaffEditPerfumePopUp();
            editProductPopUp.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
