
namespace ekpaideutiko_logismiko
{
    partial class signup
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Beige;
            this.username.Location = new System.Drawing.Point(220, 126);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(173, 27);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Beige;
            this.password.Location = new System.Drawing.Point(220, 204);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(173, 27);
            this.password.TabIndex = 1;
            // 
            // usernametext
            // 
            this.usernametext.AutoSize = true;
            this.usernametext.BackColor = System.Drawing.Color.Transparent;
            this.usernametext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernametext.Location = new System.Drawing.Point(83, 129);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(83, 19);
            this.usernametext.TabIndex = 2;
            this.usernametext.Text = "Username";
            // 
            // passwordtext
            // 
            this.passwordtext.AutoSize = true;
            this.passwordtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtext.Location = new System.Drawing.Point(83, 209);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(80, 19);
            this.passwordtext.TabIndex = 3;
            this.passwordtext.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(166, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "ΕΓΓΡΑΦΗ ΧΡΗΣΤΗ";
            // 
            // signup_button
            // 
            this.signup_button.Location = new System.Drawing.Point(196, 306);
            this.signup_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(109, 49);
            this.signup_button.TabIndex = 5;
            this.signup_button.Text = "ΕΓΓΡΑΦΗ";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(12, 12);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(83, 32);
            this.help.TabIndex = 13;
            this.help.Text = "HELP";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.help);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "signup";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label usernametext;
        private System.Windows.Forms.Label passwordtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button help;
    }
}