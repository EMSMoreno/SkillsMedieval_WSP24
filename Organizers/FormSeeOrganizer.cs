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

namespace WSN24_EduardoMoreno_M3.Organizers
{
    public partial class FormSeeOrganizer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormSeeOrganizer()
        {
            InitializeComponent();
        }

        private void FormSeeOrganizer_Load(object sender, EventArgs e)
        {
            LoadOrganizers();
            AddDeleteButtonColumn();
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

        // Method to deleted seected organizer
        private void DeleteOrganizer(int rowIndex)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    int organizerId = Convert.ToInt32(dataGridOrganizers.Rows[rowIndex].Cells["organizer_id"].Value);
                    string query = "DELETE FROM organizers WHERE organizer_id = @organizer_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@organizer_id", organizerId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Organizer deleted successfully!");
                    LoadOrganizers(); // Method to load organizers
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting organizer: " + ex.Message);
            }
        }

        // Add delete button column to table
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Name = "btnDelete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dataGridOrganizers.Columns.Add(btnDeleteColumn);
        }

        // Cell click event (to delete organizers)
        private void dataGridOrganizers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridOrganizers.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this organizer?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteOrganizer(e.RowIndex);
                }
            }
        }

        private void btnAddOrganizer_Click(object sender, EventArgs e)
        {
            using (FormAddOrganizer formAddOrganizer = new FormAddOrganizer())
            {
                formAddOrganizer.ShowDialog();
                LoadOrganizers();
            }
        }

        private void btnEditOrganizer_Click(object sender, EventArgs e)
        {
            using (FormEditOrganizer formEditOrganizer = new FormEditOrganizer())
            {
                formEditOrganizer.ShowDialog();
                LoadOrganizers();
            }
        }
    }
}
