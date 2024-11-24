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
    public partial class FormSeeCostume : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormSeeCostume()
        {
            InitializeComponent();
        }

        private void FormSeeCostumes_Load(object sender, EventArgs e)
        {
            LoadCostumes();
            AddDeleteButtonColumn();
        }

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

                    dataGridCostumes.DataSource = dt;  // Assuming dataGridCostumes is the DataGridView for displaying costumes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading costumes: " + ex.Message);
            }
        }

        private void DeleteCostume(int rowIndex)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string referenceCode = dataGridCostumes.Rows[rowIndex].Cells["reference_code"].Value.ToString();
                    string query = "DELETE FROM costumes WHERE reference_code = @reference_code";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@reference_code", referenceCode);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Costume deleted successfully!");
                    LoadCostumes(); // Method to reload costumes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting costume: " + ex.Message);
            }
        }

        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Name = "btnDelete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dataGridCostumes.Columns.Add(btnDeleteColumn);
        }

        private void dataGridCostumes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridCostumes.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this costume?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteCostume(e.RowIndex);
                }
            }
        }

        private void btnAddCostume_Click(object sender, EventArgs e)
        {
            using (FormAddCostume formAddCostume = new FormAddCostume())
            {
                formAddCostume.ShowDialog();
                LoadCostumes(); // Method to reload costumes
            }
        }

        private void btnEditCostume_Click(object sender, EventArgs e)
        {
            using (FormEditCostume formEditCostume = new FormEditCostume())
            {
                formEditCostume.ShowDialog();
                LoadCostumes(); // Method to reload costumes
            }
        }

    }
}
