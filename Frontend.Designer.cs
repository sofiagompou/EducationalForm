
namespace ekpaideutiko_logismiko
{
    partial class Frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
            this.gototest = new System.Windows.Forms.Button();
            this.html = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.javascript = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backtomenu = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gototest
            // 
            this.gototest.BackColor = System.Drawing.Color.LemonChiffon;
            this.gototest.Location = new System.Drawing.Point(695, 659);
            this.gototest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gototest.Name = "gototest";
            this.gototest.Size = new System.Drawing.Size(133, 55);
            this.gototest.TabIndex = 0;
            this.gototest.Text = "ΤΕΣΤ";
            this.gototest.UseVisualStyleBackColor = false;
            this.gototest.Click += new System.EventHandler(this.gototest_Click);
            // 
            // html
            // 
            this.html.AutoSize = true;
            this.html.BackColor = System.Drawing.Color.LemonChiffon;
            this.html.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.html.Location = new System.Drawing.Point(379, 47);
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(98, 35);
            this.html.TabIndex = 1;
            this.html.Text = "HTML";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 247);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // javascript
            // 
            this.javascript.AutoSize = true;
            this.javascript.BackColor = System.Drawing.Color.LemonChiffon;
            this.javascript.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.javascript.Location = new System.Drawing.Point(346, 420);
            this.javascript.Name = "javascript";
            this.javascript.Size = new System.Drawing.Size(168, 35);
            this.javascript.TabIndex = 3;
            this.javascript.Text = "JavaScript";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 190);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // backtomenu
            // 
            this.backtomenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.backtomenu.Location = new System.Drawing.Point(696, 27);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(140, 55);
            this.backtomenu.TabIndex = 5;
            this.backtomenu.Text = "ΕΠΙΣΤΡΟΦΗ ΣΤΟ ΜΕΝΟΥ";
            this.backtomenu.UseVisualStyleBackColor = false;
            this.backtomenu.Click += new System.EventHandler(this.backtomenu_Click);
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
            // Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 555);
            this.Controls.Add(this.help);
            this.Controls.Add(this.backtomenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.javascript);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.html);
            this.Controls.Add(this.gototest);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frontend";
            this.Text = "Front End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gototest;
        private System.Windows.Forms.Label html;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label javascript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backtomenu;
        private System.Windows.Forms.Button help;
    }
}