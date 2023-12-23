namespace WinFormsApp1
{
    partial class dietitianInfoFromAdmin
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblUniversite = new Label();
            lblName = new Label();
            lblUzmanlik = new Label();
            lblEgitim = new Label();
            btnSil = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(393, 23);
            label1.TabIndex = 6;
            label1.Text = "İncelemekte olduğunuz diyetisyenin genel bilgileri";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblUniversite);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblUzmanlik);
            panel1.Controls.Add(lblEgitim);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 170);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 6;
            label2.Text = "Mezun Olduğu Üniveriste:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 18);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Ad-Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 117);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 7;
            label4.Text = "Uzmanlık alanları:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 51);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 5;
            label5.Text = "Eğitim Durumu:";
            // 
            // lblUniversite
            // 
            lblUniversite.AutoSize = true;
            lblUniversite.Location = new Point(208, 84);
            lblUniversite.Name = "lblUniversite";
            lblUniversite.Size = new Size(50, 20);
            lblUniversite.TabIndex = 2;
            lblUniversite.Text = "label1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(208, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblUzmanlik
            // 
            lblUzmanlik.AutoSize = true;
            lblUzmanlik.Location = new Point(208, 117);
            lblUzmanlik.Name = "lblUzmanlik";
            lblUzmanlik.Size = new Size(50, 20);
            lblUzmanlik.TabIndex = 3;
            lblUzmanlik.Text = "label1";
            // 
            // lblEgitim
            // 
            lblEgitim.AutoSize = true;
            lblEgitim.Location = new Point(208, 51);
            lblEgitim.Name = "lblEgitim";
            lblEgitim.Size = new Size(50, 20);
            lblEgitim.TabIndex = 1;
            lblEgitim.Text = "label1";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(407, 213);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dietitianInfoFromAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 232, 227);
            ClientSize = new Size(513, 247);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnSil);
            Name = "dietitianInfoFromAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dietitianInfoFromAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblUniversite;
        private Label lblName;
        private Label lblUzmanlik;
        private Label lblEgitim;
        private Button btnSil;
    }
}