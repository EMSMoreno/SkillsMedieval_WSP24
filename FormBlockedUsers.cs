using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WSN24_EduardoMoreno_M3
{
    public partial class FormBlockedUsers : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        public FormBlockedUsers()
        {
            InitializeComponent();
        }

        private void FormLoadBlockedUsers_Load(object sender, EventArgs e)
        {
            LoadBlockedUsers();
        }

        private void LoadBlockedUsers()
        {
            // SQL query to fetch users who are blocked (is_blocked = 1)
            string query = @"
            SELECT user_id, 
                   first_name, 
                   last_name, 
                   address, 
                   phone_number, 
                   email, 
                   role, 
                   registration_date, 
                   failed_login_attempts
            FROM users
            WHERE is_blocked = 1;";

            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    dataGridView7.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading blocked users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
