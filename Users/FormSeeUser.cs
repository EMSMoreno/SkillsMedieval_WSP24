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
    public partial class FormSeeUser : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        private int currentUserId; // Variable to store the current logged user ID
        private string currentUserRole; // Variable to store the current user's role

        public FormSeeUser(int userId)
        {
            InitializeComponent();
            currentUserId = userId; // Store the current user's ID
            LoadUserRole();
        }

        private void FormSeeUser_Load(object sender, EventArgs e)
        {
            LoadUsers();
            AddDeleteButtonColumn();
        }

        private void LoadUserRole()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT role FROM users WHERE user_id = @UserId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserId", currentUserId);

                    currentUserRole = cmd.ExecuteScalar()?.ToString();

                    // Disable the "Add User" button if the role is not Admin
                    if (currentUserRole != "Admin")
                    {
                        btnAddUser.Enabled = false; // Disable button if user is not Admin
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user role: " + ex.Message);
            }
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
                MessageBox.Show("Erro ao carregar os usuários: " + ex.Message);
            }
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridUsers.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteUser(e.RowIndex);
                }
            }
        }

        private void DeleteUser(int rowIndex)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    int userId = Convert.ToInt32(dataGridUsers.Rows[rowIndex].Cells["user_id"].Value);
                    string query = "DELETE FROM users WHERE user_id = @UserId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User deleted successfully!");
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o usuário: " + ex.Message);
            }
        }

        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Name = "btnDelete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dataGridUsers.Columns.Add(btnDeleteColumn);
        }

        // Validação tem que ser aqui para não ter acesso caso não seja "Admin"
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (currentUserRole == "Admin")
            {
                using (FormAddUser formAddUser = new FormAddUser())
                {
                    formAddUser.ShowDialog();
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to add users. Only Admin can perform this action.");
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            using (FormEditUser formEditUser = new FormEditUser())
            {
                formEditUser.ShowDialog();
                LoadUsers();
            }
        }
    }
}
