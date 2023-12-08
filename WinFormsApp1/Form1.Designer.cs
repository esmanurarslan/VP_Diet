namespace WinFormsApp1
{
    partial class Guncelle
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            btnIptal = new Button();
            btnGuncelle = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnIptal);
            panel1.Controls.Add(btnGuncelle);
            panel1.Location = new Point(119, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 332);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 100);
            label2.Name = "label2";
            label2.Size = new Size(244, 23);
            label2.TabIndex = 4;
            label2.Text = "Lütfen güncel kilonuzu giriniz !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(192, 45);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 3;
            label1.Text = "Kilomu Güncelle";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 27);
            textBox1.TabIndex = 2;
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Location = new Point(303, 199);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(121, 40);
            btnIptal.TabIndex = 1;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(180, 199);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(121, 40);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Guncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Guncelle";
            Text = "Form1";
            Load += Guncelle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnIptal;
        private Button btnGuncelle;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}