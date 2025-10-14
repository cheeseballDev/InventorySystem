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
            tbSearchProduct.BackgroundImage = Image.FromFile("16");
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
