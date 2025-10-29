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
    public partial class AdminApproveForm : Form
    {
        public AdminApproveForm()
        {
            InitializeComponent();
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            AdminRequestDetailsPopUp adminRequestDetailsPopUp = new AdminRequestDetailsPopUp();
            adminRequestDetailsPopUp.ShowDialog();
        }
    }
}
