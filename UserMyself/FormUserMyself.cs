using System.Configuration;
using System.Data.SqlClient;
using WinFormsApp1;
using WSN24_EduardoMoreno_M3.Rental;

namespace WSN24_EduardoMoreno_M3.UserMyself
{
    public partial class FormUserMyself : Form
    {
        private int _userId;

        public FormUserMyself(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void FormUserMyself_Load(object sender, EventArgs e)
        {
            LoadUserData(_userId);
        }

        private void LoadUserData(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT first_name, last_name, email, phone_number, address FROM Users WHERE user_id = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["first_name"].ToString();
                            txtLastName.Text = reader["last_name"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtPhoneNumber.Text = reader["phone_number"].ToString();
                            txtAddress.Text = reader["address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User data not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using (Dashboard formDashboard = new Dashboard(_userId))
            {
                formDashboard.ShowDialog();
            }
        }
    }
}
