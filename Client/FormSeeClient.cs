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
    public partial class FormSeeClient : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormSeeClient()
        {
            InitializeComponent();
        }

        private void FormVerClientes_Load(object sender, EventArgs e)
        {
            LoadClients();
            AddDeleteButtonColumn();
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

                    dataGridClients.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Clients: " + ex.Message);
            }
        }

        private void DeleteClient(int rowIndex)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    int clientId = Convert.ToInt32(dataGridClients.Rows[rowIndex].Cells["client_id"].Value);
                    string query = "DELETE FROM clients WHERE client_id = @client_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@client_id", clientId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client deleted sucessfully!");
                    LoadClients(); // Method to reload clients
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar o cliente: " + ex.Message);
            }
        }

        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Name = "btnDelete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dataGridClients.Columns.Add(btnDeleteColumn);
        }

        private void dataGridClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridClients.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this client?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteClient(e.RowIndex);
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (FormAddClient formAddClient = new FormAddClient())
            {
                formAddClient.ShowDialog();
                LoadClients(); // Method to reload clients
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            using (FormEditClient formEditClient = new FormEditClient())
            {
                formEditClient.ShowDialog();
                LoadClients(); // Method to reload clients
            }
        }
    }
}
