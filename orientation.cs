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
    public partial class orientation : Form
    {
        public orientation()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(java.Text)) || (string.IsNullOrWhiteSpace(csharp.Text)) || (string.IsNullOrWhiteSpace(html.Text)) || (string.IsNullOrWhiteSpace(javascript.Text)))
            {
                MessageBox.Show("Please enter a value in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((!int.TryParse(java.Text, out _)) || (!int.TryParse(csharp.Text, out _)) || (!int.TryParse(html.Text, out _)) || (!int.TryParse(javascript.Text, out _)))
            {
                MessageBox.Show("Please enter only integer values in the textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int num_b, num_f;
            num_b = Convert.ToInt32(java.Text) + Convert.ToInt32(csharp.Text);
            num_f = Convert.ToInt32(html.Text) + Convert.ToInt32(javascript.Text);

            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234admin;Database=ekp_log;";

            int userid = HomePage.userid;

            int totalsum_b = 0;
            int totalsum_f = 0;
            
            string query = @"
            WITH LatestTestScores AS (
                SELECT DISTINCT ON (test) *
                FROM public.usertests
                WHERE userid = @userid
                ORDER BY test, testdate DESC
            )
            SELECT 
                COALESCE(SUM(CASE WHEN test = 'Java' THEN score ELSE 0 END), 0) +
                COALESCE(SUM(CASE WHEN test = 'C#' THEN score ELSE 0 END), 0) +
                COALESCE(SUM(CASE WHEN test = 'Backend' THEN score ELSE 0 END), 0) AS total_score
            FROM LatestTestScores;";

            string query2 = @"
            WITH LatestTestScores AS (
                SELECT DISTINCT ON (test) *
                FROM public.usertests
                WHERE userid = @userId
                ORDER BY test, testdate DESC
            )
            SELECT 
                COALESCE(SUM(CASE WHEN test = 'HTML' THEN score ELSE 0 END), 0) AS html_score,
                COALESCE(SUM(CASE WHEN test = 'JavaScript' THEN score ELSE 0 END), 0) AS javascript_score,
                COALESCE(SUM(CASE WHEN test = 'Frontend' THEN score ELSE 0 END), 0) AS frontend_score
            FROM LatestTestScores;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userid", userid);
                    totalsum_b = Convert.ToInt32(command.ExecuteScalar()) + num_b;
                }

                using (NpgsqlCommand command2 = new NpgsqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@userid", userid);
                    totalsum_f = Convert.ToInt32(command2.ExecuteScalar()) + num_f;
                }
            }
            
            if (totalsum_f>totalsum_b){
                MessageBox.Show("Σας προτείνουμε να ακολουθήσετε την επαγγελματική κατεύθυνση του Front End Developer");
            }
            else if (totalsum_f < totalsum_b)
            {
                MessageBox.Show("Σας προτείνουμε να ακολουθήσετε την επαγγελματική κατεύθυνση του Back End Developer");
            }
            else
            {
                MessageBox.Show("Σας προτείνουμε να ακολουθήσετε την επαγγελματική κατεύθυνση του Full Stack Developer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var nextform = new Tests();
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
