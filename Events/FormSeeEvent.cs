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

namespace WSN24_EduardoMoreno_M3.Events
{
    public partial class FormSeeEvent : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormSeeEvent()
        {
            InitializeComponent();
        }

        private void FormSeeEvents_Load(object sender, EventArgs e)
        {
            LoadEvents();
            AddDeleteButtonColumn();
        }

        // Method to load all events from the database
        private void LoadEvents()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                    SELECT 
                        event_id, 
                        title, 
                        description, 
                        start_date, 
                        end_date, 
                        location, 
                        facebook_link, 
                        instagram_link, 
                        tiktok_link
                    FROM events";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridEvents.DataSource = dt;  // Assuming dataGridEvents is the DataGridView for displaying events
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading events: " + ex.Message);
            }
        }

        // Method to delete the selected event
        private void DeleteEvent(int rowIndex)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    int eventId = Convert.ToInt32(dataGridEvents.Rows[rowIndex].Cells["event_id"].Value);
                    string query = "DELETE FROM events WHERE event_id = @event_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@event_id", eventId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event deleted successfully!");
                    LoadEvents(); // Method to reload events
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting event: " + ex.Message);
            }
        }

        // Method to add a delete button column to the DataGridView
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Name = "btnDelete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dataGridEvents.Columns.Add(btnDeleteColumn);
        }

        // Event handler for cell click event (Delete button)
        private void dataGridEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridEvents.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this event?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteEvent(e.RowIndex);
                }
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            using (FormAddEvent formAddEvent = new FormAddEvent())
            {
                formAddEvent.ShowDialog();
                LoadEvents(); // Method to reload events
            }
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            using (FormEditEvent formEditEvent = new FormEditEvent())
            {
                formEditEvent.ShowDialog();
                LoadEvents(); // Method to reload events
            }
        }
    }
}
