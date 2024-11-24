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

namespace WSN24_EduardoMoreno_M3
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
        }

        private void FormLogs_Load(object sender, EventArgs e)
        {
            LoadUserLogs();
        }

        // Load login and logout logs into the table
        private void LoadUserLogs()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT L.id, L.hourLogin, L.hourLogout, U.email AS UserEmail " +
                                   "FROM Login L " +
                                   "INNER JOIN Users U ON L.user_id = U.id " +
                                   "ORDER BY L.hourLogin DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridViewLogs.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar logs: " + ex.Message);
            }
        }

        private void LogLogin(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Login (hourLogin, user_id) VALUES (@HourLogin, @UserId)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@HourLogin", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar login: " + ex.Message);
            }
        }

        private void LogLogout(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WSP_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Login SET hourLogout = @HourLogout WHERE user_id = @UserId AND hourLogout IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@HourLogout", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar logout: " + ex.Message);
            }
        }


    }
}
