using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using WSN24_EduardoMoreno_M3;
using WSN24_EduardoMoreno_M3.UserMyself;
using static WinFormsApp1.Dashboard;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public class User
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        #region Password Methods

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        #endregion

        public FormLogin()
        {
            InitializeComponent();
        }

        #region Create User Methods

        private bool IsEmailRegistered(string email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0; // If count > 0, it means the email is already registered
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar email: " + ex.Message);
            }
            return false;
        } //Validations - Module 5

        private bool IsClientRegistered(string email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE email = @Email AND role = 'Client'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0; // If count > 0, it means that the email is already registered as a Client
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar se o client já está registrado: " + ex.Message);
            }
            return false;
        }//Validations - Module 5

        private bool IsValidEmail(string email) //Validations - Module 5
        {
            // Regular expression to validate email format
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, emailPattern);
        }


        private bool CreateUser(string email, string password)
        {
            // Creates password hash with SHA-256
            string hashedPassword = HashPassword(password);

            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Users (email, Password, failed_login_attempts, is_locked) VALUES (@Email, @Password, 0, 0)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating user: " + ex.Message);
                return false;
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword2.Text.Trim();

            // Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            // Email format validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Checks if the email is already registered (as a Client)
            if (IsClientRegistered(email))
            {
                MessageBox.Show("This email is already registered as a client. Please use a different email.");
                return;
            }

            // Checks if the email is already registered in general (User)
            if (IsEmailRegistered(email))
            {
                MessageBox.Show("This email is already registered as a user. Please use a different email.");
                return;
            }

            // Valida a senha
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain uppercase letters, lowercase letters, numbers, and special characters.");
                return;
            }

            string hashedPassword = HashPassword(password);

            string role = "Other";  // Default Role
            bool isLocked = false;
            int failedLoginAttempts = 0;

            if (AddUserToDatabase(firstName, lastName, email, hashedPassword, role, isLocked, failedLoginAttempts))
            {
                MessageBox.Show("User added successfully!");
                ClearFieldsCreateUser();
            }
            else
            {
                MessageBox.Show("Error adding user.");
            }
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(c => !char.IsLetterOrDigit(c));
        }

        private bool AddUserToDatabase(string firstName, string lastName, string email, string password, string role, bool isLocked, int failedLoginAttempts)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Users (first_name, last_name, email, password, role, is_locked, failed_login_attempts) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Password, @Role, @IsLocked, @FailedLoginAttempts)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@IsLocked", isLocked);
                        cmd.Parameters.AddWithValue("@FailedLoginAttempts", failedLoginAttempts);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        #endregion

        #region Login Methods

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fill all fields.");
                return;
            }

            int userId = 0;
            string role = "";

            if (LoginUser(email, password, ref userId, ref role))
            {
                CurrentUser.Role = role;

                MessageBox.Show("Login successfully! Welcome to EraMedieval4all!");
                this.Hide();
                ClearFieldsLoginUser();

                if (role == "Client")
                {
                    new FormUserMyself(userId).Show();
                }
                else
                {
                    Dashboard dashboardForm = new Dashboard(userId);
                    dashboardForm.Show();

                    if (role != "Admin")
                    {
                        dashboardForm.SetReportsButtonState(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or password invalid.");
            }
        }

        private bool LoginUser(string email, string password, ref int userId, ref string role)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT user_id, password, is_locked, failed_login_attempts, role FROM Users WHERE email = @Email";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userId = Convert.ToInt32(reader["user_id"]);
                        string storedPasswordHash = reader["password"].ToString();
                        bool isLocked = Convert.ToBoolean(reader["is_locked"]);
                        int failedLoginAttempts = Convert.ToInt32(reader["failed_login_attempts"]);
                        role = reader["role"].ToString();  // Obtém o role do usuário

                        // Se a conta estiver bloqueada
                        if (isLocked)
                        {
                            // Exibe mensagem e redireciona para a tela de bloqueio
                            MessageBox.Show("Your account is locked due to multiple failed login attempts.");
                            this.Hide();
                            new FormBlockedUser().ShowDialog();
                            return false;
                        }

                        // Verifica a senha informada com a senha armazenada (hash)
                        if (VerifyPasswordHash(password, storedPasswordHash))
                        {
                            // Se a senha estiver correta, reseta as tentativas falhas
                            ResetFailedLoginAttempts(email);
                            return true;
                        }
                        else
                        {
                            // Se a senha estiver errada, incrementa as tentativas falhas
                            IncrementFailedLoginAttempts(email, failedLoginAttempts);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or password invalid.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while logging in: " + ex.Message);
            }
            return false;
        }

        private bool VerifyPasswordHash(string enteredPassword, string storedPasswordHash)
        {
            string enteredPasswordHash = HashPassword(enteredPassword);
            return enteredPasswordHash == storedPasswordHash;
        }

        private void IncrementFailedLoginAttempts(string email, int failedLoginAttempts)
        {
            failedLoginAttempts++;

            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    bool isLocked = failedLoginAttempts >= 3;
                    string query = "UPDATE Users SET failed_login_attempts = @FailedLoginAttempts, is_locked = @IsLocked WHERE email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FailedLoginAttempts", failedLoginAttempts);
                        cmd.Parameters.AddWithValue("@IsLocked", isLocked);
                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ResetFailedLoginAttempts(string email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Users SET failed_login_attempts = 0 WHERE email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #endregion

        #region Clean Methods e Btns

        private void ClearFieldsCreateUser()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword2.Clear();
        }

        private void ClearFieldsLoginUser()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnCleanFormCreate_Click(object sender, EventArgs e)
        {
            ClearFieldsCreateUser();
        }

        private void btnClearFormLogin_Click(object sender, EventArgs e)
        {
            ClearFieldsLoginUser();
        }

        #endregion
    }
}
