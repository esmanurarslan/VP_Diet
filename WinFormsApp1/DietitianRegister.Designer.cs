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
            txtUniversite = new TextBox();
            cmbEgitim = new ComboBox();
            label1 = new Label();
            txtUlke = new TextBox();
            btnCancel = new Button();
            btnKayıtOl = new Button();
            txtBProf = new TextBox();
            txtBCity = new TextBox();
            cmbBGender = new ComboBox();
            dateTPBirthDate = new DateTimePicker();
            lblGender = new Label();
            lblBirthDate = new Label();
            txtBParolaTekrar = new TextBox();
            txtBParola = new TextBox();
            txtBUser = new TextBox();
            txtBEposta = new TextBox();
            lblKayitOl = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 251, 249);
            panel1.Controls.Add(txtUniversite);
            panel1.Controls.Add(cmbEgitim);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUlke);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnKayıtOl);
            panel1.Controls.Add(txtBProf);
            panel1.Controls.Add(txtBCity);
            panel1.Controls.Add(cmbBGender);
            panel1.Controls.Add(dateTPBirthDate);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblBirthDate);
            panel1.Controls.Add(txtBParolaTekrar);
            panel1.Controls.Add(txtBParola);
            panel1.Controls.Add(txtBUser);
            panel1.Controls.Add(txtBEposta);
            panel1.Controls.Add(lblKayitOl);
            panel1.Location = new Point(27, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 659);
            panel1.TabIndex = 0;
            // 
            // txtUniversite
            // 
            txtUniversite.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUniversite.Location = new Point(36, 422);
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
            cmbEgitim.Location = new Point(37, 380);
            cmbEgitim.Name = "cmbEgitim";
            cmbEgitim.Size = new Size(287, 31);
            cmbEgitim.TabIndex = 19;
            cmbEgitim.Text = "Eğitim Durumu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 640);
            label1.Name = "label1";
            label1.Size = new Size(306, 17);
            label1.TabIndex = 18;
            label1.Text = "*Kullanıcı adı olarak Ad-Soyad girilmesi mecburidir.";
            label1.Click += label1_Click;
            // 
            // txtUlke
            // 
            txtUlke.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUlke.Location = new Point(178, 338);
            txtUlke.Margin = new Padding(2);
            txtUlke.Name = "txtUlke";
            txtUlke.PlaceholderText = "Ülke";
            txtUlke.Size = new Size(146, 30);
            txtUlke.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(142, 588);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "İptal Et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.BackColor = Color.FromArgb(165, 215, 198);
            btnKayıtOl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayıtOl.ForeColor = Color.Transparent;
            btnKayıtOl.Location = new Point(92, 522);
            btnKayıtOl.Margin = new Padding(2);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(177, 47);
            btnKayıtOl.TabIndex = 14;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = false;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // txtBProf
            // 
            txtBProf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBProf.Location = new Point(36, 470);
            txtBProf.Margin = new Padding(2);
            txtBProf.Name = "txtBProf";
            txtBProf.PlaceholderText = "Uzmanlık";
            txtBProf.Size = new Size(288, 30);
            txtBProf.TabIndex = 12;
            // 
            // txtBCity
            // 
            txtBCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBCity.Location = new Point(36, 338);
            txtBCity.Margin = new Padding(2);
            txtBCity.Name = "txtBCity";
            txtBCity.PlaceholderText = "Şehir";
            txtBCity.Size = new Size(138, 30);
            txtBCity.TabIndex = 10;
            // 
            // cmbBGender
            // 
            cmbBGender.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBGender.FormattingEnabled = true;
            cmbBGender.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbBGender.Location = new Point(201, 296);
            cmbBGender.Margin = new Padding(2);
            cmbBGender.Name = "cmbBGender";
            cmbBGender.Size = new Size(123, 28);
            cmbBGender.TabIndex = 9;
            // 
            // dateTPBirthDate
            // 
            dateTPBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTPBirthDate.Location = new Point(40, 296);
            dateTPBirthDate.Margin = new Padding(2);
            dateTPBirthDate.Name = "dateTPBirthDate";
            dateTPBirthDate.Size = new Size(157, 27);
            dateTPBirthDate.TabIndex = 8;
            dateTPBirthDate.Value = new DateTime(2023, 11, 30, 0, 0, 0, 0);
            dateTPBirthDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(201, 274);
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
            lblBirthDate.Location = new Point(40, 274);
            lblBirthDate.Margin = new Padding(2, 0, 2, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(102, 20);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Doğum Tarihi";
            // 
            // txtBParolaTekrar
            // 
            txtBParolaTekrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBParolaTekrar.Location = new Point(36, 231);
            txtBParolaTekrar.Margin = new Padding(2);
            txtBParolaTekrar.Name = "txtBParolaTekrar";
            txtBParolaTekrar.PasswordChar = '*';
            txtBParolaTekrar.PlaceholderText = "Parola Tekrar";
            txtBParolaTekrar.Size = new Size(288, 30);
            txtBParolaTekrar.TabIndex = 4;
            // 
            // txtBParola
            // 
            txtBParola.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBParola.Location = new Point(36, 184);
            txtBParola.Margin = new Padding(2);
            txtBParola.Name = "txtBParola";
            txtBParola.PasswordChar = '*';
            txtBParola.PlaceholderText = "Parola";
            txtBParola.Size = new Size(288, 30);
            txtBParola.TabIndex = 3;
            // 
            // txtBUser
            // 
            txtBUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBUser.Location = new Point(36, 141);
            txtBUser.Margin = new Padding(2);
            txtBUser.Name = "txtBUser";
            txtBUser.PlaceholderText = "Kullanıcı Adı*";
            txtBUser.Size = new Size(288, 30);
            txtBUser.TabIndex = 2;
            // 
            // txtBEposta
            // 
            txtBEposta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBEposta.Location = new Point(36, 99);
            txtBEposta.Margin = new Padding(2);
            txtBEposta.Name = "txtBEposta";
            txtBEposta.PlaceholderText = "E-posta";
            txtBEposta.Size = new Size(288, 30);
            txtBEposta.TabIndex = 1;
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
        private TextBox txtBEposta;
        private Label lblKayitOl;
        private TextBox txtBParolaTekrar;
        private TextBox txtBParola;
        private TextBox txtBUser;
        private DateTimePicker dateTPBirthDate;
        private Label lblGender;
        private Label lblBirthDate;
        private TextBox txtBCity;
        private ComboBox cmbBGender;
        private Button btnCancel;
        private Button btnKayıtOl;
        private TextBox txtBProf;
        private OpenFileDialog openFileDialog1;
        private TextBox txtUlke;
        private Label label1;
        private ComboBox cmbEgitim;
        private TextBox txtUniversite;
    }
}