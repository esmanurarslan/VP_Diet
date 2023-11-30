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
            btnCancel = new Button();
            btnKayıtOl = new Button();
            txtBSertifikalar = new TextBox();
            txtBProf = new TextBox();
            txtBEgitimDurumu = new TextBox();
            txtBCity = new TextBox();
            cmbBGender = new ComboBox();
            dateTPBirthDate = new DateTimePicker();
            lblCity = new Label();
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
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnKayıtOl);
            panel1.Controls.Add(txtBSertifikalar);
            panel1.Controls.Add(txtBProf);
            panel1.Controls.Add(txtBEgitimDurumu);
            panel1.Controls.Add(txtBCity);
            panel1.Controls.Add(cmbBGender);
            panel1.Controls.Add(dateTPBirthDate);
            panel1.Controls.Add(lblCity);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblBirthDate);
            panel1.Controls.Add(txtBParolaTekrar);
            panel1.Controls.Add(txtBParola);
            panel1.Controls.Add(txtBUser);
            panel1.Controls.Add(txtBEposta);
            panel1.Controls.Add(lblKayitOl);
            panel1.Location = new Point(216, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 1055);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(230, 964);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
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
            btnKayıtOl.Location = new Point(159, 873);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(288, 75);
            btnKayıtOl.TabIndex = 14;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = false;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // txtBSertifikalar
            // 
            txtBSertifikalar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBSertifikalar.Location = new Point(58, 798);
            txtBSertifikalar.Name = "txtBSertifikalar";
            txtBSertifikalar.PlaceholderText = "Sertifikalar";
            txtBSertifikalar.Size = new Size(465, 43);
            txtBSertifikalar.TabIndex = 13;
            txtBSertifikalar.Click += txtBSertifikalar_Click;
            // 
            // txtBProf
            // 
            txtBProf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBProf.Location = new Point(58, 729);
            txtBProf.Name = "txtBProf";
            txtBProf.PlaceholderText = "Uzmanlık";
            txtBProf.Size = new Size(465, 43);
            txtBProf.TabIndex = 12;
            // 
            // txtBEgitimDurumu
            // 
            txtBEgitimDurumu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBEgitimDurumu.Location = new Point(58, 657);
            txtBEgitimDurumu.Name = "txtBEgitimDurumu";
            txtBEgitimDurumu.PlaceholderText = "Eğitim Durumu";
            txtBEgitimDurumu.Size = new Size(465, 43);
            txtBEgitimDurumu.TabIndex = 11;
            // 
            // txtBCity
            // 
            txtBCity.Location = new Point(422, 553);
            txtBCity.Name = "txtBCity";
            txtBCity.Size = new Size(132, 39);
            txtBCity.TabIndex = 10;
            // 
            // cmbBGender
            // 
            cmbBGender.FormattingEnabled = true;
            cmbBGender.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cmbBGender.Location = new Point(249, 553);
            cmbBGender.Name = "cmbBGender";
            cmbBGender.Size = new Size(131, 40);
            cmbBGender.TabIndex = 9;
            // 
            // dateTPBirthDate
            // 
            dateTPBirthDate.Location = new Point(44, 554);
            dateTPBirthDate.Name = "dateTPBirthDate";
            dateTPBirthDate.Size = new Size(185, 39);
            dateTPBirthDate.TabIndex = 8;
            dateTPBirthDate.Value = new DateTime(2023, 11, 30, 0, 0, 0, 0);
            dateTPBirthDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.Location = new Point(442, 526);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(57, 25);
            lblCity.TabIndex = 7;
            lblCity.Text = "Şehir";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(261, 526);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(81, 25);
            lblGender.TabIndex = 6;
            lblGender.Text = "Cinsiyet";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthDate.Location = new Point(58, 526);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(132, 25);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Doğum Tarihi";
            // 
            // txtBParolaTekrar
            // 
            txtBParolaTekrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBParolaTekrar.Location = new Point(58, 370);
            txtBParolaTekrar.Name = "txtBParolaTekrar";
            txtBParolaTekrar.PasswordChar = '*';
            txtBParolaTekrar.PlaceholderText = "Parola Tekrar";
            txtBParolaTekrar.Size = new Size(465, 43);
            txtBParolaTekrar.TabIndex = 4;
            // 
            // txtBParola
            // 
            txtBParola.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBParola.Location = new Point(58, 295);
            txtBParola.Name = "txtBParola";
            txtBParola.PasswordChar = '*';
            txtBParola.PlaceholderText = "Parola";
            txtBParola.Size = new Size(465, 43);
            txtBParola.TabIndex = 3;
            // 
            // txtBUser
            // 
            txtBUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBUser.Location = new Point(58, 225);
            txtBUser.Name = "txtBUser";
            txtBUser.PlaceholderText = "Kullanıcı Adı";
            txtBUser.Size = new Size(465, 43);
            txtBUser.TabIndex = 2;
            // 
            // txtBEposta
            // 
            txtBEposta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBEposta.Location = new Point(58, 158);
            txtBEposta.Name = "txtBEposta";
            txtBEposta.PlaceholderText = "E-posta";
            txtBEposta.Size = new Size(465, 43);
            txtBEposta.TabIndex = 1;
            // 
            // lblKayitOl
            // 
            lblKayitOl.AutoSize = true;
            lblKayitOl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblKayitOl.Location = new Point(44, 50);
            lblKayitOl.Name = "lblKayitOl";
            lblKayitOl.Size = new Size(223, 65);
            lblKayitOl.TabIndex = 0;
            lblKayitOl.Text = "Kayıt Ol!";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1061, 1165);
            Controls.Add(panel1);
            Name = "Form5";
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
        private Label lblCity;
        private Label lblGender;
        private Label lblBirthDate;
        private TextBox txtBCity;
        private ComboBox cmbBGender;
        private Button btnCancel;
        private Button btnKayıtOl;
        private TextBox txtBSertifikalar;
        private TextBox txtBProf;
        private TextBox txtBEgitimDurumu;
        private OpenFileDialog openFileDialog1;
    }
}