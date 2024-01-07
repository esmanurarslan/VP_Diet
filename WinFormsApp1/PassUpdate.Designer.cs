namespace WinFormsApp1
{
    partial class PassUpdate
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
            label1 = new Label();
            panel1 = new Panel();
            txtNewPTekrar = new TextBox();
            txtNewP = new TextBox();
            label2 = new Label();
            txtOldP = new TextBox();
            btnVazgeç = new Button();
            btnGuncelle = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 48);
            label1.Name = "label1";
            label1.Size = new Size(256, 31);
            label1.TabIndex = 3;
            label1.Text = "Parolanızı güncelleyiniz";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            panel1.Controls.Add(txtNewPTekrar);
            panel1.Controls.Add(txtNewP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtOldP);
            panel1.Controls.Add(btnVazgeç);
            panel1.Controls.Add(btnGuncelle);
            panel1.Location = new Point(13, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 323);
            panel1.TabIndex = 1;
            // 
            // txtNewPTekrar
            // 
            txtNewPTekrar.Location = new Point(84, 167);
            txtNewPTekrar.Name = "txtNewPTekrar";
            txtNewPTekrar.PasswordChar = '*';
            txtNewPTekrar.PlaceholderText = "Yeni Parola Tekrar";
            txtNewPTekrar.Size = new Size(156, 27);
            txtNewPTekrar.TabIndex = 7;
            // 
            // txtNewP
            // 
            txtNewP.Location = new Point(84, 134);
            txtNewP.Name = "txtNewP";
            txtNewP.PasswordChar = '*';
            txtNewP.PlaceholderText = "Yeni Parola";
            txtNewP.Size = new Size(156, 27);
            txtNewP.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(240, 127);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 4;
            // 
            // txtOldP
            // 
            txtOldP.Location = new Point(84, 101);
            txtOldP.Name = "txtOldP";
            txtOldP.PasswordChar = '*';
            txtOldP.PlaceholderText = "Eski Parola";
            txtOldP.Size = new Size(156, 27);
            txtOldP.TabIndex = 2;
            // 
            // btnVazgeç
            // 
            btnVazgeç.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVazgeç.Location = new Point(160, 220);
            btnVazgeç.Name = "btnVazgeç";
            btnVazgeç.Size = new Size(121, 40);
            btnVazgeç.TabIndex = 1;
            btnVazgeç.Text = "Vazgeç";
            btnVazgeç.UseVisualStyleBackColor = true;
            btnVazgeç.Click += btnVazgeç_Click;
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
            // PassUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(354, 345);
            Controls.Add(panel1);
            Name = "PassUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PassUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtNewPTekrar;
        private TextBox txtNewP;
        private Label label2;
        private TextBox txtOldP;
        private Button btnVazgeç;
        private Button btnGuncelle;
    }
}