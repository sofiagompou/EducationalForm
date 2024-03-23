
namespace ekpaideutiko_logismiko
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.frontend = new System.Windows.Forms.Button();
            this.backend = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(97, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ΕΠΙΛΕΞΕ ΤΙ ΘΕΛΕΙΣ ΝΑ ΔΙΑΒΑΣΕΙΣ!";
            // 
            // frontend
            // 
            this.frontend.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.frontend.Location = new System.Drawing.Point(86, 202);
            this.frontend.Name = "frontend";
            this.frontend.Size = new System.Drawing.Size(145, 59);
            this.frontend.TabIndex = 1;
            this.frontend.Text = "FRONT END";
            this.frontend.UseVisualStyleBackColor = false;
            this.frontend.Click += new System.EventHandler(this.frontend_Click);
            // 
            // backend
            // 
            this.backend.BackColor = System.Drawing.Color.MistyRose;
            this.backend.Location = new System.Drawing.Point(309, 202);
            this.backend.Name = "backend";
            this.backend.Size = new System.Drawing.Size(130, 59);
            this.backend.TabIndex = 2;
            this.backend.Text = "BACK END";
            this.backend.UseVisualStyleBackColor = false;
            this.backend.Click += new System.EventHandler(this.backend_Click);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 417);
            this.Controls.Add(this.help);
            this.Controls.Add(this.backend);
            this.Controls.Add(this.frontend);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frontend;
        private System.Windows.Forms.Button backend;
        private System.Windows.Forms.Button help;
    }
}