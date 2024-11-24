using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WSN24_EduardoMoreno_M3;
using WSN24_EduardoMoreno_M3.Cliente;
using WSN24_EduardoMoreno_M3.Costume;
using WSN24_EduardoMoreno_M3.Events;
using WSN24_EduardoMoreno_M3.Organizers;
using WSN24_EduardoMoreno_M3.Rental;
using WSN24_EduardoMoreno_M3.UserMyself;
using WSN24_EduardoMoreno_M3.Users;
using WSN24_EduardoMoreno_M3.Warehouse;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        private int loggedUserId;
        private int userId;
        private FormSeeRental formSeeRental; // Module 6

        string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Dashboard(int userId)
        {
            InitializeComponent();
            loggedUserId = userId;
            this.userId = userId;

            formSeeRental = new FormSeeRental();
            formSeeRental.RentalDataChanged += FormSeeRental_RentalDataChanged;

            SetReportsButtonState(CurrentUser.Role == "Admin");
            SetBlockedUsersButtonState(CurrentUser.Role == "Admin");
        }

        public void SetReportsButtonState(bool isEnabled) // Module 6
        {
            btnReports.Enabled = isEnabled;
        }

        public void SetBlockedUsersButtonState(bool isEnabled) // Module 6
        {
            btnBlockedUsersAdmin.Enabled = isEnabled;
        }


        private bool isUpdating = false;

        private void FormSeeRental_RentalDataChanged(object sender, EventArgs e)
        {
            // Avoid recursive update
            if (isUpdating)
                return;

            try
            {
                isUpdating = true;

                UpdateActiveRentedCostumesCount();
                UpdateTotalRentedCostumesCount();
                UpdateTotalRegisteredCostumesCount();
                UpdateTotalRentedCurrentYear();
            }
            finally
            {
                isUpdating = false;
            }
        }

        // Method for updating total rent for the current year
        private void UpdateTotalRentedCurrentYear()
        {
            decimal totalAnoAtual = GetTotalAlugueisAnoAtual();
            lblTotalAlugueisAnoAtual.Text = $"Total Rental Amount for {DateTime.Now.Year}: {totalAnoAtual:C2}";
        }

        // Method that returns the total rent for the current year
        private decimal GetTotalAlugueisAnoAtual()
        {
            decimal total = 0;
            string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            string query = @"
                SELECT SUM(ISNULL(r.rental_price, 0))  -- Usa 0 caso rental_price seja NULL
                FROM rentals r
                WHERE YEAR(r.rental_date) = YEAR(GETDATE()) 
                  AND r.status = 'Completed';
            ";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error when Searching for Rental Amounts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return total;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateActiveRentedCostumesCount();
            UpdateTotalRentedCostumesCount();
            UpdateTotalRegisteredCostumesCount();
            UpdateTotalRentedCurrentYear();
            LoadRecentClients();
            LoadRentalData();
            LoadClientsNotUsers();
        }

        // Method to update all costume counts
        public void UpdateCostumeCounts()
        {
            UpdateActiveRentedCostumesCount();
            UpdateTotalRentedCostumesCount();
            UpdateTotalRegisteredCostumesCount();
            UpdateTotalRentedCurrentYear();
        }

        // Method to update total active outfits (active rentals)
        private void UpdateActiveRentedCostumesCount()
        {
            if (isUpdating) return; // Impede chamadas recursivas durante a atualização

            try
            {
                isUpdating = true;
                int totalAlugueisAtivos = GetTotalAlugueisAtivos();
                lblActiveRentedCostumes.Text = $"Active Rented Costumes: {totalAlugueisAtivos}";
            }
            finally
            {
                isUpdating = false;
            }
        }

        // Method to update total rental outfits
        private void UpdateTotalRentedCostumesCount()
        {
            if (isUpdating) return; // Impede chamadas recursivas durante a atualização

            try
            {
                isUpdating = true;
                int totalTrajesAlugados = GetTotalTrajesAlugados();
                lblTotalRentedCostumes.Text = $"Total Rented Costumes: {totalTrajesAlugados}";
            }
            finally
            {
                isUpdating = false;
            }
        }

        // Method to update total registered outfits
        private void UpdateTotalRegisteredCostumesCount()
        {
            if (isUpdating) return; // Impede chamadas recursivas durante a atualização

            try
            {
                isUpdating = true;
                int totalTrajesRegistrados = GetTotalTrajesRegistrados();
                lblTotalRegisteredCostumes.Text = $"Total Registered Costumes: {totalTrajesRegistrados}";
            }
            finally
            {
                isUpdating = false;
            }
        }

        // Method to obtain total active rentals ('In Progress' status)
        private int GetTotalAlugueisAtivos()
        {
            int total = 0;
            string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            string query = @"
                SELECT COUNT(*) 
                FROM rentals 
                WHERE status = 'In Progress' 
                  AND (return_date IS NULL OR return_date > GETDATE() OR DATEDIFF(MINUTE, rental_date, return_date) > 0);
            ";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    total = (int)command.ExecuteScalar();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error when Searching for Active Rentals", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General Error: {ex.Message}", "Error when Searching for Active Rentals", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return total;
        }

        // Method to get the total of rented costumes
        private int GetTotalTrajesAlugados()
        {
            int total = 0;
            string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            string query = @"
                SELECT COUNT(*) 
                FROM rentals 
                WHERE status = 'Completed';
            ";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    total = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error when Searching for Rented Costumes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return total;
        }

        // Method to obtain the total registered outfits
        private int GetTotalTrajesRegistrados()
        {
            int total = 0;
            string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            string query = "SELECT COUNT(*) FROM costumes;";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    total = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error when Searching for Total Registered Costumes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return total;
        }

        // Method to ensure all counts are updated when necessary
        public void RefreshCostumeCounts()
        {
            UpdateActiveRentedCostumesCount();
            UpdateTotalRentedCostumesCount();
            UpdateTotalRegisteredCostumesCount();
            UpdateTotalRentedCurrentYear();
        }

        // Method to load the last 5 registered clients
        private void LoadRecentClients()
        {
            string cs = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            string query = @"
                SELECT TOP 5 
                    c.first_name AS FirstName,
                    c.last_name AS LastName,
                    c.email AS ClientEmail,
                    c.phone_number AS ClientPhone,
                    c.address AS ClientAddress,
                    c.taxpayer_number AS ClientNIF
                FROM clients c
                ORDER BY c.registration_date DESC;
            ";

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while loading last 5 users to the system: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadRentalData()
        {
            // SQL query to get the latest 10 rentals with costume information
            string query = @"
                 SELECT TOP 10 
                     r.rental_id, 
                     r.rental_date, 
                     r.return_date, 
                     r.costume_id,  -- Agora a coluna costume_id existe em rentals
                     c.reference_code, 
                     c.name AS costume_name
                 FROM rentals r
                 JOIN costumes c ON r.costume_id = c.costume_id  -- Relacionamento correto entre rentals e costumes
                 ORDER BY r.rental_date DESC;
            ";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cs))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;
            }
        }

        private void LoadClientsNotUsers()
        {

            string query = @"
                SELECT 
                    c.first_name + ' ' + c.last_name AS full_name, 
                    c.email, 
                    c.phone_number
                FROM clients c
                LEFT JOIN users u ON c.client_id = u.user_id
                WHERE u.user_id IS NULL;";

            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView3.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Clients that are not Users: " + ex.Message);
            }
        }

        #region Menus
        private void button1_Click(object sender, EventArgs e)
        {
            using (FormSeeClient formVerCliente = new FormSeeClient())
            { formVerCliente.ShowDialog(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FormSeeCostume formSeeCostume = new FormSeeCostume())
            { formSeeCostume.ShowDialog(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FormSeeEvent formSeeEvent = new FormSeeEvent())
            { formSeeEvent.ShowDialog(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FormSeeOrganizer formSeeOrganizer = new FormSeeOrganizer())
            { formSeeOrganizer.ShowDialog(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (FormSeeRental formSeeRental = new FormSeeRental())
            { formSeeRental.ShowDialog(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (FormSeeWarehouse formSeeWarehouse = new FormSeeWarehouse())
            { formSeeWarehouse.ShowDialog(); }
        }

        // Users, Myself & Logs
        private void button7_Click(object sender, EventArgs e)
        {
            using (FormSeeUser formSeeUser = new FormSeeUser(loggedUserId))
            {
                formSeeUser.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (FormUserMyself formUserMyself = new FormUserMyself(userId))
            { formUserMyself.ShowDialog(); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (FormLogs formLogs = new FormLogs())
            { formLogs.ShowDialog(); }
        }

        #endregion

        #region Logout Button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.userId = 0;
            this.Close();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
        #endregion

        #region Reports & Blocked Users (Module 6)

        public static class CurrentUser
        {
            public static string Role { get; set; }
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "Admin")
            {
                using (FormReports formReports = new FormReports())
                {
                    formReports.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You do not have the necessary permissions to access this form, the King don't allow you!.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBlockedUsersAdmin_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "Admin")
            {
                using (FormBlockedUsers formBlockedUsers = new FormBlockedUsers())
                {
                    formBlockedUsers.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You do not have the necessary permissions to access this form, the King don't allow you!.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
