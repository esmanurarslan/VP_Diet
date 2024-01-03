namespace WinFormsApp1
{
    partial class FormDiyetisyenKayit
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
            btnKayit = new Button();
            txtAd = new TextBox();
            txtUniversite = new TextBox();
            cmbEgitim = new ComboBox();
            btnCancel = new Button();
            txtUzmanlik = new TextBox();
            txtCity = new TextBox();
            cmbGender = new ComboBox();
            dateBirthDate = new DateTimePicker();
            lblGender = new Label();
            lblBirthDate = new Label();
            txtParolaTekrar = new TextBox();
            txtParola = new TextBox();
            txtUser = new TextBox();
            txtEposta = new TextBox();
            lblKayitOl = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 251, 249);
            panel1.Controls.Add(btnKayit);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(txtUniversite);
            panel1.Controls.Add(cmbEgitim);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtUzmanlik);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(dateBirthDate);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblBirthDate);
            panel1.Controls.Add(txtParolaTekrar);
            panel1.Controls.Add(txtParola);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(txtEposta);
            panel1.Controls.Add(lblKayitOl);
            panel1.Location = new Point(27, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 659);
            panel1.TabIndex = 0;
            // 
            // btnKayit
            // 
            btnKayit.BackColor = Color.FromArgb(128, 199, 175);
            btnKayit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayit.ForeColor = Color.White;
            btnKayit.Location = new Point(98, 548);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(177, 47);
            btnKayit.TabIndex = 33;
            btnKayit.Text = "Üye Ol";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(48, 85);
            txtAd.Margin = new Padding(2);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "Ad Soyad";
            txtAd.Size = new Size(288, 30);
            txtAd.TabIndex = 21;
            // 
            // txtUniversite
            // 
            txtUniversite.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUniversite.Location = new Point(48, 450);
            txtUniversite.Margin = new Padding(2);
            txtUniversite.Name = "txtUniversite";
            txtUniversite.PlaceholderText = "Üniversite Adı";
            txtUniversite.Size = new Size(288, 30);
            txtUniversite.TabIndex = 20;
            // 
            // cmbEgitim
            // 
            cmbEgitim.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEgitim.ForeColor = SystemColors.WindowFrame;
            cmbEgitim.FormattingEnabled = true;
            cmbEgitim.Items.AddRange(new object[] { "Üniversite Öğrencisi", "Lisans", "Yüksek Lisans", "Doktora" });
            cmbEgitim.Location = new Point(49, 408);
            cmbEgitim.Name = "cmbEgitim";
            cmbEgitim.Size = new Size(287, 31);
            cmbEgitim.TabIndex = 19;
            cmbEgitim.Text = "Eğitim Durumu";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(133, 600);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "İptal Et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUzmanlik
            // 
            txtUzmanlik.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUzmanlik.Location = new Point(48, 492);
            txtUzmanlik.Margin = new Padding(2);
            txtUzmanlik.Multiline = true;
            txtUzmanlik.Name = "txtUzmanlik";
            txtUzmanlik.PlaceholderText = "Uzmanlık";
            txtUzmanlik.ScrollBars = ScrollBars.Vertical;
            txtUzmanlik.Size = new Size(288, 44);
            txtUzmanlik.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(48, 366);
            txtCity.Margin = new Padding(2);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Şehir";
            txtCity.Size = new Size(288, 30);
            txtCity.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbGender.Location = new Point(213, 324);
            cmbGender.Margin = new Padding(2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(123, 28);
            cmbGender.TabIndex = 9;
            // 
            // dateBirthDate
            // 
            dateBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateBirthDate.Location = new Point(52, 324);
            dateBirthDate.Margin = new Padding(2);
            dateBirthDate.Name = "dateBirthDate";
            dateBirthDate.Size = new Size(157, 27);
            dateBirthDate.TabIndex = 8;
            dateBirthDate.Value = new DateTime(2023, 11, 30, 0, 0, 0, 0);
            dateBirthDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(213, 302);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(62, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Cinsiyet";
            lblGender.Click += lblGender_Click;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthDate.Location = new Point(52, 302);
            lblBirthDate.Margin = new Padding(2, 0, 2, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(102, 20);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Doğum Tarihi";
            // 
            // txtParolaTekrar
            // 
            txtParolaTekrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtParolaTekrar.Location = new Point(48, 259);
            txtParolaTekrar.Margin = new Padding(2);
            txtParolaTekrar.Name = "txtParolaTekrar";
            txtParolaTekrar.PasswordChar = '*';
            txtParolaTekrar.PlaceholderText = "Parola Tekrar";
            txtParolaTekrar.Size = new Size(288, 30);
            txtParolaTekrar.TabIndex = 4;
            // 
            // txtParola
            // 
            txtParola.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtParola.Location = new Point(48, 212);
            txtParola.Margin = new Padding(2);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.PlaceholderText = "Parola";
            txtParola.Size = new Size(288, 30);
            txtParola.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(48, 169);
            txtUser.Margin = new Padding(2);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Kullanıcı Adı";
            txtUser.Size = new Size(288, 30);
            txtUser.TabIndex = 2;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEposta.Location = new Point(48, 127);
            txtEposta.Margin = new Padding(2);
            txtEposta.Name = "txtEposta";
            txtEposta.PlaceholderText = "E-posta";
            txtEposta.Size = new Size(288, 30);
            txtEposta.TabIndex = 1;
            // 
            // lblKayitOl
            // 
            lblKayitOl.AutoSize = true;
            lblKayitOl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKayitOl.Location = new Point(48, 31);
            lblKayitOl.Margin = new Padding(2, 0, 2, 0);
            lblKayitOl.Name = "lblKayitOl";
            lblKayitOl.Size = new Size(266, 31);
            lblKayitOl.TabIndex = 0;
            lblKayitOl.Text = "Diyetisyen Üyelik Formu";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormDiyetisyenKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(430, 680);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "FormDiyetisyenKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diyetisyen Üyelik";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtEposta;
        private Label lblKayitOl;
        private TextBox txtParolaTekrar;
        private TextBox txtParola;
        private TextBox txtUser;
        private DateTimePicker dateBirthDate;
        private Label lblGender;
        private Label lblBirthDate;
        private TextBox txtCity;
        private ComboBox cmbGender;
        private Button btnCancel;
        private TextBox txtUzmanlik;
        private OpenFileDialog openFileDialog1;
        private ComboBox cmbEgitim;
        private TextBox txtUniversite;
        private CustomButton btnRegister;
        private TextBox txtAd;
        private Button btnKayit;
    }
}