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
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AuditForm : Form
    {
        public AuditForm()
        {
            InitializeComponent();
            // cbxAuditLogUserFilter
            // cbxAuditLogActionFilter
            // LAGAY MO DITO LAHAT NG ACTIONS AND USERS SA LOOB NG COMBOBOX

            DatabaseHelper.cbxLoader("Admin", cbxAuditLogUserFilter);
            DatabaseHelper.cbxLoader("Staff", cbxAuditLogUserFilter);
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

        private void btnSearchAuditLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxAuditLogActionFilter.Text) || string.IsNullOrWhiteSpace(cbxAuditLogUserFilter.Text))
            {
                loadAuditLog();
                return;
            }
            String query = "select Log_ID, User_ID, Action, Module, Timestamp from auditlogtable where Action like @action and User_ID like @user and date(Timestamp) between @startDate and @endDate";
            MySqlParameter actionParameter = new MySqlParameter("@action", "%" + cbxAuditLogActionFilter.Text + "%");
            MySqlParameter userParameter = new MySqlParameter("@user", "%" + cbxAuditLogUserFilter.Text + "%");
            MySqlParameter startDateParameter = new MySqlParameter("@startDate", dtpAuditLogDateFrom.Value.Date);
            MySqlParameter endDateParameter = new MySqlParameter("@endDate", dtpAuditLogDateTo.Value.Date);

            dgAuditLog.DataSource = DatabaseHelper.ExecuteQuery(query, actionParameter, userParameter, startDateParameter, endDateParameter);
        }
    }
}
