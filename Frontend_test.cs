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
    public partial class Frontend_test : Form
    {
        public Frontend_test()
        {
            InitializeComponent();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            int score = 0;

            if (radioButton5.Checked)
            {
                score += 1;
            }
            if (radioButton7.Checked)
            {
                score += 1;
            }
            if (radioButton3.Checked)
            {
                score += 1;
            }
            if (radioButton12.Checked)
            {
                score += 1;
            }
            if (radioButton17.Checked)
            {
                score += 1;
            }

            if (score >= 3)
            {
                MessageBox.Show("Το σκορ σας ήταν " + score + "/5!");
                SaveTestScore(score);
                Form form = new Tests();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Το σκορ σας ήταν χαμηλό. Δείτε ξανά τις πληροφορίες ");
                Form form = new Frontend();
                form.Show();
                this.Hide();
            }
        }

        public void SaveTestScore(int score)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234admin;Database=ekp_log;";

            int userid = HomePage.userid;
            string test = "Frontend";
            DateTime testDate = DateTime.Now;

            string sql = @"
            INSERT INTO public.usertests (userid, test, score, testdate)
            VALUES (@userid, @test, @score, @testdate);
            ";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userid);
                        command.Parameters.AddWithValue("@test", test);
                        command.Parameters.AddWithValue("@score", score);
                        command.Parameters.AddWithValue("@testdate", testDate);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
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
