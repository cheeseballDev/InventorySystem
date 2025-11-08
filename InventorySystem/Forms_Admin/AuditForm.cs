using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Helper_Classes;

namespace InventorySystem
{
    public partial class AuditForm : Form
    {
        public AuditForm()
        {
            InitializeComponent();
            loadAuditLog();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadAuditLog()
        {
            String query = "select * from auditlogtable";
            dgAuditLog.DataSource = DatabaseHelper.ExecuteQuery(query);
        }
    }
}
