using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WSN24_EduardoMoreno_M3.Users
{
    public partial class FormAddUser : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void CleanAddUserForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtRole.Clear();
            dtpRegistrationDate.Value = DateTime.Now;
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanAddUserForm();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtRole.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Verify if email exists
                    string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";
                    SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con);
                    checkEmailCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    int emailCount = (int)checkEmailCmd.ExecuteScalar();
                    if (emailCount > 0)
                    {
                        MessageBox.Show("There is already a user with that email. Please try again with a different one.");
                        return;
                    }

                    string query = @"
                    INSERT INTO users
                    (first_name, last_name, address, email, phone_number, role, registration_date)
                    VALUES
                    (@FirstName, @LastName, @Address, @Email, @PhoneNumber, @Role, @RegistrationDate)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                    cmd.Parameters.AddWithValue("@RegistrationDate", dtpRegistrationDate.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!");

                    CleanAddUserForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding user: " + ex.ToString());
            }
        }

        private void SearchUsers(string criterio)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                    SELECT 
                        user_id, 
                        first_name, 
                        last_name, 
                        address, 
                        email, 
                        phone_number, 
                        role, 
                        registration_date
                    FROM users
                    WHERE 
                        first_name LIKE @Criterio 
                        OR last_name LIKE @Criterio 
                        OR email LIKE @Criterio 
                        OR phone_number LIKE @Criterio";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the result to the DataGridView
                    dataGridSearchUsers.DataSource = dt;

                    // Show message if no users are found
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No users found with the given search criteria.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for users: " + ex.Message);
            }
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            string criterio = txtSearchUser.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Please enter a search criterion.");
                return;
            }

            SearchUsers(criterio);
        }

        private void CleanSearchUserForm()
        {
            txtSearchUser.Clear();
            dataGridSearchUsers.DataSource = null;
        }

        private void btnCleanFormSearch_Click(object sender, EventArgs e)
        {
            CleanSearchUserForm();
        }
    }
}
