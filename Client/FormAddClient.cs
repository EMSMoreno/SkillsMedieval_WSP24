using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WSN24_EduardoMoreno_M3.Cliente
{
    public partial class FormAddClient : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormAddClient()
        {
            InitializeComponent();
        }

        private void SearchClients(string criterio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(criterio))
                {
                    MessageBox.Show("Please enter a search criteria.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    client_id, 
                    first_name, 
                    last_name, 
                    taxpayer_number, 
                    address, 
                    email, 
                    phone_number, 
                    state, 
                    registration_date 
                FROM clients 
                WHERE 
                    first_name LIKE @Criterio 
                    OR last_name LIKE @Criterio
                    OR taxpayer_number LIKE @Criterio";

                    // Create SQL command
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Show results
                    dataGridSearchClients.DataSource = dt;

                    // Verify if user is found
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No clients found matching the provided criteria.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for clients: " + ex.Message);
            }
        }
        private void CleanSearchClientForm()
        {
            txtSearch.Clear();
            dataGridSearchClients.DataSource = null;
        }

        private void CleanAddClientForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTaxPayer.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtState.Clear();
            dtpRegistrationDate.Value = DateTime.Now;
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanAddClientForm();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtTaxPayer.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                // Email format validation
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Check if the NIF number already exists
                    string checkCpfQuery = "SELECT COUNT(*) FROM clients WHERE taxpayer_number = @TaxpayerNumber";
                    SqlCommand checkCpfCmd = new SqlCommand(checkCpfQuery, con);
                    checkCpfCmd.Parameters.AddWithValue("@TaxpayerNumber", txtTaxPayer.Text);

                    int cpfCount = (int)checkCpfCmd.ExecuteScalar();
                    if (cpfCount > 0)
                    {
                        MessageBox.Show("There is already a client with that Tax Payer Number (NIF). Please try again with a different one.");
                        return;
                    }

                    // Check if the email is already registered
                    string checkEmailQuery = "SELECT COUNT(*) FROM clients WHERE email = @Email";
                    SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con);
                    checkEmailCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    int emailCount = (int)checkEmailCmd.ExecuteScalar();
                    if (emailCount > 0)
                    {
                        MessageBox.Show("This email is already registered. Please try with a different email.");
                        return;
                    }

                    string query = @"
                    INSERT INTO clients
                    (first_name, last_name, taxpayer_number, address, email, phone_number, state, registration_date)
                    VALUES
                    (@FirstName, @LastName, @TaxpayerNumber, @Address, @Email, @PhoneNumber, @State, @RegistrationDate)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@TaxpayerNumber", txtTaxPayer.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@State", "Active");
                    cmd.Parameters.AddWithValue("@RegistrationDate", dtpRegistrationDate.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client added successfully!");

                    CleanAddClientForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding client: " + ex.ToString());
            }
        }

        private void btnCleanFormSearch_Click(object sender, EventArgs e)
        {
            CleanSearchClientForm();

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            // Get the value entered into the search field and remove extra whitespace
            string criteria = txtSearch.Text.Trim();

            // Check that the destination is not empty
            if (string.IsNullOrWhiteSpace(criteria))
            {
                // If empty, display a message to the user
                MessageBox.Show("Please enter a search criteria.");
                return; // Stops method execution
            }

            // Call the search method going through the selections
            SearchClients(criteria);
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, emailPattern);
        } //Validations - Module 5

    }
}
