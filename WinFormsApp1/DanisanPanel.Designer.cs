
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
            cstmbtnsil = new CustomButton();
            btnCikisYap = new CustomButton();
            btnRefresh = new CustomButton();
            btnGuncelle = new CustomButton();
            btnResetPassword = new CustomButton();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            circularPictureBox1 = new CircularPictureBox();
            lblBmi = new Label();
            label10 = new Label();
            lblTarget = new Label();
            lblMail = new Label();
            lblUser = new Label();
            lblGun = new Label();
            diyetisyenMailLbl = new LinkLabel();
            label12 = new Label();
            diyetisyenLbl = new Label();
            label9 = new Label();
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
            leftPanel.Controls.Add(cstmbtnsil);
            leftPanel.Controls.Add(btnCikisYap);
            leftPanel.Controls.Add(btnRefresh);
            leftPanel.Controls.Add(btnGuncelle);
            leftPanel.Controls.Add(btnResetPassword);
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel4);
            leftPanel.Controls.Add(panel3);
            leftPanel.Controls.Add(panel1);
            leftPanel.Controls.Add(panel2);
            leftPanel.Controls.Add(circularPictureBox1);
            leftPanel.Controls.Add(lblBmi);
            leftPanel.Controls.Add(label10);
            leftPanel.Controls.Add(lblTarget);
            leftPanel.Controls.Add(lblMail);
            leftPanel.Controls.Add(lblUser);
            leftPanel.Controls.Add(lblGun);
            leftPanel.Controls.Add(diyetisyenMailLbl);
            leftPanel.Controls.Add(label12);
            leftPanel.Controls.Add(diyetisyenLbl);
            leftPanel.Controls.Add(label9);
            leftPanel.Location = new Point(0, 1);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(260, 640);
            leftPanel.TabIndex = 0;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // cstmbtnsil
            // 
            cstmbtnsil.BackColor = Color.Gray;
            cstmbtnsil.FlatAppearance.BorderSize = 0;
            cstmbtnsil.FlatStyle = FlatStyle.Flat;
            cstmbtnsil.ForeColor = Color.White;
            cstmbtnsil.Location = new Point(153, 363);
            cstmbtnsil.Margin = new Padding(3, 4, 3, 4);
            cstmbtnsil.Name = "cstmbtnsil";
            cstmbtnsil.Size = new Size(90, 26);
            cstmbtnsil.TabIndex = 60;
            cstmbtnsil.Text = "Sil";
            cstmbtnsil.UseVisualStyleBackColor = false;
            cstmbtnsil.Click += cstmbtnsil_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Gray;
            btnCikisYap.FlatAppearance.BorderSize = 0;
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.ForeColor = Color.White;
            btnCikisYap.Location = new Point(48, 572);
            btnCikisYap.Margin = new Padding(3, 4, 3, 4);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(176, 46);
            btnCikisYap.TabIndex = 59;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(48, 518);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(176, 46);
            btnRefresh.TabIndex = 58;
            btnRefresh.Text = "Sayfayı Yenile";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Gray;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(48, 410);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(176, 46);
            btnGuncelle.TabIndex = 57;
            btnGuncelle.Text = "Bilgileri Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.Gray;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(48, 464);
            btnResetPassword.Margin = new Padding(3, 4, 3, 4);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(176, 46);
            btnResetPassword.TabIndex = 56;
            btnResetPassword.Text = "Parola Değiştir";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(12, 394);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 3);
            panel5.TabIndex = 55;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(12, 286);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 3);
            panel4.TabIndex = 54;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(12, 242);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 3);
            panel3.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(12, 209);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 3);
            panel1.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(12, 154);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 3);
            panel2.TabIndex = 51;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(12, 25);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(75, 72);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circularPictureBox1.TabIndex = 49;
            circularPictureBox1.TabStop = false;
            // 
            // lblBmi
            // 
            lblBmi.AutoSize = true;
            lblBmi.Location = new Point(17, 262);
            lblBmi.Name = "lblBmi";
            lblBmi.Size = new Size(22, 20);
            lblBmi.TabIndex = 47;
            lblBmi.Text = "M";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 218);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 42;
            label10.Text = "Hedefiniz :";
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarget.Location = new Point(106, 218);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(17, 20);
            lblTarget.TabIndex = 41;
            lblTarget.Text = "x";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(17, 130);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(22, 20);
            lblMail.TabIndex = 39;
            lblMail.Text = "M";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(17, 110);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(20, 20);
            lblUser.TabIndex = 38;
            lblUser.Text = "U";
            // 
            // lblGun
            // 
            lblGun.AutoSize = true;
            lblGun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGun.Location = new Point(20, 172);
            lblGun.Name = "lblGun";
            lblGun.Size = new Size(17, 20);
            lblGun.TabIndex = 37;
            lblGun.Text = "x";
            // 
            // diyetisyenMailLbl
            // 
            diyetisyenMailLbl.AutoSize = true;
            diyetisyenMailLbl.LinkColor = Color.Black;
            diyetisyenMailLbl.Location = new Point(17, 338);
            diyetisyenMailLbl.Name = "diyetisyenMailLbl";
            diyetisyenMailLbl.Size = new Size(188, 20);
            diyetisyenMailLbl.TabIndex = 23;
            diyetisyenMailLbl.TabStop = true;
            diyetisyenMailLbl.Text = "diyetisyenmail@gmail.com";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(17, 293);
            label12.Name = "label12";
            label12.Size = new Size(108, 23);
            label12.TabIndex = 22;
            label12.Text = "Diyetisyenim";
            // 
            // diyetisyenLbl
            // 
            diyetisyenLbl.AutoSize = true;
            diyetisyenLbl.Location = new Point(17, 318);
            diyetisyenLbl.Name = "diyetisyenLbl";
            diyetisyenLbl.Size = new Size(113, 20);
            diyetisyenLbl.TabIndex = 21;
            diyetisyenLbl.Text = "diyetisyen@123";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 172);
            label9.Name = "label9";
            label9.Size = new Size(172, 20);
            label9.TabIndex = 17;
            label9.Text = "  gündür programdasınız";
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
            grafikPanel1.BorderStyle = BorderStyle.FixedSingle;
            grafikPanel1.Location = new Point(195, 67);
            grafikPanel1.Name = "grafikPanel1";
            grafikPanel1.Size = new Size(342, 120);
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
            humanBodyPanel.Location = new Point(23, 67);
            humanBodyPanel.Name = "humanBodyPanel";
            humanBodyPanel.Size = new Size(166, 498);
            humanBodyPanel.TabIndex = 0;
            // 
            // lblGogus
            // 
            lblGogus.AutoSize = true;
            lblGogus.Location = new Point(16, 419);
            lblGogus.Name = "lblGogus";
            lblGogus.Size = new Size(50, 20);
            lblGogus.TabIndex = 12;
            lblGogus.Text = "label8";
            // 
            // lblKalca
            // 
            lblKalca.AutoSize = true;
            lblKalca.Location = new Point(90, 352);
            lblKalca.Name = "lblKalca";
            lblKalca.Size = new Size(50, 20);
            lblKalca.TabIndex = 11;
            lblKalca.Text = "label8";
            // 
            // lblBel
            // 
            lblBel.AutoSize = true;
            lblBel.Location = new Point(14, 349);
            lblBel.Name = "lblBel";
            lblBel.Size = new Size(50, 20);
            lblBel.TabIndex = 10;
            lblBel.Text = "label8";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(85, 277);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(50, 20);
            lblBoy.TabIndex = 9;
            lblBoy.Text = "label8";
            // 
            // kiloLbl
            // 
            kiloLbl.AutoSize = true;
            kiloLbl.Location = new Point(16, 277);
            kiloLbl.Name = "kiloLbl";
            kiloLbl.Size = new Size(50, 20);
            kiloLbl.TabIndex = 8;
            kiloLbl.Text = "label8";
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
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 390);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 7;
            label7.Text = "Göğüs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(90, 318);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 6;
            label6.Text = "Kalça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 318);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 5;
            label5.Text = "Bel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(90, 249);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 4;
            label4.Text = "Boy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 249);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 3;
            label3.Text = "Kilo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(216, 232, 227);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(851, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(285, 641);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // DanisanPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1136, 641);
            Controls.Add(middlePanel1);
            Controls.Add(leftPanel);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CircularPictureBox circularPictureBox1;
        private Label label9;
        private Label label12;
        private Label diyetisyenLbl;
        private Label label10;
        private Label kiloLbl;
        private Label lblGogus;
        private Label lblKalca;
        private Label lblBel;
        private Label lblBoy;
        private LinkLabel diyetisyenMailLbl;
        private Label kilolbl;
        private Label lblGun;
        private Label lblUser;
        private Label lblTarget;
        private Label lblMail;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblBmi;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private CustomButton btnResetPassword;
        private CustomButton btnGuncelle;
        private CustomButton btnRefresh;
        private CustomButton btnCikisYap;
        private CustomButton cstmbtnsil;
    }
}