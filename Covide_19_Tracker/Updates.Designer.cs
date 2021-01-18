
namespace Covide_19_Tracker
{
    partial class Updates
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
            this.button1 = new System.Windows.Forms.Button();
            this.proavalue = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pora = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneoradress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proavalue
            // 
            this.proavalue.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.proavalue.Location = new System.Drawing.Point(331, 182);
            this.proavalue.Name = "proavalue";
            this.proavalue.Size = new System.Drawing.Size(404, 38);
            this.proavalue.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "I change my number",
            "I lost my number"});
            this.comboBox1.Location = new System.Drawing.Point(331, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 38);
            this.comboBox1.TabIndex = 3;
            // 
            // pora
            // 
            this.pora.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold);
            this.pora.FormattingEnabled = true;
            this.pora.Items.AddRange(new object[] {
            "Phone",
            "Adress"});
            this.pora.Location = new System.Drawing.Point(331, 106);
            this.pora.Name = "pora";
            this.pora.Size = new System.Drawing.Size(213, 38);
            this.pora.TabIndex = 4;
            this.pora.Text = "Phone";
            this.pora.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 30);
            this.label7.TabIndex = 26;
            this.label7.Text = "Phone / Adress :";
            // 
            // phoneoradress
            // 
            this.phoneoradress.AutoSize = true;
            this.phoneoradress.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneoradress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneoradress.Location = new System.Drawing.Point(12, 185);
            this.phoneoradress.Name = "phoneoradress";
            this.phoneoradress.Size = new System.Drawing.Size(86, 30);
            this.phoneoradress.TabIndex = 27;
            this.phoneoradress.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rajdhani", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Why You Want To Changed  :";
            // 
            // Rt
            // 
            this.Rt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Rt.BackgroundImage = global::Covide_19_Tracker.Properties.Resources._return;
            this.Rt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Rt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Rt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Rt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Rt.Location = new System.Drawing.Point(17, 27);
            this.Rt.Name = "Rt";
            this.Rt.Size = new System.Drawing.Size(49, 38);
            this.Rt.TabIndex = 29;
            this.Rt.UseVisualStyleBackColor = false;
            this.Rt.Click += new System.EventHandler(this.Rt_Click);
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.Rt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneoradress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pora);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.proavalue);
            this.Controls.Add(this.button1);
            this.Name = "Updates";
            this.Text = "Updates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox proavalue;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox pora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phoneoradress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Rt;
    }
}