namespace WinFormsApp1
{
    partial class ConsultantItem
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblGun = new Label();
            btnIncele = new Button();
            panel1 = new Panel();
            circularPictureBox1 = new CircularPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(99, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(51, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label1";
            // 
            // lblGun
            // 
            lblGun.AutoSize = true;
            lblGun.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            lblGun.Location = new Point(99, 30);
            lblGun.Name = "lblGun";
            lblGun.Size = new Size(43, 17);
            lblGun.TabIndex = 1;
            lblGun.Text = "label2";
            // 
            // btnIncele
            // 
            btnIncele.BackColor = Color.FromArgb(165, 215, 198);
            btnIncele.Location = new Point(155, 50);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(94, 29);
            btnIncele.TabIndex = 2;
            btnIncele.Text = "İncele";
            btnIncele.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(165, 215, 198);
            panel1.Controls.Add(circularPictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 89);
            panel1.TabIndex = 3;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = Color.White;
            circularPictureBox1.Location = new Point(12, 16);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(53, 52);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 0;
            circularPictureBox1.TabStop = false;
            // 
            // ConsultantItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(btnIncele);
            Controls.Add(lblGun);
            Controls.Add(lblUsername);
            Name = "ConsultantItem";
            Size = new Size(252, 82);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblGun;
        private Button btnIncele;
        private Panel panel1;
        private CircularPictureBox circularPictureBox1;
    }
}
