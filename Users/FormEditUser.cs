using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSN24_EduardoMoreno_M3.Users
{
    public partial class FormEditUser : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormEditUser()
        {
            InitializeComponent();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
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
                        phone_number, 
                        email, 
                        role, 
                        registration_date
                    FROM users";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridUsers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading users: " + ex.Message);
            }
        }

        private void CleanEditUserForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtRole.Clear();
            dtpRegistrationDate.Value = DateTime.Now;
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if the row is valid
            {
                DataGridViewRow row = dataGridUsers.Rows[e.RowIndex];

                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["phone_number"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtRole.Text = row.Cells["role"].Value.ToString();
                dtpRegistrationDate.Value = Convert.ToDateTime(row.Cells["registration_date"].Value);

                // Store the user_id in the button tag to identify the selected user
                btnEditUser.Tag = row.Cells["user_id"].Value.ToString(); // Get the User ID directly
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = btnEditUser.Tag?.ToString();

                if (string.IsNullOrEmpty(userId))
                {
                    MessageBox.Show("Please select a user to edit.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // SQL query to update user data
                    string query = @"
                    UPDATE users
                    SET 
                        first_name = @FirstName, 
                        last_name = @LastName, 
                        address = @Address, 
                        phone_number = @PhoneNumber, 
                        email = @Email, 
                        role = @Role, 
                        registration_date = @RegistrationDate
                    WHERE user_id = @UserId";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Pass parameters to SQL command
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                    cmd.Parameters.AddWithValue("@RegistrationDate", dtpRegistrationDate.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User updated successfully!");
                    LoadUsers(); // Reload users after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while editing user: " + ex.Message);
            }
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanEditUserForm();
        }
    }
}
