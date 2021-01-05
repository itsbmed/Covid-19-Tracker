
namespace Covide_19_Tracker
{
    partial class Form2
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
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Usercni = new System.Windows.Forms.Label();
            this.Userage = new System.Windows.Forms.Label();
            this.Userstatut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Bangers", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Username.Location = new System.Drawing.Point(286, 166);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(295, 56);
            this.Username.TabIndex = 0;
            this.Username.Text = "MOHAMMED BELACHHAB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(348, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(344, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "AGE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(344, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "STATUT :";
            // 
            // Usercni
            // 
            this.Usercni.AutoSize = true;
            this.Usercni.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.Usercni.Location = new System.Drawing.Point(421, 253);
            this.Usercni.Name = "Usercni";
            this.Usercni.Size = new System.Drawing.Size(106, 30);
            this.Usercni.TabIndex = 4;
            this.Usercni.Text = "XA137230";
            // 
            // Userage
            // 
            this.Userage.AutoSize = true;
            this.Userage.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.Userage.Location = new System.Drawing.Point(421, 299);
            this.Userage.Name = "Userage";
            this.Userage.Size = new System.Drawing.Size(34, 30);
            this.Userage.TabIndex = 5;
            this.Userage.Text = "19";
            // 
            // Userstatut
            // 
            this.Userstatut.AutoSize = true;
            this.Userstatut.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.Userstatut.ForeColor = System.Drawing.Color.LimeGreen;
            this.Userstatut.Location = new System.Drawing.Point(445, 351);
            this.Userstatut.Name = "Userstatut";
            this.Userstatut.Size = new System.Drawing.Size(71, 30);
            this.Userstatut.TabIndex = 6;
            this.Userstatut.Text = "Green";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(910, 532);
            this.Controls.Add(this.Userstatut);
            this.Controls.Add(this.Userage);
            this.Controls.Add(this.Usercni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Usercni;
        private System.Windows.Forms.Label Userage;
        private System.Windows.Forms.Label Userstatut;
    }
}