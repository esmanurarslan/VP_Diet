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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGiris = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(228, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 332);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 38);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 0;
            label1.Text = "Giriş Yap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 142);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Parola:";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(128, 199, 175);
            btnGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(32, 190);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(198, 296);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 17);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Üye ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(132, 194);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(117, 20);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "şifremi unuttum!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 299);
            label4.Name = "label4";
            label4.Size = new Size(165, 17);
            label4.TabIndex = 8;
            label4.Text = "Henüz bir hesabın yok mu?";
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormGiris";
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
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}