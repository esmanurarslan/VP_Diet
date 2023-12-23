namespace WinFormsApp1
{
    partial class ConsultantInfoFromAdmin
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
            label6 = new Label();
            lblDiyetisyen = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCinsiyet = new Label();
            lblSehir = new Label();
            lblEmail = new Label();
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
            label1.Size = new Size(375, 23);
            label1.TabIndex = 9;
            label1.Text = "İncelemekte olduğunuz danışanın genel bilgileri";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblDiyetisyen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblCinsiyet);
            panel1.Controls.Add(lblSehir);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 170);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 115);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 9;
            label6.Text = "Diyetisyeni:";
            label6.Click += label6_Click;
            // 
            // lblDiyetisyen
            // 
            lblDiyetisyen.AutoSize = true;
            lblDiyetisyen.Location = new Point(202, 115);
            lblDiyetisyen.Name = "lblDiyetisyen";
            lblDiyetisyen.Size = new Size(50, 20);
            lblDiyetisyen.TabIndex = 8;
            lblDiyetisyen.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 49);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 82);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Şehir:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 16);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(202, 49);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(50, 20);
            lblCinsiyet.TabIndex = 2;
            lblCinsiyet.Text = "label1";
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Location = new Point(202, 82);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(50, 20);
            lblSehir.TabIndex = 3;
            lblSehir.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(202, 16);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "label1";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(407, 213);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // ConsultantInfoFromAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 232, 227);
            ClientSize = new Size(513, 247);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnSil);
            Name = "ConsultantInfoFromAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultantInfoFromAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lblCinsiyet;
        private Label lblSehir;
        private Label lblEmail;
        private Button btnSil;
        private Label label6;
        private Label lblDiyetisyen;
    }
}