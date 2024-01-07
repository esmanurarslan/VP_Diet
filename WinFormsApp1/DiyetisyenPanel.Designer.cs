namespace WinFormsApp1
{
    partial class DiyetisyenPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetisyenPanel));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlDietInfo = new Panel();
            btnCikis = new CustomButton();
            btnResetPassword = new CustomButton();
            label5 = new Label();
            lblTotalCon = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            lblDietSchool = new Label();
            lblDietMail = new Label();
            lblDietUserName = new Label();
            circularPictureBox1 = new CircularPictureBox();
            panel3 = new Panel();
            pnlChest = new Panel();
            pnlKalca = new Panel();
            pnlBel = new Panel();
            pnlKilo = new Panel();
            flowLPnlCon = new FlowLayoutPanel();
            label1 = new Label();
            pnlDietInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDietInfo
            // 
            pnlDietInfo.BackColor = Color.FromArgb(216, 232, 227);
            pnlDietInfo.Controls.Add(btnCikis);
            pnlDietInfo.Controls.Add(btnResetPassword);
            pnlDietInfo.Controls.Add(label5);
            pnlDietInfo.Controls.Add(lblTotalCon);
            pnlDietInfo.Controls.Add(panel2);
            pnlDietInfo.Controls.Add(panel1);
            pnlDietInfo.Controls.Add(lblDietSchool);
            pnlDietInfo.Controls.Add(lblDietMail);
            pnlDietInfo.Controls.Add(lblDietUserName);
            pnlDietInfo.Controls.Add(circularPictureBox1);
            pnlDietInfo.Dock = DockStyle.Left;
            pnlDietInfo.Location = new Point(0, 0);
            pnlDietInfo.Margin = new Padding(5, 6, 5, 6);
            pnlDietInfo.Name = "pnlDietInfo";
            pnlDietInfo.Size = new Size(422, 1026);
            pnlDietInfo.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Gray;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(28, 901);
            btnCikis.Margin = new Padding(5, 6, 5, 6);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(362, 82);
            btnCikis.TabIndex = 13;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.Gray;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(28, 806);
            btnResetPassword.Margin = new Padding(5, 6, 5, 6);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(362, 82);
            btnResetPassword.TabIndex = 12;
            btnResetPassword.Text = "Parola Değiştir";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(89, 352);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 32);
            label5.TabIndex = 11;
            label5.Text = "danışan sayısı";
            // 
            // lblTotalCon
            // 
            lblTotalCon.AutoSize = true;
            lblTotalCon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCon.Location = new Point(50, 352);
            lblTotalCon.Margin = new Padding(5, 0, 5, 0);
            lblTotalCon.Name = "lblTotalCon";
            lblTotalCon.Size = new Size(28, 32);
            lblTotalCon.TabIndex = 10;
            lblTotalCon.Text = "0";
            lblTotalCon.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(20, 410);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 5);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(20, 325);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 5);
            panel1.TabIndex = 5;
            // 
            // lblDietSchool
            // 
            lblDietSchool.AutoSize = true;
            lblDietSchool.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDietSchool.ForeColor = SystemColors.ControlText;
            lblDietSchool.Location = new Point(28, 270);
            lblDietSchool.Margin = new Padding(5, 0, 5, 0);
            lblDietSchool.Name = "lblDietSchool";
            lblDietSchool.Size = new Size(244, 32);
            lblDietSchool.TabIndex = 4;
            lblDietSchool.Text = "Example Mezun Okul";
            // 
            // lblDietMail
            // 
            lblDietMail.AutoSize = true;
            lblDietMail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDietMail.ForeColor = SystemColors.ControlText;
            lblDietMail.Location = new Point(28, 224);
            lblDietMail.Margin = new Padding(5, 0, 5, 0);
            lblDietMail.Name = "lblDietMail";
            lblDietMail.Size = new Size(264, 32);
            lblDietMail.TabIndex = 3;
            lblDietMail.Text = "example@hotmail.com";
            // 
            // lblDietUserName
            // 
            lblDietUserName.AutoSize = true;
            lblDietUserName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDietUserName.Location = new Point(28, 176);
            lblDietUserName.Margin = new Padding(5, 0, 5, 0);
            lblDietUserName.Name = "lblDietUserName";
            lblDietUserName.Size = new Size(148, 32);
            lblDietUserName.TabIndex = 1;
            lblDietUserName.Text = "Kullanıcı Adı";
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = Color.White;
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(20, 40);
            circularPictureBox1.Margin = new Padding(5, 6, 5, 6);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(122, 115);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            circularPictureBox1.TabIndex = 0;
            circularPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(216, 232, 227);
            panel3.Controls.Add(pnlChest);
            panel3.Controls.Add(pnlKalca);
            panel3.Controls.Add(pnlBel);
            panel3.Controls.Add(pnlKilo);
            panel3.Controls.Add(flowLPnlCon);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(455, 40);
            panel3.Margin = new Padding(5, 6, 5, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1102, 942);
            panel3.TabIndex = 13;
            // 
            // pnlChest
            // 
            pnlChest.BackColor = Color.White;
            pnlChest.Location = new Point(492, 686);
            pnlChest.Name = "pnlChest";
            pnlChest.Size = new Size(556, 192);
            pnlChest.TabIndex = 16;
            // 
            // pnlKalca
            // 
            pnlKalca.BackColor = Color.White;
            pnlKalca.Location = new Point(492, 488);
            pnlKalca.Name = "pnlKalca";
            pnlKalca.Size = new Size(556, 192);
            pnlKalca.TabIndex = 16;
            // 
            // pnlBel
            // 
            pnlBel.BackColor = Color.White;
            pnlBel.Location = new Point(492, 290);
            pnlBel.Name = "pnlBel";
            pnlBel.Size = new Size(556, 192);
            pnlBel.TabIndex = 16;
            // 
            // pnlKilo
            // 
            pnlKilo.BackColor = Color.White;
            pnlKilo.Location = new Point(492, 91);
            pnlKilo.Name = "pnlKilo";
            pnlKilo.Size = new Size(556, 192);
            pnlKilo.TabIndex = 15;
            // 
            // flowLPnlCon
            // 
            flowLPnlCon.BackColor = Color.FromArgb(216, 232, 227);
            flowLPnlCon.Location = new Point(52, 91);
            flowLPnlCon.Margin = new Padding(5, 6, 5, 6);
            flowLPnlCon.Name = "flowLPnlCon";
            flowLPnlCon.Size = new Size(421, 787);
            flowLPnlCon.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 60);
            label1.TabIndex = 13;
            label1.Text = "Danışanlarım";
            label1.Click += label1_Click;
            // 
            // DiyetisyenPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1618, 1026);
            Controls.Add(panel3);
            Controls.Add(pnlDietInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            Name = "DiyetisyenPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiyetisyenPanel";
            pnlDietInfo.ResumeLayout(false);
            pnlDietInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlDietInfo;
        private Label lblDietSchool;
        private Label lblDietMail;
        private Label lblDietUserName;
        private CircularPictureBox circularPictureBox1;
        private Panel panel2;
        private Panel panel1;
        private CustomButton btnResetPassword;
        private Label label5;
        private Label lblTotalCon;
        private Panel panel3;
        private Label label1;
        private FlowLayoutPanel flowLPnlCon;
        private Panel pnlChest;
        private Panel pnlKalca;
        private Panel pnlBel;
        private Panel pnlKilo;
        private CustomButton btnCikis;
    }
}