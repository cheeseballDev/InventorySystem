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
            PlaceholderHelper.ApplyPlaceholder(tbSearchUserFilter, "Search user...");
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
            if (string.IsNullOrWhiteSpace(cbxAuditLogActionFilter.Text) || string.IsNullOrWhiteSpace(tbSearchUserFilter.Text))
            {
                loadAuditLog();
                return;
            }
            String query = "select Log_ID, User_ID, Action, Module, Timestamp from auditlogtable where Action like @action and User_ID like @user and date(Timestamp) between @startDate and @endDate";
            MySqlParameter actionParameter = new MySqlParameter("@action", "%" + cbxAuditLogActionFilter.Text + "%");
            MySqlParameter userParameter = new MySqlParameter("@user", "%" + tbSearchUserFilter.Text + "%");
            MySqlParameter startDateParameter = new MySqlParameter("@startDate", dtpAuditLogDateFrom.Value.Date);
            MySqlParameter endDateParameter = new MySqlParameter("@endDate", dtpAuditLogDateTo.Value.Date);

            dgAuditLog.DataSource = DatabaseHelper.ExecuteQuery(query, actionParameter, userParameter, startDateParameter, endDateParameter);
        }

        private void btnOpenAuditDetails_Click(object sender, EventArgs e)
        {
            AuditDetailsPopUp auditDetailsPopUp = new AuditDetailsPopUp();
            auditDetailsPopUp.ShowDialog();
        }
    }
}
