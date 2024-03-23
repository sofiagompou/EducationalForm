using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ekpaideutiko_logismiko
{
    public partial class HomePage : Form
    {
        private object homePage;

        public object GetHomePage()
        {
            return homePage;
        }


        public HomePage()
        {
            InitializeComponent();
        }


        private void Homepage_Load(object sender, EventArgs e)
        {
            logo.BorderStyle = BorderStyle.None;

        }

        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234admin;Database=ekp_log;";
        public static int userid { get; set; }

        private int RetrieveLoggedInUserID(string username)
        {
            int userid = -1;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT userid FROM users WHERE username = @username";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        userid = Convert.ToInt32(result);
                    }
                }
            }

            return userid;
           
        }
 

        private void login_Click(object sender, EventArgs e)
        {

            string un = username.Text;
            string pw = password.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", un);
                    command.Parameters.AddWithValue("@password", pw);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string updateSql = "UPDATE users SET lastlogin = @lastlogin WHERE username = @username";
                        using (NpgsqlCommand updateCommand = new NpgsqlCommand(updateSql, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@lastlogin", DateTime.Now); 
                            updateCommand.Parameters.AddWithValue("@username", un);

                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Failed to update last login timestamp.");
                            }
                            else
                            {
                                int loggedInUserID = RetrieveLoggedInUserID(un);
                                if (loggedInUserID != -1)
                                {
                                    HomePage.userid = loggedInUserID;
                                    MessageBox.Show("Επιτυχής Σύνδεση");
                                    var nextform = new Menu();
                                    nextform.Show();
                                    this.Hide();
                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Λάθος username ή/και password!");
                    }
                }
            }

        }


        private void signup_Click(object sender, EventArgs e) 
        {
            var nextform = new signup();
            nextform.Show();
            this.Hide();
        }

        private void help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            String plan_help = "C:\\Users\\Sofia\\Documents\\ΠΑΝΕΠΙΣΤΗΜΙΟ\\Εκπαιδευτικό Λογισμικό - 8ο εξάμηνο\\ekpaideutiko_logismiko_2023\\ONLINE HELP.pdf";
            process.StartInfo.FileName = plan_help;
            process.Start();
            process.WaitForExit();
        }
    }
}
