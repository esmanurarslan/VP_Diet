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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlDietInfo = new Panel();
            customButton1 = new CustomButton();
            label5 = new Label();
            lblTotalCon = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            lblDietSchool = new Label();
            lblDietMail = new Label();
            lblDietUserName = new Label();
            circularPictureBox1 = new CircularPictureBox();
            panel3 = new Panel();
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
            pnlDietInfo.Controls.Add(customButton1);
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
            pnlDietInfo.Margin = new Padding(3, 4, 3, 4);
            pnlDietInfo.Name = "pnlDietInfo";
            pnlDietInfo.Size = new Size(283, 641);
            pnlDietInfo.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Gray;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(14, 545);
            customButton1.Margin = new Padding(3, 4, 3, 4);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(243, 53);
            customButton1.TabIndex = 12;
            customButton1.Text = "Parola Değiştir";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(73, 391);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 11;
            label5.Text = "danışan sayısı";
            // 
            // lblTotalCon
            // 
            lblTotalCon.AutoSize = true;
            lblTotalCon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCon.Location = new Point(50, 391);
            lblTotalCon.Name = "lblTotalCon";
            lblTotalCon.Size = new Size(18, 20);
            lblTotalCon.TabIndex = 10;
            lblTotalCon.Text = "0";
            lblTotalCon.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(14, 443);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 3);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(14, 301);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 3);
            panel1.TabIndex = 5;
            // 
            // lblDietSchool
            // 
            lblDietSchool.AutoSize = true;
            lblDietSchool.ForeColor = SystemColors.ControlDark;
            lblDietSchool.Location = new Point(14, 263);
            lblDietSchool.Name = "lblDietSchool";
            lblDietSchool.Size = new Size(148, 20);
            lblDietSchool.TabIndex = 4;
            lblDietSchool.Text = "Example Mezun Okul";
            // 
            // lblDietMail
            // 
            lblDietMail.AutoSize = true;
            lblDietMail.ForeColor = SystemColors.ControlDark;
            lblDietMail.Location = new Point(14, 231);
            lblDietMail.Name = "lblDietMail";
            lblDietMail.Size = new Size(163, 20);
            lblDietMail.TabIndex = 3;
            lblDietMail.Text = "example@hotmail.com";
            // 
            // lblDietUserName
            // 
            lblDietUserName.AutoSize = true;
            lblDietUserName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDietUserName.Location = new Point(14, 191);
            lblDietUserName.Name = "lblDietUserName";
            lblDietUserName.Size = new Size(122, 25);
            lblDietUserName.TabIndex = 1;
            lblDietUserName.Text = "Kullanıcı Adı";
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = Color.White;
            circularPictureBox1.Location = new Point(14, 39);
            circularPictureBox1.Margin = new Padding(3, 4, 3, 4);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(115, 131);
            circularPictureBox1.TabIndex = 0;
            circularPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(216, 232, 227);
            panel3.Controls.Add(flowLPnlCon);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(357, 39);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(688, 587);
            panel3.TabIndex = 13;
            // 
            // flowLPnlCon
            // 
            flowLPnlCon.Location = new Point(32, 79);
            flowLPnlCon.Margin = new Padding(3, 4, 3, 4);
            flowLPnlCon.Name = "flowLPnlCon";
            flowLPnlCon.Size = new Size(303, 481);
            flowLPnlCon.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 13;
            label1.Text = "Danışanlarım";
            // 
            // DiyetisyenPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1110, 641);
            Controls.Add(panel3);
            Controls.Add(pnlDietInfo);
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
        private CustomButton customButton1;
        private Label label5;
        private Label lblTotalCon;
        private Panel panel3;
        private Label label1;
        private FlowLayoutPanel flowLPnlCon;
    }
}