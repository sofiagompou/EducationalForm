
namespace ekpaideutiko_logismiko
{
    partial class Backend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backend));
            this.backtomenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.csharp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.java = new System.Windows.Forms.Label();
            this.gototest = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backtomenu
            // 
            this.backtomenu.BackColor = System.Drawing.Color.White;
            this.backtomenu.Location = new System.Drawing.Point(811, 28);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(140, 55);
            this.backtomenu.TabIndex = 11;
            this.backtomenu.Text = "ΕΠΙΣΤΡΟΦΗ ΣΤΟ ΜΕΝΟΥ";
            this.backtomenu.UseVisualStyleBackColor = false;
            this.backtomenu.Click += new System.EventHandler(this.backtomenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(12, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(950, 176);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // csharp
            // 
            this.csharp.AutoSize = true;
            this.csharp.BackColor = System.Drawing.Color.LemonChiffon;
            this.csharp.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.csharp.Location = new System.Drawing.Point(432, 429);
            this.csharp.Name = "csharp";
            this.csharp.Size = new System.Drawing.Size(54, 35);
            this.csharp.TabIndex = 9;
            this.csharp.Text = "C#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 264);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.BackColor = System.Drawing.Color.LemonChiffon;
            this.java.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.java.Location = new System.Drawing.Point(403, 48);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(83, 35);
            this.java.TabIndex = 7;
            this.java.Text = "Java";
            // 
            // gototest
            // 
            this.gototest.BackColor = System.Drawing.Color.White;
            this.gototest.Location = new System.Drawing.Point(818, 706);
            this.gototest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gototest.Name = "gototest";
            this.gototest.Size = new System.Drawing.Size(133, 55);
            this.gototest.TabIndex = 6;
            this.gototest.Text = "ΤΕΣΤ";
            this.gototest.UseVisualStyleBackColor = false;
            this.gototest.Click += new System.EventHandler(this.gototest_Click);
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
            // Backend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(988, 524);
            this.Controls.Add(this.help);
            this.Controls.Add(this.backtomenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.csharp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.java);
            this.Controls.Add(this.gototest);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Backend";
            this.Text = "Back End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtomenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label csharp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label java;
        private System.Windows.Forms.Button gototest;
        private System.Windows.Forms.Button help;
    }
}