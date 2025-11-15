using InventorySystem.Helper_Classes;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class AuditForm : Form
    {
        private DateTime firstDay;
        private DateTime lastDay;
        public AuditForm()
        {
            InitializeComponent();
            PlaceholderHelper.ApplyPlaceholder(tbSearchUserFilter, "Search user...");
            loadAuditLog();

            cbxAuditLogActionFilter.SelectedIndex = 0;

            firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            lastDay = firstDay.AddMonths(1).AddDays(-1);

            dtpAuditLogDateFrom.Value = firstDay;
            dtpAuditLogDateTo.Value = lastDay;

        }

        private void loadAuditLog()
        {
            string query = "select Log_ID, User_ID, Action, Module, Timestamp from auditlogtable where 1=1 ";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!tbSearchUserFilter.Text.Equals("Search user...") && !string.IsNullOrEmpty(tbSearchUserFilter.Text))
            {
                query += " and User_ID like @user";
                parameters.Add(new MySqlParameter("@user", "%" + tbSearchUserFilter.Text + "%"));
            }
            if (!cbxAuditLogActionFilter.Text.Equals("All"))
            {
                query += " and Action like @action";
                parameters.Add(new MySqlParameter("@action", "%" + cbxAuditLogActionFilter.Text + "%"));
            }
            if (dtpAuditLogDateFrom.Value <= dtpAuditLogDateTo.Value)
            {
                query += " and date(Timestamp) between @startDate and @endDate";
                parameters.Add(new MySqlParameter("@startDate", dtpAuditLogDateFrom.Value.Date));
                parameters.Add(new MySqlParameter("@endDate", dtpAuditLogDateTo.Value.Date));
            }
            dgAuditLog.DataSource = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }

        private void btnOpenAuditDetails_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgAuditLog.SelectedRows[0];
            string id = row.Cells["Log_ID"].Value.ToString();
            AuditDetailsPopUp auditDetailsPopUp = new AuditDetailsPopUp(id);
            auditDetailsPopUp.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadAuditLog();
        }

        private void cbxAuditLogActionFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAuditLog();
        }

        private void tbSearchUserFilter_TextChanged(object sender, EventArgs e)
        {
            loadAuditLog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearchUserFilter.Text = "Search user...";
            cbxAuditLogActionFilter.SelectedIndex = 0;
            dtpAuditLogDateFrom.Value = firstDay;
            dtpAuditLogDateTo.Value = lastDay;
        }
    }
}
