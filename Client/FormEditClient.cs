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

namespace WSN24_EduardoMoreno_M3.Cliente
{
    public partial class FormEditClient : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public FormEditClient()
        {
            InitializeComponent();
        }

        private void FormEditClients_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            try
            {
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
                FROM clients";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridEditClients.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Clients: " + ex.Message);
            }
        }

        private void CleanEditClientForm()
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

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if line is available
            {
                DataGridViewRow row = dataGridEditClients.Rows[e.RowIndex];

                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                txtTaxPayer.Text = row.Cells["taxpayer_number"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["phone_number"].Value.ToString();
                txtState.Text = row.Cells["state"].Value.ToString();
                dtpRegistrationDate.Value = Convert.ToDateTime(row.Cells["registration_date"].Value);

                // O client_id é obtido diretamente da célula
                btnEditClient.Tag = row.Cells["client_id"].Value.ToString(); // Get the Client ID directly
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                string clientId = btnEditClient.Tag?.ToString();

                if (string.IsNullOrEmpty(clientId))
                {
                    MessageBox.Show("Por favor, selecione um cliente para editar.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Query do edit data from database
                    string query = @"
                        UPDATE clients
                        SET 
                            first_name = @FirstName, 
                            last_name = @LastName, 
                            taxpayer_number = @TaxpayerNumber, 
                            address = @Address, 
                            email = @Email, 
                            phone_number = @PhoneNumber, 
                            state = @State, 
                            registration_date = @RegistrationDate
                        WHERE client_id = @ClientId";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Pass parameteres to SQL command
                    cmd.Parameters.AddWithValue("@ClientId", clientId);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@TaxpayerNumber", txtTaxPayer.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@State", txtState.Text);
                    cmd.Parameters.AddWithValue("@RegistrationDate", dtpRegistrationDate.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client edit sucessfully!");
                    LoadClients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while editing client: " + ex.Message);
            }
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanEditClientForm();
        }
    }
}
