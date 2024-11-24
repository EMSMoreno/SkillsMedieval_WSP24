using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WSN24_EduardoMoreno_M3.Organizers
{
    public partial class FormAddOrganizer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        public FormAddOrganizer()
        {
            InitializeComponent();
        }

        private void CleanAddOrganizerForm()
        {
            txtName.Clear();
            txtLocality.Clear();
            txtTaxpayerNumber.Clear();
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanAddOrganizerForm();
        }

        private void btnAddOrganizer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtTaxpayerNumber.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Verify if TaxPayer Number / NIF exists
                    string checkCpfQuery = "SELECT COUNT(*) FROM organizers WHERE taxpayer_number = @TaxpayerNumber";
                    SqlCommand checkCpfCmd = new SqlCommand(checkCpfQuery, con);
                    checkCpfCmd.Parameters.AddWithValue("@TaxpayerNumber", txtTaxpayerNumber.Text);

                    int cpfCount = (int)checkCpfCmd.ExecuteScalar();
                    if (cpfCount > 0)
                    {
                        MessageBox.Show("There is already an organizer with that Tax Payer Number (NIF). Please try again with a different one.");
                        return;
                    }

                    // Query do add new organizer
                    string query = @"
                        INSERT INTO organizers (name, locality, taxpayer_number)
                        VALUES (@Name, @Locality, @TaxpayerNumber)";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Locality", string.IsNullOrWhiteSpace(txtLocality.Text) ? DBNull.Value : (object)txtLocality.Text);
                    cmd.Parameters.AddWithValue("@TaxpayerNumber", txtTaxpayerNumber.Text);

                    // Executar a query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Organizer added successfully!");

                    CleanAddOrganizerForm(); // Call method to clean form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding organizer: " + ex.Message);
            }
        }

        private void CleanSearchOrganizerForm()
        {
            txtSearchOrganizer.Clear();
            dataGridSearchOrganizers.DataSource = null;
        }

        private void SearchOrganizers(string criterio)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    organizer_id, 
                    name, 
                    locality, 
                    taxpayer_number 
                FROM organizers 
                WHERE 
                    name LIKE @Criterio 
                    OR taxpayer_number LIKE @Criterio";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridSearchOrganizers.DataSource = dt;

                    // Verify if organizers is found
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No organizers found with the given search criteria.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for organizers: " + ex.Message);
            }
        }

        private void btnCleanFormSearch_Click(object sender, EventArgs e)
        {
            CleanSearchOrganizerForm();
        }

        private void btnSearchOrganizer_Click(object sender, EventArgs e)
        {
            string criterio = txtSearchOrganizer.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Please enter a search criterion.");
                return;
            }

            SearchOrganizers(criterio);
        }
    }
}
