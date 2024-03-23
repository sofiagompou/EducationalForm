using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ekpaideutiko_logismiko
{
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void java_Click(object sender, EventArgs e)
        {
            var nextform = new Javatest();
            nextform.Show();
            this.Hide();
        }

        private void html_Click(object sender, EventArgs e)
        {
            var nextform = new Htmltest();
            nextform.Show();
            this.Hide();
        }

        private void csharp_Click(object sender, EventArgs e)
        {
            var nextform = new Cstest();
            nextform.Show();
            this.Hide();
        }

        private void javascript_Click(object sender, EventArgs e)
        {
            var nextform = new Javascripttest();
            nextform.Show();
            this.Hide();
        }

        private void backend_test_Click(object sender, EventArgs e)
        {
            var nextform = new Backend_test();
            nextform.Show();
            this.Hide();
        }

        private void frontend_test_Click(object sender, EventArgs e)
        {
            var nextform = new Frontend_test();
            nextform.Show();
            this.Hide();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            var nextform = new Menu();
            nextform.Show();
            this.Hide();
        }

        private void history_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234admin;Database=ekp_log;";
            int userid = HomePage.userid;

            string sql = @"
                SELECT test, score, testdate
                FROM public.usertests
                WHERE userid = @userid
                ORDER BY testdate DESC;";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userid);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                string test = reader.GetString(0);
                                int score = reader.GetInt32(1);
                                DateTime testDate = reader.GetDateTime(2);

                                sb.AppendLine($"Test: {test}, Score: {score}, Test Date: {testDate}");
                            }

                            if (sb.Length > 0)
                            {
                                MessageBox.Show(sb.ToString(), "Test Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No test results found for the user.", "Test Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void orientation_Click(object sender, EventArgs e)
        {
            Form form = new orientation();
            form.Show();
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
