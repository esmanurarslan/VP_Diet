namespace WinFormsApp1
{
    partial class FormGiris
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
            panel1 = new Panel();
            label4 = new Label();
            linkLabelUnuttum = new LinkLabel();
            linkLabelUyeOl = new LinkLabel();
            btnGiris = new Button();
            label3 = new Label();
            txtParola = new TextBox();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 251, 249);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabelUnuttum);
            panel1.Controls.Add(linkLabelUyeOl);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtParola);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 318);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(14, 245);
            label4.Name = "label4";
            label4.Size = new Size(181, 20);
            label4.TabIndex = 8;
            label4.Text = "Henüz bir hesabın yok mu?";
            // 
            // linkLabelUnuttum
            // 
            linkLabelUnuttum.AutoSize = true;
            linkLabelUnuttum.LinkColor = Color.Black;
            linkLabelUnuttum.Location = new Point(145, 194);
            linkLabelUnuttum.Name = "linkLabelUnuttum";
            linkLabelUnuttum.Size = new Size(117, 20);
            linkLabelUnuttum.TabIndex = 7;
            linkLabelUnuttum.TabStop = true;
            linkLabelUnuttum.Text = "şifremi unuttum!";
            // 
            // linkLabelUyeOl
            // 
            linkLabelUyeOl.AutoSize = true;
            linkLabelUyeOl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelUyeOl.LinkColor = Color.Black;
            linkLabelUyeOl.Location = new Point(215, 243);
            linkLabelUyeOl.Name = "linkLabelUyeOl";
            linkLabelUyeOl.Size = new Size(58, 23);
            linkLabelUyeOl.TabIndex = 6;
            linkLabelUyeOl.TabStop = true;
            linkLabelUyeOl.Text = "Üye ol";
            linkLabelUyeOl.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(128, 199, 175);
            btnGiris.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(23, 184);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(103, 38);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 142);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // txtParola
            // 
            txtParola.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtParola.Location = new Point(14, 137);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.PlaceholderText = "Parola";
            txtParola.Size = new Size(288, 30);
            txtParola.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(14, 91);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtKullaniciAdi.Size = new Size(288, 30);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 37);
            label1.Name = "label1";
            label1.Size = new Size(104, 31);
            label1.TabIndex = 0;
            label1.Text = "Giriş Yap";
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(339, 339);
            Controls.Add(panel1);
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Formu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private LinkLabel linkLabelUnuttum;
        private LinkLabel linkLabelUyeOl;
        private Button btnGiris;
        private Label label3;
        private TextBox txtParola;
        private TextBox txtKullaniciAdi;
        private Label label1;
    }
}