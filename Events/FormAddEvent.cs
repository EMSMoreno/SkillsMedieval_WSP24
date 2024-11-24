using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace WSN24_EduardoMoreno_M3.Events
{
    public partial class FormAddEvent : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormAddEvent()
        {
            InitializeComponent();
        }

        // Method to clean the Add Event form
        private void CleanAddEventForm()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
            txtOrganizer.Clear();
            txtFacebookLink.Clear();
            txtInstagramLink.Clear();
            txtTikTokLink.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            CleanAddEventForm();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtLocation.Text) ||
                    string.IsNullOrWhiteSpace(txtFacebookLink.Text) ||
                    string.IsNullOrWhiteSpace(txtInstagramLink.Text) ||
                    string.IsNullOrWhiteSpace(txtTikTokLink.Text) ||
                    string.IsNullOrWhiteSpace(txtOrganizer.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                // Validate Facebook, Instagram and TikTok URLs
                if (!IsValidUrl(txtFacebookLink.Text) ||
                    !IsValidUrl(txtInstagramLink.Text) ||
                    !IsValidUrl(txtTikTokLink.Text))
                {
                    MessageBox.Show("Please enter a valid URL (e.g., www.example.com or www.example.com/path).");
                    return;
                }

                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = @"
                INSERT INTO events 
                (title, description, start_date, end_date, location, facebook_link, instagram_link, tiktok_link)
                VALUES
                (@Title, @Description, @StartDate, @EndDate, @Location, @FacebookLink, @InstagramLink, @TikTokLink)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@FacebookLink", txtFacebookLink.Text);
                    cmd.Parameters.AddWithValue("@InstagramLink", txtInstagramLink.Text);
                    cmd.Parameters.AddWithValue("@TikTokLink", txtTikTokLink.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event added successfully!");

                    CleanAddEventForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding event: " + ex.Message);
            }
        }


        // Method to Search Events
        private void SearchEvents(string criteria)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Query para procurar eventos com base no critério
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
                        FROM events
                        WHERE 
                            title LIKE @Criteria OR
                            description LIKE @Criteria OR
                            location LIKE @Criteria";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criteria", "%" + criteria + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Exibe os resultados no DataGridView
                    dataGridSearchEvents.DataSource = dt;

                    // Caso não haja resultados
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No events found with the provided criteria.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for events: " + ex.Message);
            }
        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            string criteria = txtSearchEvent.Text.Trim();

            if (!string.IsNullOrWhiteSpace(criteria))
            {
                SearchEvents(criteria);  // Calls method to look for events
            }
            else
            {
                MessageBox.Show("Please enter a search criteria.");
            }
        }

        private void btnCleanFormSearch_Click(object sender, EventArgs e)
        {
            CleanSearchForm();
        }

        private void CleanSearchForm()
        {
            txtSearchEvent.Clear();
            dataGridSearchEvents.DataSource = null;
        }

        private bool IsValidUrl(string url)
        {
            // Regex to validate URLs with base domain and possible paths
            string pattern = @"^www\.[a-zA-Z0-9-]+\.[a-zA-Z]{2,6}(\.[a-zA-Z]{2,6})?(/.*)?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(url);
        } // Validations - Module 5


    }
}
