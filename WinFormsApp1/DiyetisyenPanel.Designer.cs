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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlDietInfo = new System.Windows.Forms.Panel();
            this.customButton1 = new WinFormsApp1.CustomButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalCon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRating = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArcRating = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDietSchool = new System.Windows.Forms.Label();
            this.lblDietMail = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDietUserName = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new WinFormsApp1.CircularPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLPnlCon = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDietInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDietInfo
            // 
            this.pnlDietInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(227)))));
            this.pnlDietInfo.Controls.Add(this.customButton1);
            this.pnlDietInfo.Controls.Add(this.label5);
            this.pnlDietInfo.Controls.Add(this.lblTotalCon);
            this.pnlDietInfo.Controls.Add(this.label3);
            this.pnlDietInfo.Controls.Add(this.lblTotalRating);
            this.pnlDietInfo.Controls.Add(this.label2);
            this.pnlDietInfo.Controls.Add(this.lblArcRating);
            this.pnlDietInfo.Controls.Add(this.panel2);
            this.pnlDietInfo.Controls.Add(this.panel1);
            this.pnlDietInfo.Controls.Add(this.lblDietSchool);
            this.pnlDietInfo.Controls.Add(this.lblDietMail);
            this.pnlDietInfo.Controls.Add(this.lblRating);
            this.pnlDietInfo.Controls.Add(this.lblDietUserName);
            this.pnlDietInfo.Controls.Add(this.circularPictureBox1);
            this.pnlDietInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDietInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlDietInfo.Name = "pnlDietInfo";
            this.pnlDietInfo.Size = new System.Drawing.Size(248, 481);
            this.pnlDietInfo.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Gray;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(12, 409);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(213, 40);
            this.customButton1.TabIndex = 12;
            this.customButton1.Text = "Parola Değiştir";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(70, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "danışan sayısı";
            // 
            // lblTotalCon
            // 
            this.lblTotalCon.AutoSize = true;
            this.lblTotalCon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCon.Location = new System.Drawing.Point(39, 303);
            this.lblTotalCon.Name = "lblTotalCon";
            this.lblTotalCon.Size = new System.Drawing.Size(14, 15);
            this.lblTotalCon.TabIndex = 10;
            this.lblTotalCon.Text = "0";
            this.lblTotalCon.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(70, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "tane değerlendirme";
            // 
            // lblTotalRating
            // 
            this.lblTotalRating.AutoSize = true;
            this.lblTotalRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalRating.Location = new System.Drawing.Point(39, 273);
            this.lblTotalRating.Name = "lblTotalRating";
            this.lblTotalRating.Size = new System.Drawing.Size(14, 15);
            this.lblTotalRating.TabIndex = 8;
            this.lblTotalRating.Text = "0";
            this.lblTotalRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(70, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "değerlendirme ortalaması";
            // 
            // lblArcRating
            // 
            this.lblArcRating.AutoSize = true;
            this.lblArcRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArcRating.Location = new System.Drawing.Point(29, 241);
            this.lblArcRating.Name = "lblArcRating";
            this.lblArcRating.Size = new System.Drawing.Size(24, 15);
            this.lblArcRating.TabIndex = 0;
            this.lblArcRating.Text = "0,0";
            this.lblArcRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 2);
            this.panel1.TabIndex = 5;
            // 
            // lblDietSchool
            // 
            this.lblDietSchool.AutoSize = true;
            this.lblDietSchool.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDietSchool.Location = new System.Drawing.Point(12, 197);
            this.lblDietSchool.Name = "lblDietSchool";
            this.lblDietSchool.Size = new System.Drawing.Size(119, 15);
            this.lblDietSchool.TabIndex = 4;
            this.lblDietSchool.Text = "Example Mezun Okul";
            // 
            // lblDietMail
            // 
            this.lblDietMail.AutoSize = true;
            this.lblDietMail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDietMail.Location = new System.Drawing.Point(12, 173);
            this.lblDietMail.Name = "lblDietMail";
            this.lblDietMail.Size = new System.Drawing.Size(131, 15);
            this.lblDietMail.TabIndex = 3;
            this.lblDietMail.Text = "example@hotmail.com";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(163, 148);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(41, 15);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating";
            // 
            // lblDietUserName
            // 
            this.lblDietUserName.AutoSize = true;
            this.lblDietUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDietUserName.Location = new System.Drawing.Point(12, 143);
            this.lblDietUserName.Name = "lblDietUserName";
            this.lblDietUserName.Size = new System.Drawing.Size(96, 20);
            this.lblDietUserName.TabIndex = 1;
            this.lblDietUserName.Text = "Kullanıcı Adı";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.White;
            this.circularPictureBox1.Location = new System.Drawing.Point(12, 29);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(101, 98);
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(227)))));
            this.panel3.Controls.Add(this.flowLPnlCon);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(312, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 440);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danışanlarım";
            // 
            // flowLPnlCon
            // 
            this.flowLPnlCon.Location = new System.Drawing.Point(28, 59);
            this.flowLPnlCon.Name = "flowLPnlCon";
            this.flowLPnlCon.Size = new System.Drawing.Size(253, 361);
            this.flowLPnlCon.TabIndex = 14;
            // 
            // DiyetisyenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(971, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlDietInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DiyetisyenPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiyetisyenPanel";
            this.pnlDietInfo.ResumeLayout(false);
            this.pnlDietInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlDietInfo;
        private Label lblDietSchool;
        private Label lblDietMail;
        private Label lblRating;
        private Label lblDietUserName;
        private CircularPictureBox circularPictureBox1;
        private Panel panel2;
        private Panel panel1;
        private CustomButton customButton1;
        private Label label5;
        private Label lblTotalCon;
        private Label label3;
        private Label lblTotalRating;
        private Label label2;
        private Label lblArcRating;
        private Panel panel3;
        private Label label1;
        private FlowLayoutPanel flowLPnlCon;
    }
}