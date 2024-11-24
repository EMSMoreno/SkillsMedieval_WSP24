using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSN24_EduardoMoreno_M3.Events
{
    public partial class FormEditEvent : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        // Variable to store the current event's ID
        private int currentEventId = 0;

        public FormEditEvent()
        {
            InitializeComponent();
        }

        private void FormEditEvents_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        // Load the details of the selected event into the form fields
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
                            organizer_id, 
                            facebook_link, 
                            instagram_link, 
                            tiktok_link
                        FROM events";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridEditEvents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading events: " + ex.Message);
            }
        }

        // Handle the cell click to load event details into the form fields
        private void dataGridEditEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row clicked is valid
            {
                DataGridViewRow row = dataGridEditEvents.Rows[e.RowIndex];

                // Fill the form fields with the data from the selected row
                txtTitle.Text = row.Cells["title"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
                txtLocation.Text = row.Cells["location"].Value.ToString();
                txtFacebookLink.Text = row.Cells["facebook_link"].Value.ToString();
                txtInstagramLink.Text = row.Cells["instagram_link"].Value.ToString();
                txtTiktokLink.Text = row.Cells["tiktok_link"].Value.ToString();

                // Parse the start and end dates
                if (row.Cells["start_date"].Value != DBNull.Value)
                {
                    dtpStartDate.Value = Convert.ToDateTime(row.Cells["start_date"].Value);
                }

                if (row.Cells["end_date"].Value != DBNull.Value)
                {
                    dtpEndDate.Value = Convert.ToDateTime(row.Cells["end_date"].Value);
                }

                // Get the event_id directly from the clicked row
                currentEventId = Convert.ToInt32(row.Cells["event_id"].Value);
            }
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidUrl(txtFacebookLink.Text) || !IsValidUrl(txtInstagramLink.Text) || !IsValidUrl(txtTiktokLink.Text))
                {
                    MessageBox.Show("Please enter a valid URL (e.g., www.example.com or www.example.com/path).");
                    return;
                }

                // Ensure that we have selected a valid event to edit
                if (currentEventId == 0)
                {
                    MessageBox.Show("Please select an event to edit.");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // The update query to save changes to the event data
                    string query = @"
            UPDATE events
            SET 
                title = @Title, 
                description = @Description, 
                start_date = @StartDate, 
                end_date = @EndDate, 
                location = @Location, 
                facebook_link = @FacebookLink, 
                instagram_link = @InstagramLink, 
                tiktok_link = @TiktokLink
            WHERE event_id = @EventId";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Pass parameters to SQL command
                    cmd.Parameters.AddWithValue("@EventId", currentEventId);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@FacebookLink", txtFacebookLink.Text);
                    cmd.Parameters.AddWithValue("@InstagramLink", txtInstagramLink.Text);
                    cmd.Parameters.AddWithValue("@TiktokLink", txtTiktokLink.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event updated successfully!");
                    LoadEvents();  // Reload the events after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving event: " + ex.Message);
            }
        }

        // Clear the form fields
        private void CleanEditEventForm()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
            txtFacebookLink.Clear();
            txtInstagramLink.Clear();
            txtTiktokLink.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            currentEventId = 0; // Reset the current event ID
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanEditEventForm();
        }

        private bool IsValidUrl(string url) //Validations - Module 5
        {
            // Regex that allows URLs in the format www.link.com or www.link.com/path
            string pattern = @"^www\.[a-zA-Z0-9-]+\.[a-zA-Z]{2,6}(\.[a-zA-Z]{2,6})?(/.*)?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(url);
        }

    }
}
