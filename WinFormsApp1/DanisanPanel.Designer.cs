
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
            btnSil = new Button();
            lblBmi = new Label();
            label14 = new Label();
            label15 = new Label();
            label13 = new Label();
            label10 = new Label();
            lblTarget = new Label();
            label8 = new Label();
            lblMail = new Label();
            lblUser = new Label();
            lblGun = new Label();
            btnSayfaYenile = new Button();
            diyetisyenMailLbl = new LinkLabel();
            label12 = new Label();
            diyetisyenLbl = new Label();
            label11 = new Label();
            label9 = new Label();
            btnParola = new Button();
            btnGüncelle = new Button();
            middlePanel1 = new Panel();
            grafikPanel4 = new Panel();
            grafikPanel3 = new Panel();
            grafikPanel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            grafikPanel1 = new Panel();
            humanBodyPanel = new Panel();
            lblGogus = new Label();
            lblKalca = new Label();
            lblBel = new Label();
            lblBoy = new Label();
            kiloLbl = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            middlePanel1.SuspendLayout();
            humanBodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(216, 232, 227);
            leftPanel.Controls.Add(circularPictureBox1);
            leftPanel.Controls.Add(btnSil);
            leftPanel.Controls.Add(lblBmi);
            leftPanel.Controls.Add(label14);
            leftPanel.Controls.Add(label15);
            leftPanel.Controls.Add(label13);
            leftPanel.Controls.Add(label10);
            leftPanel.Controls.Add(lblTarget);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(lblMail);
            leftPanel.Controls.Add(lblUser);
            leftPanel.Controls.Add(lblGun);
            leftPanel.Controls.Add(btnSayfaYenile);
            leftPanel.Controls.Add(diyetisyenMailLbl);
            leftPanel.Controls.Add(label12);
            leftPanel.Controls.Add(diyetisyenLbl);
            leftPanel.Controls.Add(label11);
            leftPanel.Controls.Add(label9);
            leftPanel.Controls.Add(btnParola);
            leftPanel.Controls.Add(btnGüncelle);
            leftPanel.Location = new Point(0, 2);
            leftPanel.Margin = new Padding(5, 5, 5, 5);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(422, 1024);
            leftPanel.TabIndex = 0;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(20, 40);
            circularPictureBox1.Margin = new Padding(5, 5, 5, 5);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(102, 99);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circularPictureBox1.TabIndex = 49;
            circularPictureBox1.TabStop = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Silver;
            btnSil.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = SystemColors.ButtonHighlight;
            btnSil.Location = new Point(216, 624);
            btnSil.Margin = new Padding(5, 5, 5, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(158, 42);
            btnSil.TabIndex = 48;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lblBmi
            // 
            lblBmi.AutoSize = true;
            lblBmi.Location = new Point(28, 419);
            lblBmi.Margin = new Padding(5, 0, 5, 0);
            lblBmi.Name = "lblBmi";
            lblBmi.Size = new Size(36, 32);
            lblBmi.TabIndex = 47;
            lblBmi.Text = "M";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 656);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(384, 32);
            label14.TabIndex = 46;
            label14.Text = "-------------------------------------";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 451);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(384, 32);
            label15.TabIndex = 44;
            label15.Text = "-------------------------------------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 381);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(384, 32);
            label13.TabIndex = 43;
            label13.Text = "-------------------------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 349);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(128, 32);
            label10.TabIndex = 42;
            label10.Text = "Hedefiniz :";
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarget.Location = new Point(184, 349);
            lblTarget.Margin = new Padding(5, 0, 5, 0);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(26, 32);
            lblTarget.TabIndex = 41;
            lblTarget.Text = "x";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 307);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(384, 32);
            label8.TabIndex = 40;
            label8.Text = "-------------------------------------";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(28, 208);
            lblMail.Margin = new Padding(5, 0, 5, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(36, 32);
            lblMail.TabIndex = 39;
            lblMail.Text = "M";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(28, 176);
            lblUser.Margin = new Padding(5, 0, 5, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(31, 32);
            lblUser.TabIndex = 38;
            lblUser.Text = "U";
            // 
            // lblGun
            // 
            lblGun.AutoSize = true;
            lblGun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGun.Location = new Point(55, 275);
            lblGun.Margin = new Padding(5, 0, 5, 0);
            lblGun.Name = "lblGun";
            lblGun.Size = new Size(26, 32);
            lblGun.TabIndex = 37;
            lblGun.Text = "x";
            // 
            // btnSayfaYenile
            // 
            btnSayfaYenile.BackColor = Color.Silver;
            btnSayfaYenile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSayfaYenile.ForeColor = SystemColors.ButtonHighlight;
            btnSayfaYenile.Location = new Point(39, 928);
            btnSayfaYenile.Margin = new Padding(5, 5, 5, 5);
            btnSayfaYenile.Name = "btnSayfaYenile";
            btnSayfaYenile.Size = new Size(335, 77);
            btnSayfaYenile.TabIndex = 36;
            btnSayfaYenile.Text = "Sayfa Yenile";
            btnSayfaYenile.UseVisualStyleBackColor = false;
            btnSayfaYenile.Click += btnSayfaYenile_Click;
            // 
            // diyetisyenMailLbl
            // 
            diyetisyenMailLbl.AutoSize = true;
            diyetisyenMailLbl.LinkColor = Color.Black;
            diyetisyenMailLbl.Location = new Point(28, 566);
            diyetisyenMailLbl.Margin = new Padding(5, 0, 5, 0);
            diyetisyenMailLbl.Name = "diyetisyenMailLbl";
            diyetisyenMailLbl.Size = new Size(300, 32);
            diyetisyenMailLbl.TabIndex = 23;
            diyetisyenMailLbl.TabStop = true;
            diyetisyenMailLbl.Text = "diyetisyenmail@gmail.com";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(28, 491);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(179, 38);
            label12.TabIndex = 22;
            label12.Text = "Diyetisyenim";
            // 
            // diyetisyenLbl
            // 
            diyetisyenLbl.AutoSize = true;
            diyetisyenLbl.Location = new Point(28, 528);
            diyetisyenLbl.Margin = new Padding(5, 0, 5, 0);
            diyetisyenLbl.Name = "diyetisyenLbl";
            diyetisyenLbl.Size = new Size(184, 32);
            diyetisyenLbl.TabIndex = 21;
            diyetisyenLbl.Text = "diyetisyen@123";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 240);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(384, 32);
            label11.TabIndex = 19;
            label11.Text = "-------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(84, 275);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(277, 32);
            label9.TabIndex = 17;
            label9.Text = "  gündür programdasınız";
            // 
            // btnParola
            // 
            btnParola.BackColor = Color.Silver;
            btnParola.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnParola.ForeColor = SystemColors.ButtonHighlight;
            btnParola.Location = new Point(39, 838);
            btnParola.Margin = new Padding(5, 5, 5, 5);
            btnParola.Name = "btnParola";
            btnParola.Size = new Size(335, 77);
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
            btnGüncelle.Location = new Point(39, 752);
            btnGüncelle.Margin = new Padding(5, 5, 5, 5);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(335, 77);
            btnGüncelle.TabIndex = 14;
            btnGüncelle.Text = "Bilgileri Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGuncelle_Click;
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
            middlePanel1.Location = new Point(447, 42);
            middlePanel1.Margin = new Padding(5, 5, 5, 5);
            middlePanel1.Name = "middlePanel1";
            middlePanel1.Size = new Size(902, 942);
            middlePanel1.TabIndex = 2;
            // 
            // grafikPanel4
            // 
            grafikPanel4.BackColor = Color.White;
            grafikPanel4.Location = new Point(317, 712);
            grafikPanel4.Margin = new Padding(5, 5, 5, 5);
            grafikPanel4.Name = "grafikPanel4";
            grafikPanel4.Size = new Size(556, 192);
            grafikPanel4.TabIndex = 10;
            // 
            // grafikPanel3
            // 
            grafikPanel3.BackColor = Color.White;
            grafikPanel3.Location = new Point(317, 510);
            grafikPanel3.Margin = new Padding(5, 5, 5, 5);
            grafikPanel3.Name = "grafikPanel3";
            grafikPanel3.Size = new Size(556, 192);
            grafikPanel3.TabIndex = 9;
            // 
            // grafikPanel2
            // 
            grafikPanel2.BackColor = Color.White;
            grafikPanel2.Location = new Point(317, 309);
            grafikPanel2.Margin = new Padding(5, 5, 5, 5);
            grafikPanel2.Name = "grafikPanel2";
            grafikPanel2.Size = new Size(556, 192);
            grafikPanel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(317, 58);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 45);
            label2.TabIndex = 7;
            label2.Text = "Grafikler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 60);
            label1.TabIndex = 4;
            label1.Text = "Gelişimim";
            // 
            // grafikPanel1
            // 
            grafikPanel1.BackColor = Color.White;
            grafikPanel1.Location = new Point(317, 107);
            grafikPanel1.Margin = new Padding(5, 5, 5, 5);
            grafikPanel1.Name = "grafikPanel1";
            grafikPanel1.Size = new Size(556, 192);
            grafikPanel1.TabIndex = 1;
            // 
            // humanBodyPanel
            // 
            humanBodyPanel.BackColor = Color.White;
            humanBodyPanel.Controls.Add(lblGogus);
            humanBodyPanel.Controls.Add(lblKalca);
            humanBodyPanel.Controls.Add(lblBel);
            humanBodyPanel.Controls.Add(lblBoy);
            humanBodyPanel.Controls.Add(kiloLbl);
            humanBodyPanel.Controls.Add(pictureBox1);
            humanBodyPanel.Controls.Add(label7);
            humanBodyPanel.Controls.Add(label6);
            humanBodyPanel.Controls.Add(label5);
            humanBodyPanel.Controls.Add(label4);
            humanBodyPanel.Controls.Add(label3);
            humanBodyPanel.Location = new Point(37, 107);
            humanBodyPanel.Margin = new Padding(5, 5, 5, 5);
            humanBodyPanel.Name = "humanBodyPanel";
            humanBodyPanel.Size = new Size(270, 797);
            humanBodyPanel.TabIndex = 0;
            // 
            // lblGogus
            // 
            lblGogus.AutoSize = true;
            lblGogus.Location = new Point(26, 670);
            lblGogus.Margin = new Padding(5, 0, 5, 0);
            lblGogus.Name = "lblGogus";
            lblGogus.Size = new Size(78, 32);
            lblGogus.TabIndex = 12;
            lblGogus.Text = "label8";
            // 
            // lblKalca
            // 
            lblKalca.AutoSize = true;
            lblKalca.Location = new Point(146, 563);
            lblKalca.Margin = new Padding(5, 0, 5, 0);
            lblKalca.Name = "lblKalca";
            lblKalca.Size = new Size(78, 32);
            lblKalca.TabIndex = 11;
            lblKalca.Text = "label8";
            // 
            // lblBel
            // 
            lblBel.AutoSize = true;
            lblBel.Location = new Point(23, 558);
            lblBel.Margin = new Padding(5, 0, 5, 0);
            lblBel.Name = "lblBel";
            lblBel.Size = new Size(78, 32);
            lblBel.TabIndex = 10;
            lblBel.Text = "label8";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(138, 443);
            lblBoy.Margin = new Padding(5, 0, 5, 0);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(78, 32);
            lblBoy.TabIndex = 9;
            lblBoy.Text = "label8";
            // 
            // kiloLbl
            // 
            kiloLbl.AutoSize = true;
            kiloLbl.Location = new Point(26, 443);
            kiloLbl.Margin = new Padding(5, 0, 5, 0);
            kiloLbl.Name = "kiloLbl";
            kiloLbl.Size = new Size(78, 32);
            kiloLbl.TabIndex = 8;
            kiloLbl.Text = "label8";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 624);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 7;
            label7.Text = "Göğüs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(146, 509);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 32);
            label6.TabIndex = 6;
            label6.Text = "Kalça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 509);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 32);
            label5.TabIndex = 5;
            label5.Text = "Bel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(146, 398);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 32);
            label4.TabIndex = 4;
            label4.Text = "Boy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 398);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 3;
            label3.Text = "Kilo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(216, 232, 227);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(1382, 0);
            flowLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(422, 1026);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // DanisanPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1804, 1026);
            Controls.Add(middlePanel1);
            Controls.Add(leftPanel);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "DanisanPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanisanPanel";
            Load += DanisanPanel_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            middlePanel1.ResumeLayout(false);
            middlePanel1.PerformLayout();
            humanBodyPanel.ResumeLayout(false);
            humanBodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel leftPanel;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CircularPictureBox circularPictureBox1;

        private Label label9;
        private Label label12;
        private Label diyetisyenLbl;
        private Label label11;
        private Label label10;
        private Label kiloLbl;
        private Label lblGogus;
        private Label lblKalca;
        private Label lblBel;
        private Label lblBoy;
        private Button btnSayfaYenile;
        private LinkLabel diyetisyenMailLbl;

        private Label kilolbl;
        private Label lblGun;
        private Label lblUser;
        private Label label15;
        private Label label13;
        private Label lblTarget;
        private Label label8;
        private Label lblMail;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label14;
        private Label lblBmi;
        private Button btnSil;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}