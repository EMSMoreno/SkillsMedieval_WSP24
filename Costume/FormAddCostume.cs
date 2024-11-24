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

namespace WSN24_EduardoMoreno_M3.Costume
{
    public partial class FormAddCostume : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        string imagePath = "";

        public FormAddCostume()
        {
            InitializeComponent();
        }

        private void SearchCostumes(string criterion)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    reference_code, 
                    name, 
                    available_for_rent, 
                    rental_price, 
                    warehouse_id, 
                    image_path 
                FROM costumes 
                WHERE 
                    reference_code LIKE @Criterion 
                    OR name LIKE @Criterion 
                    OR rental_price LIKE @Criterion";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criterion", "%" + criterion + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridSearchCostumes.DataSource = dt;  // Assuming dataGridSearchCostumes is the DataGridView for displaying costumes

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("There is no costume with the parameters you submitted. Please try again!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for the costume: " + ex.Message);
            }
        }

        private void CleanSearchCostumeForm()
        {
            txtSearch.Clear();  // Assuming txtSearch is the TextBox used for inputting search criteria
            dataGridSearchCostumes.DataSource = null;
        }

        private void CleanAddCostumeForm()
        {
            txtReferenceCode.Clear();
            txtName.Clear();
            txtRentalPrice.Clear();
            chkAvailableForRent.Checked = false;
            txtWarehouseID.Clear();
            pictureBox.Image = null;  // Clear the image preview
            imagePath = "";
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox.Image = new System.Drawing.Bitmap(imagePath);  // Show the image preview
            }
        }

        private void btnAddCostume_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtReferenceCode.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtRentalPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtWarehouseID.Text) ||
                    string.IsNullOrWhiteSpace(imagePath)) // Image path should not be empty
                {
                    MessageBox.Show("Please fill in all the required fields, including selecting an image.");
                    return;
                }

                decimal rentalPrice;
                if (!decimal.TryParse(txtRentalPrice.Text, out rentalPrice))
                {
                    MessageBox.Show("Invalid rental price format.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Check if reference_code already exists
                    string checkQuery = "SELECT COUNT(*) FROM costumes WHERE reference_code = @ReferenceCode";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@ReferenceCode", txtReferenceCode.Text);

                    int referenceCount = (int)checkCmd.ExecuteScalar();
                    if (referenceCount > 0)
                    {
                        MessageBox.Show("A costume with this reference code already exists.");
                        return;
                    }

                    string query = @"
                        INSERT INTO costumes
                        (reference_code, name, available_for_rent, rental_price, warehouse_id, image_path)
                        VALUES
                        (@ReferenceCode, @Name, @AvailableForRent, @RentalPrice, @WarehouseID, @ImagePath)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ReferenceCode", txtReferenceCode.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@AvailableForRent", chkAvailableForRent.Checked); // 1 for checked, 0 for unchecked
                    cmd.Parameters.AddWithValue("@RentalPrice", rentalPrice);
                    cmd.Parameters.AddWithValue("@WarehouseID", txtWarehouseID.Text);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath); // Save the image path in the database

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Costume added successfully!");

                    CleanAddCostumeForm(); // Method to clear the form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding costume: " + ex.Message);
            }
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanAddCostumeForm();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            string searchCriteria = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchCriteria))
            {
                MessageBox.Show("Please enter a search criterion and try again!");
                CleanSearchCostumeForm();
                return;
            }

            SearchCostumes(searchCriteria);
        }

        private void btnCleanFormSearch_Click(object sender, EventArgs e)
        {
            CleanSearchCostumeForm();
        }
    }
}
