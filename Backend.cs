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
    public partial class Backend : Form
    {
        public Backend()
        {
            InitializeComponent();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            Form form = new Menu();
            form.Show();
            this.Hide();
        }

        private void gototest_Click(object sender, EventArgs e)
        {
            Form form = new Tests();
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
