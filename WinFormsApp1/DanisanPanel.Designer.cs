
namespace WinFormsApp1
{
    partial class DanisanPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanisanPanel));
            leftPanel = new Panel();
            circularPictureBox1 = new CircularPictureBox();
            lblMail = new Label();
            lblGun = new Label();
            rateLbl = new LinkLabel();
            diyetisyenMailLbl = new LinkLabel();
            label12 = new Label();
            diyetisyenLbl = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            lblKullaniciAdi = new Label();
            label8 = new Label();
            btnParola = new Button();
            btnGüncelle = new Button();
            rightPanel = new Panel();
            btnArama = new Button();
            txtArama = new TextBox();
            middlePanel1 = new Panel();
            grafikPanel4 = new Panel();
            grafikPanel3 = new Panel();
            grafikPanel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            grafikPanel1 = new Panel();
            humanBodyPanel = new Panel();
            lblBoy = new Label();
            lblBel = new Label();
            lblKalca = new Label();
            lblGogus = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            rightPanel.SuspendLayout();
            middlePanel1.SuspendLayout();
            humanBodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(216, 232, 227);
            leftPanel.Controls.Add(circularPictureBox1);
            leftPanel.Controls.Add(lblMail);
            leftPanel.Controls.Add(lblGun);
            leftPanel.Controls.Add(rateLbl);
            leftPanel.Controls.Add(diyetisyenMailLbl);
            leftPanel.Controls.Add(label12);
            leftPanel.Controls.Add(diyetisyenLbl);
            leftPanel.Controls.Add(label11);
            leftPanel.Controls.Add(label10);
            leftPanel.Controls.Add(label9);
            leftPanel.Controls.Add(lblKullaniciAdi);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(btnParola);
            leftPanel.Controls.Add(btnGüncelle);
            leftPanel.Location = new Point(0, 1);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(260, 640);
            leftPanel.TabIndex = 0;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(12, 42);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(65, 62);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 27;
            circularPictureBox1.TabStop = false;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(12, 164);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(17, 20);
            lblMail.TabIndex = 26;
            lblMail.Text = "a";
            // 
            // lblGun
            // 
            lblGun.AutoSize = true;
            lblGun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGun.Location = new Point(40, 204);
            lblGun.Name = "lblGun";
            lblGun.Size = new Size(9, 20);
            lblGun.TabIndex = 25;
            lblGun.Text = "\r\n";
            // 
            // rateLbl
            // 
            rateLbl.AutoSize = true;
            rateLbl.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            rateLbl.LinkColor = Color.FromArgb(70, 125, 106);
            rateLbl.Location = new Point(111, 341);
            rateLbl.Name = "rateLbl";
            rateLbl.Size = new Size(146, 17);
            rateLbl.TabIndex = 24;
            rateLbl.TabStop = true;
            rateLbl.Text = "Diyetisyeni Değerlendir!";
            // 
            // diyetisyenMailLbl
            // 
            diyetisyenMailLbl.AutoSize = true;
            diyetisyenMailLbl.LinkColor = Color.Black;
            diyetisyenMailLbl.Location = new Point(24, 308);
            diyetisyenMailLbl.Name = "diyetisyenMailLbl";
            diyetisyenMailLbl.Size = new Size(188, 20);
            diyetisyenMailLbl.TabIndex = 23;
            diyetisyenMailLbl.TabStop = true;
            diyetisyenMailLbl.Text = "diyetisyenmail@gmail.com";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(24, 261);
            label12.Name = "label12";
            label12.Size = new Size(93, 23);
            label12.TabIndex = 22;
            label12.Text = "Diyetisyen";
            // 
            // diyetisyenLbl
            // 
            diyetisyenLbl.AutoSize = true;
            diyetisyenLbl.Location = new Point(24, 284);
            diyetisyenLbl.Name = "diyetisyenLbl";
            diyetisyenLbl.Size = new Size(113, 20);
            diyetisyenLbl.TabIndex = 21;
            diyetisyenLbl.Text = "diyetisyen@123";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 224);
            label11.Name = "label11";
            label11.Size = new Size(231, 20);
            label11.TabIndex = 19;
            label11.Text = "-------------------------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 184);
            label10.Name = "label10";
            label10.Size = new Size(231, 20);
            label10.TabIndex = 18;
            label10.Text = "-------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 204);
            label9.Name = "label9";
            label9.Size = new Size(172, 20);
            label9.TabIndex = 17;
            label9.Text = "  gündür programdasınız";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(12, 144);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(17, 20);
            lblKullaniciAdi.TabIndex = 5;
            lblKullaniciAdi.Text = "a";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 121);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 3;
            label8.Text = "Kullanıcı Adı";
            // 
            // btnParola
            // 
            btnParola.BackColor = Color.Silver;
            btnParola.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnParola.ForeColor = SystemColors.ButtonHighlight;
            btnParola.Location = new Point(24, 558);
            btnParola.Name = "btnParola";
            btnParola.Size = new Size(206, 48);
            btnParola.TabIndex = 15;
            btnParola.Text = "Parola Değiştir";
            btnParola.UseVisualStyleBackColor = false;
            btnParola.Click += btnParola_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.Silver;
            btnGüncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGüncelle.ForeColor = SystemColors.ButtonHighlight;
            btnGüncelle.Location = new Point(24, 504);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(206, 48);
            btnGüncelle.TabIndex = 14;
            btnGüncelle.Text = "Bilgileri Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGuncelle_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(216, 232, 227);
            rightPanel.Controls.Add(btnArama);
            rightPanel.Controls.Add(txtArama);
            rightPanel.Location = new Point(847, 1);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(260, 640);
            rightPanel.TabIndex = 1;
            // 
            // btnArama
            // 
            btnArama.Image = (Image)resources.GetObject("btnArama.Image");
            btnArama.Location = new Point(202, 25);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(29, 27);
            btnArama.TabIndex = 4;
            btnArama.UseVisualStyleBackColor = true;
            btnArama.Click += btnArama_Click;
            // 
            // txtArama
            // 
            txtArama.BackColor = Color.FromArgb(233, 233, 233);
            txtArama.Location = new Point(10, 25);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(186, 27);
            txtArama.TabIndex = 3;
            txtArama.Text = "Diyetisyen Ara";
            // 
            // middlePanel1
            // 
            middlePanel1.BackColor = Color.FromArgb(216, 232, 227);
            middlePanel1.Controls.Add(grafikPanel4);
            middlePanel1.Controls.Add(grafikPanel3);
            middlePanel1.Controls.Add(grafikPanel2);
            middlePanel1.Controls.Add(label2);
            middlePanel1.Controls.Add(label1);
            middlePanel1.Controls.Add(grafikPanel1);
            middlePanel1.Controls.Add(humanBodyPanel);
            middlePanel1.Location = new Point(275, 26);
            middlePanel1.Name = "middlePanel1";
            middlePanel1.Size = new Size(555, 589);
            middlePanel1.TabIndex = 2;
            // 
            // grafikPanel4
            // 
            grafikPanel4.BackColor = Color.White;
            grafikPanel4.Location = new Point(195, 445);
            grafikPanel4.Name = "grafikPanel4";
            grafikPanel4.Size = new Size(342, 120);
            grafikPanel4.TabIndex = 10;
            // 
            // grafikPanel3
            // 
            grafikPanel3.BackColor = Color.White;
            grafikPanel3.Location = new Point(195, 319);
            grafikPanel3.Name = "grafikPanel3";
            grafikPanel3.Size = new Size(342, 120);
            grafikPanel3.TabIndex = 9;
            // 
            // grafikPanel2
            // 
            grafikPanel2.BackColor = Color.White;
            grafikPanel2.Location = new Point(195, 193);
            grafikPanel2.Name = "grafikPanel2";
            grafikPanel2.Size = new Size(342, 120);
            grafikPanel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(195, 36);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 7;
            label2.Text = "Grafikler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 4;
            label1.Text = "Gelişimim";
            // 
            // grafikPanel1
            // 
            grafikPanel1.BackColor = Color.White;
            grafikPanel1.Location = new Point(195, 67);
            grafikPanel1.Name = "grafikPanel1";
            grafikPanel1.Size = new Size(342, 120);
            grafikPanel1.TabIndex = 1;
            // 
            // humanBodyPanel
            // 
            humanBodyPanel.BackColor = Color.White;
            humanBodyPanel.Controls.Add(lblBoy);
            humanBodyPanel.Controls.Add(lblBel);
            humanBodyPanel.Controls.Add(lblKalca);
            humanBodyPanel.Controls.Add(lblGogus);
            humanBodyPanel.Controls.Add(pictureBox1);
            humanBodyPanel.Controls.Add(label7);
            humanBodyPanel.Controls.Add(label6);
            humanBodyPanel.Controls.Add(label5);
            humanBodyPanel.Controls.Add(label4);
            humanBodyPanel.Controls.Add(label3);
            humanBodyPanel.Location = new Point(23, 67);
            humanBodyPanel.Name = "humanBodyPanel";
            humanBodyPanel.Size = new Size(166, 460);
            humanBodyPanel.TabIndex = 0;
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(90, 269);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(61, 20);
            lblBoy.TabIndex = 23;
            lblBoy.Text = "163 cm ";
            // 
            // lblBel
            // 
            lblBel.AutoSize = true;
            lblBel.Location = new Point(13, 338);
            lblBel.Name = "lblBel";
            lblBel.Size = new Size(49, 20);
            lblBel.TabIndex = 24;
            lblBel.Text = "60 cm";
            lblBel.Click += belLbl_Click;
            // 
            // lblKalca
            // 
            lblKalca.AutoSize = true;
            lblKalca.Location = new Point(90, 338);
            lblKalca.Name = "lblKalca";
            lblKalca.Size = new Size(49, 20);
            lblKalca.TabIndex = 25;
            lblKalca.Text = "88 cm";
            // 
            // lblGogus
            // 
            lblGogus.AutoSize = true;
            lblGogus.Location = new Point(13, 412);
            lblGogus.Name = "lblGogus";
            lblGogus.Size = new Size(49, 20);
            lblGogus.TabIndex = 26;
            lblGogus.Text = "70 cm";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 390);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 7;
            label7.Text = "Göğüs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 318);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 6;
            label6.Text = "Kalça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 318);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 5;
            label5.Text = "Bel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 249);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "Boy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 249);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 3;
            label3.Text = "Kilo";
            // 
            // DanisanPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1110, 641);
            Controls.Add(middlePanel1);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "DanisanPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanisanPanel";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            middlePanel1.ResumeLayout(false);
            middlePanel1.PerformLayout();
            humanBodyPanel.ResumeLayout(false);
            humanBodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Panel middlePanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel humanBodyPanel;
        private Panel grafikPanel1;
        private Label label2;
        private Label label1;
        private Button btnGüncelle;
        private Panel grafikPanel4;
        private Panel grafikPanel3;
        private Panel grafikPanel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private CircularPictureBox circularPictureBox;
        private Button btnParola;
        private Button btnArama;
        private TextBox txtArama;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CircularPictureBox circularPictureBox1;
        private Label label8;
        private Label lblKullaniciAdi;
        private Label label9;
        private Label label12;
        private Label diyetisyenLbl;
        private Label label11;
        private Label label10;
        private Label lblKilo;
        private Label lblBoy;
        private Label lblBel;
        private Label lblKalca;
        private Label lblGogus;
        private LinkLabel diyetisyenMailLbl;
        private LinkLabel rateLbl;
        private Label lblMail;
        private Label lblGun;

        public Label LblKilo { get => lblKilo; set => lblKilo = value; }
    }
}