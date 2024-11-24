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
    public partial class FormEditCostume : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        // Variable to store the image path selected by the user
        private string currentImagePath = null;

        public FormEditCostume()
        {
            InitializeComponent();
        }

        private void FormEditCostume_Load(object sender, EventArgs e)
        {
            LoadCostumes();
        }

        // Load the details of the selected costume into the form fields
        private void LoadCostumes()
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
                        FROM costumes";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridEditCostumes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading costumes: " + ex.Message);
            }
        }

        // Handle the cell click to load costume details into the form fields
        private void dataGridEditCostumes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row clicked is valid
            {
                DataGridViewRow row = dataGridEditCostumes.Rows[e.RowIndex];

                // Fill the form fields with the data from the selected row
                txtReferenceCode.Text = row.Cells["reference_code"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();

                // Check if the 'available_for_rent' cell is not DBNull before assigning it to the CheckBox
                if (row.Cells["available_for_rent"].Value != DBNull.Value)
                {
                    chkAvailableForRent.Checked = (bool)row.Cells["available_for_rent"].Value;
                }
                else
                {
                    chkAvailableForRent.Checked = false; // Default to false if the value is DBNull
                }

                txtRentalPrice.Text = row.Cells["rental_price"].Value.ToString();
                txtWarehouseID.Text = row.Cells["warehouse_id"].Value.ToString();

                // Handle image_path (if no image, set it as null or blank)
                string imagePath = row.Cells["image_path"].Value.ToString();
                if (string.IsNullOrEmpty(imagePath))
                {
                    lblImagePath.Text = "No image selected"; // Set to a label or blank if no image
                    imagePath = null; // Set image path to null if empty
                }
                else
                {
                    lblImagePath.Text = imagePath; // Display the image path or the filename
                }

                // Store the image path in the class variable
                currentImagePath = imagePath; // This will hold the current image path
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // Open a dialog to let the user select an image file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the image path (you can also display the image preview here if needed)
                    lblImagePath.Text = openFileDialog.FileName;  // Show the selected file path in a label
                    currentImagePath = openFileDialog.FileName;  // Store the selected image path
                }
            }
        }

        private void btnEditCostume_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the current image path or set it to null if no image selected
                string imagePathToSave = string.IsNullOrEmpty(currentImagePath) ? null : currentImagePath;

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // The update query to save changes to the costume data
                    string query = @"
                UPDATE costumes
                SET 
                    reference_code = @ReferenceCode, 
                    name = @Name, 
                    available_for_rent = @AvailableForRent, 
                    rental_price = @RentalPrice, 
                    warehouse_id = @WarehouseId, 
                    image_path = @ImagePath
                WHERE reference_code = @ReferenceCode";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Pass parameters to SQL command
                    cmd.Parameters.AddWithValue("@ReferenceCode", txtReferenceCode.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@AvailableForRent", chkAvailableForRent.Checked);
                    cmd.Parameters.AddWithValue("@RentalPrice", decimal.Parse(txtRentalPrice.Text)); // Ensure proper decimal handling
                    cmd.Parameters.AddWithValue("@WarehouseId", txtWarehouseID.Text);
                    cmd.Parameters.AddWithValue("@ImagePath", (object)imagePathToSave ?? DBNull.Value);  // Use null if no image

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Costume updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving costume: " + ex.Message);
            }
        }

        // Clear the form fields
        private void CleanEditCostumeForm()
        {
            txtReferenceCode.Clear();
            txtName.Clear();
            txtRentalPrice.Clear();
            txtWarehouseID.Clear();
            lblImagePath.Text = "No image selected"; // Reset image label
            chkAvailableForRent.Checked = false;
            currentImagePath = null; // Clear the stored image path
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanEditCostumeForm();
        }
    }
}
