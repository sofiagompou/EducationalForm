using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace ekpaideutiko_logismiko
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234admin;Database=ekp_log;";

        private void signup_button_Click(object sender, EventArgs e)
        {
            string un = username.Text;
            string pw = password.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string checkUsernameSql = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (NpgsqlCommand checkUsernameCommand = new NpgsqlCommand(checkUsernameSql, connection))
                {
                    checkUsernameCommand.Parameters.AddWithValue("@username", un);
                    int existingUserCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Το username χρησιμοποιείται ήδη! Δοκιμάστε ένα διαφορετικό.");
                        return;
                    }
                }

                string sql = "INSERT INTO users (username, password, lastlogin) VALUES (@username, @password, @lastlogin)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", un); 
                    command.Parameters.AddWithValue("@password", pw); 
                    command.Parameters.AddWithValue("@lastlogin", DateTime.Now);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            DialogResult result = MessageBox.Show("Επιτυχής Εγγραφή", "Success", MessageBoxButtons.OK);

                            if (result == DialogResult.OK)
                            {
                                Form form = new HomePage(); 
                                form.Show();
                                this.Hide(); 
                            }

                        }
                        else
                        {
                            MessageBox.Show("Η εγγραφή απέτυχε!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

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
