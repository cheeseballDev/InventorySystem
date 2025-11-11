using InventorySystem.Helper_Classes;
using iTextSharp.text.pdf.parser;
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
            string query = "select Log_ID, User_ID, Action, Module, Timestamp from auditlogtable where 1=1 ";
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (!tbSearchUserFilter.Text.Equals("Search user...") && !string.IsNullOrEmpty(tbSearchUserFilter.Text)) 
            {
                query += " and User_ID like @user";
                parameters.Add(new MySqlParameter("@user", "%" + tbSearchUserFilter.Text + "%"));
            }
            if (cbxAuditLogActionFilter.SelectedIndex != -1)
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
            AuditDetailsPopUp auditDetailsPopUp = new AuditDetailsPopUp();
            auditDetailsPopUp.ShowDialog();
        }
    }
}
