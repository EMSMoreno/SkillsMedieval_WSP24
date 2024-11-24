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
using WSN24_EduardoMoreno_M3.Organizers;

namespace WSN24_EduardoMoreno_M3.Rental
{
    public partial class FormSeeRental : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        // Declare Event on FormSeeRental to trigger on Dashboard
        public event EventHandler RentalDataChanged; // Validations - Module 6

        public FormSeeRental()
        {
            InitializeComponent();
        }

        private void FormSeeRental_Load(object sender, EventArgs e)
        {
            LoadRentals();
            AddDeleteButtonColumn();
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

        // Handle the cell click event to allow deleting rentals
        private void dataGridRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridRentals.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this rental?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteRental(e.RowIndex);
                }
            }
        }

        private void OnRentalDataChanged() // Validations - Module 6
        {
            RentalDataChanged?.Invoke(this, EventArgs.Empty);  // Trigger the event
        }

        // Method to delete a rental based on its rental_id
        private void DeleteRental(int rowIndex)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    int rentalId = Convert.ToInt32(dataGridRentals.Rows[rowIndex].Cells["rental_id"].Value);
                    string query = "DELETE FROM rentals WHERE rental_id = @RentalId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@RentalId", rentalId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Rental deleted successfully!");

                    // Recarrega as locações após a exclusão
                    LoadRentals();

                    // Dispara o evento para notificar outras partes do sistema
                    OnRentalDataChanged();

                    // Atualiza o Dashboard (exemplo: contagem de trajes alugados)
                    var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
                    if (dashboard != null)
                    {
                        dashboard.UpdateCostumeCounts();
                        dashboard.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting rental: " + ex.Message);
            }
        }

        // Method to add the "Delete" button column to the DataGridView
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Name = "btnDelete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dataGridRentals.Columns.Add(btnDeleteColumn);
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            using (FormAddRental formAddRental = new FormAddRental())
            {
                formAddRental.ShowDialog();
                LoadRentals();
            }
        }

        private void btnEditRental_Click(object sender, EventArgs e)
        {
            using (FormEditRental formEditRental = new FormEditRental())
            {
                formEditRental.ShowDialog();
                LoadRentals();
            }
        }
    }
}
