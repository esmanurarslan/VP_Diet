namespace WinFormsApp1
{
    partial class EMail
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
            btnGonder = new Button();
            label3 = new Label();
            txtMail = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 251, 249);
            panel1.Controls.Add(btnGonder);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 190);
            panel1.TabIndex = 1;
            // 
            // btnGonder
            // 
            btnGonder.BackColor = Color.FromArgb(128, 199, 175);
            btnGonder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGonder.ForeColor = SystemColors.ButtonHighlight;
            btnGonder.Location = new Point(119, 127);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(103, 38);
            btnGonder.TabIndex = 5;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = false;
            btnGonder.Click += btnGonder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 142);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(56, 91);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Email";
            txtMail.Size = new Size(243, 30);
            txtMail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 42);
            label1.Name = "label1";
            label1.Size = new Size(339, 28);
            label1.TabIndex = 0;
            label1.Text = "Sisteme kayıtlı mail adresinizi giriniz";
            // 
            // EMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(386, 219);
            Controls.Add(panel1);
            Name = "EMail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGonder;
        private Label label3;
        private TextBox txtMail;
        private Label label1;
    }
}