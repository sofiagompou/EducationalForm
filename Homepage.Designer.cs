
using System;

namespace ekpaideutiko_logismiko
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, -30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(304, 166);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(436, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "ΕΠΑΓΓΕΛΜΑΤΙΚΟΣ ΠΡΟΣΑΝΑΤΟΛΙΣΜΟΣ \r\nΦΟΙΤΗΤΩΝ ΚΑΙ ΑΠΟΦΟΙΤΩΝ\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(911, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ΤΜΗΜΑ ΠΛΗΡΟΦΟΡΙΚΗΣ\r\n";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Menu;
            this.username.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username.Location = new System.Drawing.Point(566, 296);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(175, 28);
            this.username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(387, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Αν έχετε λογαριασμό, συνδεθείτε με τα στοιχεία σας.\r\nΑλλιώς, δημιουργήστε έναν.\r\n" +
    "";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Menu;
            this.password.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password.Location = new System.Drawing.Point(566, 342);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(175, 28);
            this.password.TabIndex = 6;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signup.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.signup.Location = new System.Drawing.Point(510, 497);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(154, 66);
            this.signup.TabIndex = 7;
            this.signup.Text = "Δημιουργία Λογαριασμού";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(441, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(442, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.login.Location = new System.Drawing.Point(525, 403);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(122, 40);
            this.login.TabIndex = 11;
            this.login.Text = "Είσοδος";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(12, 163);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(83, 32);
            this.help.TabIndex = 12;
            this.help.Text = "HELP";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 612);
            this.Controls.Add(this.help);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Name = "HomePage";
            this.RightToLeftLayout = true;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            throw new NotImplementedException();
        }


        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button help;
    }

    internal class endregion
    {
    }
}

#endregion