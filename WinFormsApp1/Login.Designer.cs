namespace WinFormsApp1
{
    partial class FormGiris
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
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            btnGiris = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 251, 249);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 318);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(14, 245);
            label4.Name = "label4";
            label4.Size = new Size(181, 20);
            label4.TabIndex = 8;
            label4.Text = "Henüz bir hesabın yok mu?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(145, 194);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(117, 20);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "şifremi unuttum!";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(215, 243);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Üye ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(128, 199, 175);
            btnGiris.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(23, 184);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(103, 38);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 142);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(14, 137);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Parola";
            textBox2.Size = new Size(288, 30);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(14, 91);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Kullanıcı Adı";
            textBox1.Size = new Size(288, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 37);
            label1.Name = "label1";
            label1.Size = new Size(104, 31);
            label1.TabIndex = 0;
            label1.Text = "Giriş Yap";
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(339, 339);
            Controls.Add(panel1);
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Formu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button btnGiris;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}