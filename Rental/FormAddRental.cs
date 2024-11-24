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
using WinFormsApp1;

namespace WSN24_EduardoMoreno_M3.Rental
{
    public partial class FormAddRental : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormAddRental()
        {
            InitializeComponent();
        }

        // Method to load rentals data from the database into the DataGridView
        private void FormAddRental_Load(object sender, EventArgs e)
        {
            LoadRentals();
            LoadCostumes();
            // Add status options to ComboBox
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Not Returned");

            // Set default selected item for the ComboBox
            cmbStatus.SelectedIndex = 0; // Default to "In Progress"
        }

        // Method to clear the form fields
        private void CleanAddRentalForm()
        {
            dtpRentalDate.Value = DateTime.Now;  // Reset rental date to current date
            dtpReturnDate.Value = DateTime.Now;  // Reset return date to current date
            cmbStatus.SelectedIndex = 0;         // Reset status to "In Progress"
        }

        private void LoadCostumes()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT costume_id, name FROM costumes WHERE available_for_rent = 1";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCostume.DisplayMember = "name";      // Nome do traje
                    cmbCostume.ValueMember = "costume_id";  // ID do traje
                    cmbCostume.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading costumes: " + ex.Message);
            }
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

                    dataGridSearchRentals.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading rentals: " + ex.Message);
            }
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpRentalDate.Value == DateTime.MinValue || string.IsNullOrEmpty(cmbStatus.SelectedItem.ToString()) || cmbCostume.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                // Obter o costume_id diretamente do SelectedValue
                int costumeId = (int)cmbCostume.SelectedValue;

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Insert rental details into the 'rentals' table
                    string query = @"
                INSERT INTO rentals 
                (costume_id, rental_date, return_date, status)
                VALUES
                (@CostumeId, @RentalDate, @ReturnDate, @Status)";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CostumeId", costumeId);
                    cmd.Parameters.AddWithValue("@RentalDate", dtpRentalDate.Value);
                    cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Rental added successfully!");

                    CleanAddRentalForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding rental: " + ex.Message);
            }

            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.UpdateCostumeCounts();
                dashboard.Refresh();
            }
        }

        // Method to get the rental price of a costume based on costume_id
        private decimal GetRentalPriceForCostume(int costumeId)
        {
            decimal rentalPrice = 0;

            string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
            string query = @"
                SELECT rental_price
                FROM costumes
                WHERE costume_id = @CostumeId";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CostumeId", costumeId);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        rentalPrice = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error when Retrieving Rental Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return rentalPrice;
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanAddRentalForm();
        }

        private void SearchRentals(string criterio)
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
            FROM rentals
            WHERE 
                CAST(rental_date AS VARCHAR) LIKE @Criterio 
                OR CAST(return_date AS VARCHAR) LIKE @Criterio 
                OR status LIKE @Criterio";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridSearchRentals.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No rentals found with the given search criteria.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for rentals: " + ex.Message);
            }
        }

        private void btnSearchOrganizer_Click(object sender, EventArgs e)
        {
            string criterio = txtSearchRental.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Please enter a search criterion.");
                return;
            }

            SearchRentals(criterio);
        }

        private void CleanSearchRentalForm()
        {
            txtSearchRental.Clear();
            dataGridSearchRentals.DataSource = null;
        }

        private void btnCleanFormSearch_Click(object sender, EventArgs e)
        {
            CleanSearchRentalForm();
        }
    }
}

