using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WSN24_EduardoMoreno_M3
{
    public partial class FormReports : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            LoadRentalCountByClient();
            LoadTop10MostRentedCostumes();
            LoadTop25SpendingClients();
        }

        private void LoadRentalCountByClient()
        {
            string query = @"
                SELECT 
                    c.taxpayer_number AS NIF,
                    c.first_name + ' ' + c.last_name AS full_name,
                    COUNT(r.rental_id) AS rental_count
                FROM clients c
                LEFT JOIN rentals r ON c.client_id = r.client_id
                GROUP BY c.client_id, c.first_name, c.last_name, c.taxpayer_number
                ORDER BY rental_count DESC;
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView4.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadTop10MostRentedCostumes()
        {
            string query = @"
                SELECT TOP 10
                    c.reference_code AS CostumeReference,
                    c.name AS CostumeName,
                    COUNT(r.rental_id) AS RentalCount
                FROM costumes c
                LEFT JOIN rentals r ON c.costume_id = r.costume_id
                GROUP BY c.costume_id, c.reference_code, c.name
                ORDER BY RentalCount DESC;
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    dataGridView5.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadTop25SpendingClients()
        {
            string query = @"
                SELECT TOP 25
                    c.first_name + ' ' + c.last_name AS full_name,
                    c.email,
                    c.taxpayer_number AS nif,
                    ISNULL(SUM(co.rental_price), 0) AS total_spent
                FROM clients c
                LEFT JOIN rentals r ON c.client_id = r.client_id
                LEFT JOIN costumes co ON r.costume_id = co.costume_id
                GROUP BY c.client_id, c.first_name, c.last_name, c.email, c.taxpayer_number
                ORDER BY total_spent DESC;
            ";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView6.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
