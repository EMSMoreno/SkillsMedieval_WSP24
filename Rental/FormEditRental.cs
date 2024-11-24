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

namespace WSN24_EduardoMoreno_M3.Rental
{
    public partial class FormEditRental : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        // Variable to store the current rental's ID
        private int currentRentalId = 0;

        public FormEditRental()
        {
            InitializeComponent();
        }

        private void FormEditRental_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with the status options
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Not Returned");

            // Optionally select the first item if needed, or leave it blank
            cmbStatus.SelectedIndex = -1;

            LoadRentals();
        }

        private void LoadRentals()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                        SELECT 
                            rental_id, 
                            rental_date, 
                            return_date, 
                            status
                        FROM rentals";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridRentals.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading rentals: " + ex.Message);
            }
        }

        // Handle the cell click to load rental details into the form fields
        private void dataGridRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row clicked is valid
            {
                DataGridViewRow row = dataGridRentals.Rows[e.RowIndex];

                // Fill the form fields with the data from the selected row
                dtpRentalDate.Value = Convert.ToDateTime(row.Cells["rental_date"].Value);
                dtpReturnDate.Value = row.Cells["return_date"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["return_date"].Value)
                    : DateTime.Now;
                cmbStatus.SelectedItem = row.Cells["status"].Value.ToString();

                // Get the rental_id directly from the clicked row
                currentRentalId = Convert.ToInt32(row.Cells["rental_id"].Value);

                // Enable the Edit button for the selected rental
                btnEditRental.Enabled = true;
            }
        }

        private void btnEditRental_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRentalId == 0)
                {
                    MessageBox.Show("Please select a rental to edit.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // The update query to save changes to the rental data
                    string query = @"
                        UPDATE rentals
                        SET 
                            rental_date = @RentalDate, 
                            return_date = @ReturnDate, 
                            status = @Status
                        WHERE rental_id = @RentalId";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Pass parameters to SQL command
                    cmd.Parameters.AddWithValue("@RentalId", currentRentalId);
                    cmd.Parameters.AddWithValue("@RentalDate", dtpRentalDate.Value);
                    cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Rental updated successfully!");
                    LoadRentals();  // Reload the rentals after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving rental: " + ex.Message);
            }
        }

        // Clear the form fields
        private void CleanEditRentalForm()
        {
            dtpRentalDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
            btnEditRental.Enabled = false; // Disable the Edit button until a rental is selected
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanEditRentalForm();
        }
    }
}
