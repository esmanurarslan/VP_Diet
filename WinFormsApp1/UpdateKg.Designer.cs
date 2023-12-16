namespace WinFormsApp1
{
    partial class UpdateKg
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
            txtKAlcaUpdate = new TextBox();
            txtGogusUpdate = new TextBox();
            txtBelUpdate = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtKiloUpdate = new TextBox();
            btnIptal = new Button();
            btnGuncelle = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            panel1.Controls.Add(txtKAlcaUpdate);
            panel1.Controls.Add(txtGogusUpdate);
            panel1.Controls.Add(txtBelUpdate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtKiloUpdate);
            panel1.Controls.Add(btnIptal);
            panel1.Controls.Add(btnGuncelle);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 323);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtKAlcaUpdate
            // 
            txtKAlcaUpdate.Location = new Point(83, 138);
            txtKAlcaUpdate.Name = "txtKAlcaUpdate";
            txtKAlcaUpdate.PlaceholderText = "Kalça Çevresi(cm)";
            txtKAlcaUpdate.Size = new Size(156, 27);
            txtKAlcaUpdate.TabIndex = 7;
            // 
            // txtGogusUpdate
            // 
            txtGogusUpdate.Location = new Point(83, 171);
            txtGogusUpdate.Name = "txtGogusUpdate";
            txtGogusUpdate.PlaceholderText = "Göğüs Çevresi(cm)";
            txtGogusUpdate.Size = new Size(156, 27);
            txtGogusUpdate.TabIndex = 6;
            // 
            // txtBelUpdate
            // 
            txtBelUpdate.Location = new Point(83, 105);
            txtBelUpdate.Name = "txtBelUpdate";
            txtBelUpdate.PlaceholderText = "Bel Çevresi(cm)";
            txtBelUpdate.Size = new Size(156, 27);
            txtBelUpdate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(239, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(277, 31);
            label1.TabIndex = 3;
            label1.Text = "Güncel bilgilerinizi giriniz";
            // 
            // txtKiloUpdate
            // 
            txtKiloUpdate.Location = new Point(83, 72);
            txtKiloUpdate.Name = "txtKiloUpdate";
            txtKiloUpdate.PlaceholderText = "Kilo(kg)";
            txtKiloUpdate.Size = new Size(156, 27);
            txtKiloUpdate.TabIndex = 2;
            txtKiloUpdate.TextChanged += textBox1_TextChanged;
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Location = new Point(160, 220);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(121, 40);
            btnIptal.TabIndex = 1;
            btnIptal.Text = "Vazgeç";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(24, 220);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(121, 40);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // UpdateKg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(354, 345);
            Controls.Add(panel1);
            Name = "UpdateKg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Güncelle";
            Load += UpdateKg_Load;
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
        private TextBox txtKiloUpdate;
        private TextBox txtKAlcaUpdate;
        private TextBox txtGogusUpdate;
        private TextBox txtBelUpdate;
    }
}