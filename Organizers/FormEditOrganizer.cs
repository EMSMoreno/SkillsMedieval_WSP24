using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WSN24_EduardoMoreno_M3.Organizers
{
    public partial class FormEditOrganizer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormEditOrganizer()
        {
            InitializeComponent();
        }

        private void FormEditOrganizers_Load(object sender, EventArgs e)
        {
            LoadOrganizers();
        }

        private void LoadOrganizers()
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
                        FROM organizers";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridOrganizers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading organizers: " + ex.Message);
            }
        }

        // Handle the cell click to load organizer details into the form fields
        private void dataGridOrganizers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row clicked is valid
            {
                DataGridViewRow row = dataGridOrganizers.Rows[e.RowIndex];

                // Fill the form fields with the data from the selected row
                txtName.Text = row.Cells["name"].Value.ToString();
                txtLocality.Text = row.Cells["locality"].Value.ToString();
                txtTaxpayerNumber.Text = row.Cells["taxpayer_number"].Value.ToString();

                // Get the organizer_id directly from the clicked row
                int organizerId = Convert.ToInt32(row.Cells["organizer_id"].Value);

                // Enable the Edit button for the selected organizer
                btnEditOrganizer.Enabled = true;

                // Set the selected organizer's ID into a hidden field or use the value to handle editing
                btnEditOrganizer.Tag = organizerId;  // Storing the organizerId in the Tag property
            }
        }

        private void btnEditOrganizer_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditOrganizer.Tag == null)
                {
                    MessageBox.Show("Please select an organizer to edit.");
                    return;
                }

                // Get the organizer ID from the Tag property
                int organizerId = (int)btnEditOrganizer.Tag;

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // The update query to save changes to the organizer data
                    string query = @"
                        UPDATE organizers
                        SET 
                            name = @Name, 
                            locality = @Locality, 
                            taxpayer_number = @TaxpayerNumber
                        WHERE organizer_id = @OrganizerId";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Pass parameters to SQL command
                    cmd.Parameters.AddWithValue("@OrganizerId", organizerId);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Locality", txtLocality.Text);
                    cmd.Parameters.AddWithValue("@TaxpayerNumber", txtTaxpayerNumber.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Organizer updated successfully!");
                    LoadOrganizers();  // Reload the organizers after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving organizer: " + ex.Message);
            }
        }

        // Clear the form fields
        private void CleanEditOrganizerForm()
        {
            txtName.Clear();
            txtLocality.Clear();
            txtTaxpayerNumber.Clear();
            btnEditOrganizer.Enabled = false; // Disable the Edit button until an organizer is selected
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanEditOrganizerForm();
        }
    }
}
