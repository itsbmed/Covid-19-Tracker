
namespace Covide_19_Tracker
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.button1 = new System.Windows.Forms.Button();
            this.Phbox = new System.Windows.Forms.TextBox();
            this.Bdbox = new System.Windows.Forms.TextBox();
            this.Cnbox = new System.Windows.Forms.TextBox();
            this.Adbox = new System.Windows.Forms.TextBox();
            this.Fnbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrField = new System.Windows.Forms.ComboBox();
            this.StField = new System.Windows.Forms.ComboBox();
            this.GenreField = new System.Windows.Forms.Label();
            this.StatutField = new System.Windows.Forms.Label();
            this.UseCondition = new System.Windows.Forms.CheckBox();
            this.Rt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Signup);
            // 
            // Phbox
            // 
            this.Phbox.BackColor = System.Drawing.SystemColors.Highlight;
            this.Phbox.Font = new System.Drawing.Font("Rajdhani", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phbox.ForeColor = System.Drawing.SystemColors.Info;
            this.Phbox.Location = new System.Drawing.Point(509, 351);
            this.Phbox.Name = "Phbox";
            this.Phbox.Size = new System.Drawing.Size(385, 32);
            this.Phbox.TabIndex = 1;
            this.Phbox.Text = "Phone";
            this.Phbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phbox.Enter += new System.EventHandler(this.Focus_Click);
            this.Phbox.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // Bdbox
            // 
            this.Bdbox.BackColor = System.Drawing.SystemColors.Highlight;
            this.Bdbox.Font = new System.Drawing.Font("Rajdhani", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdbox.ForeColor = System.Drawing.SystemColors.Info;
            this.Bdbox.Location = new System.Drawing.Point(509, 415);
            this.Bdbox.Name = "Bdbox";
            this.Bdbox.Size = new System.Drawing.Size(385, 32);
            this.Bdbox.TabIndex = 2;
            this.Bdbox.Text = "Brithday Date";
            this.Bdbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bdbox.Enter += new System.EventHandler(this.Focus_Click);
            this.Bdbox.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // Cnbox
            // 
            this.Cnbox.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cnbox.Font = new System.Drawing.Font("Rajdhani", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnbox.ForeColor = System.Drawing.SystemColors.Info;
            this.Cnbox.Location = new System.Drawing.Point(509, 223);
            this.Cnbox.Name = "Cnbox";
            this.Cnbox.Size = new System.Drawing.Size(385, 32);
            this.Cnbox.TabIndex = 4;
            this.Cnbox.Text = "Cni";
            this.Cnbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cnbox.Enter += new System.EventHandler(this.Focus_Click);
            this.Cnbox.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // Adbox
            // 
            this.Adbox.BackColor = System.Drawing.SystemColors.Highlight;
            this.Adbox.Font = new System.Drawing.Font("Rajdhani", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adbox.ForeColor = System.Drawing.SystemColors.Info;
            this.Adbox.Location = new System.Drawing.Point(509, 282);
            this.Adbox.Name = "Adbox";
            this.Adbox.Size = new System.Drawing.Size(385, 32);
            this.Adbox.TabIndex = 5;
            this.Adbox.Text = "Adress";
            this.Adbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adbox.Enter += new System.EventHandler(this.Focus_Click);
            this.Adbox.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // Fnbox
            // 
            this.Fnbox.BackColor = System.Drawing.SystemColors.Highlight;
            this.Fnbox.Font = new System.Drawing.Font("Rajdhani", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnbox.ForeColor = System.Drawing.SystemColors.Info;
            this.Fnbox.Location = new System.Drawing.Point(509, 161);
            this.Fnbox.Margin = new System.Windows.Forms.Padding(12);
            this.Fnbox.Name = "Fnbox";
            this.Fnbox.Size = new System.Drawing.Size(385, 32);
            this.Fnbox.TabIndex = 6;
            this.Fnbox.Text = "Full Name";
            this.Fnbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fnbox.Enter += new System.EventHandler(this.Focus_Click);
            this.Fnbox.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adventure Hollow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12);
            this.label1.Size = new System.Drawing.Size(269, 70);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hey, Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 100);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12);
            this.label2.Size = new System.Drawing.Size(427, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "Please Enter Your Personel Informations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrField
            // 
            this.GrField.FormattingEnabled = true;
            this.GrField.Items.AddRange(new object[] {
            "M",
            "F"});
            this.GrField.Location = new System.Drawing.Point(509, 514);
            this.GrField.Name = "GrField";
            this.GrField.Size = new System.Drawing.Size(121, 21);
            this.GrField.TabIndex = 14;
            // 
            // StField
            // 
            this.StField.FormattingEnabled = true;
            this.StField.Items.AddRange(new object[] {
            "Normal",
            "Patient",
            "Vaccine",
            "Possible"});
            this.StField.Location = new System.Drawing.Point(757, 514);
            this.StField.Name = "StField";
            this.StField.Size = new System.Drawing.Size(121, 21);
            this.StField.TabIndex = 15;
            // 
            // GenreField
            // 
            this.GenreField.AutoSize = true;
            this.GenreField.Font = new System.Drawing.Font("Rajdhani", 18F);
            this.GenreField.Location = new System.Drawing.Point(509, 471);
            this.GenreField.Name = "GenreField";
            this.GenreField.Size = new System.Drawing.Size(70, 30);
            this.GenreField.TabIndex = 16;
            this.GenreField.Text = "Genre";
            // 
            // StatutField
            // 
            this.StatutField.AutoSize = true;
            this.StatutField.Font = new System.Drawing.Font("Rajdhani", 18F);
            this.StatutField.Location = new System.Drawing.Point(752, 471);
            this.StatutField.Name = "StatutField";
            this.StatutField.Size = new System.Drawing.Size(74, 30);
            this.StatutField.TabIndex = 17;
            this.StatutField.Text = "Statut";
            // 
            // UseCondition
            // 
            this.UseCondition.AutoSize = true;
            this.UseCondition.Location = new System.Drawing.Point(509, 571);
            this.UseCondition.Name = "UseCondition";
            this.UseCondition.Size = new System.Drawing.Size(213, 17);
            this.UseCondition.TabIndex = 18;
            this.UseCondition.Text = "* I Agree All The Terms And Condutions";
            this.UseCondition.UseVisualStyleBackColor = true;
            this.UseCondition.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Rt
            // 
            this.Rt.BackColor = System.Drawing.Color.White;
            this.Rt.BackgroundImage = global::Covide_19_Tracker.Properties.Resources._return;
            this.Rt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Rt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Rt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Rt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Rt.Location = new System.Drawing.Point(12, 12);
            this.Rt.Name = "Rt";
            this.Rt.Size = new System.Drawing.Size(49, 38);
            this.Rt.TabIndex = 19;
            this.Rt.UseVisualStyleBackColor = false;
            this.Rt.Click += new System.EventHandler(this.Rt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 757);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(949, 741);
            this.Controls.Add(this.Rt);
            this.Controls.Add(this.UseCondition);
            this.Controls.Add(this.StatutField);
            this.Controls.Add(this.GenreField);
            this.Controls.Add(this.StField);
            this.Controls.Add(this.GrField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Fnbox);
            this.Controls.Add(this.Adbox);
            this.Controls.Add(this.Cnbox);
            this.Controls.Add(this.Bdbox);
            this.Controls.Add(this.Phbox);
            this.Controls.Add(this.button1);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Phbox;
        private System.Windows.Forms.TextBox Bdbox;
        private System.Windows.Forms.TextBox Cnbox;
        private System.Windows.Forms.TextBox Adbox;
        private System.Windows.Forms.TextBox Fnbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GrField;
        private System.Windows.Forms.ComboBox StField;
        private System.Windows.Forms.Label GenreField;
        private System.Windows.Forms.Label StatutField;
        private System.Windows.Forms.CheckBox UseCondition;
        private System.Windows.Forms.Button Rt;
    }
}

