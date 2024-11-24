using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WSN24_EduardoMoreno_M3
{
    public partial class FormRecoverAccount : Form
    {
        private string generatedPin;

        public FormRecoverAccount()
        {
            InitializeComponent();
        }

        private void FormRecoverAccount_Load(object sender, EventArgs e)
        {
            // Generate a random 4-digit PIN
            Random rand = new Random();
            generatedPin = rand.Next(1000, 9999).ToString();
            txtPIN.Text = generatedPin;  // Displays the PIN in the textRandomPin textbox (read only)
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter your email and a new password.");
                return;
            }

            // Atualizar a senha no banco de dados
            if (UpdatePasswordInDatabase(email, newPassword))
            {
                MessageBox.Show("Password changed successfully!");
                this.Close();

                // Open FormLogin for the user to enter new data
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
            else
            {
                MessageBox.Show("Error changing password.");
            }
        }

        private bool UpdatePasswordInDatabase(string email, string newPassword)
        {
            string hashedPassword = HashPassword(newPassword);

            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Users SET password = @Password, failed_login_attempts = 0, is_locked = 0 WHERE email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
