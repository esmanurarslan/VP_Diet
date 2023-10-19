namespace WinFormsApp1
{
    partial class FormUye
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnDiyetisyen = new Button();
            panel1 = new Panel();
            btnDanisan = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(355, 31);
            label1.TabIndex = 0;
            label1.Text = "Ne Olarak Üye Olmak İstersiniz?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDiyetisyen
            // 
            btnDiyetisyen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDiyetisyen.AutoSize = true;
            btnDiyetisyen.BackColor = Color.FromArgb(128, 199, 175);
            btnDiyetisyen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiyetisyen.ForeColor = Color.White;
            btnDiyetisyen.Location = new Point(72, 89);
            btnDiyetisyen.Margin = new Padding(0);
            btnDiyetisyen.Name = "btnDiyetisyen";
            btnDiyetisyen.Size = new Size(116, 47);
            btnDiyetisyen.TabIndex = 1;
            btnDiyetisyen.Text = "Diyetisyen";
            btnDiyetisyen.UseVisualStyleBackColor = false;
            btnDiyetisyen.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDanisan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDiyetisyen);
            panel1.Location = new Point(44, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 178);
            panel1.TabIndex = 3;
            // 
            // btnDanisan
            // 
            btnDanisan.BackColor = Color.FromArgb(128, 199, 175);
            btnDanisan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDanisan.ForeColor = Color.White;
            btnDanisan.Location = new Point(207, 89);
            btnDanisan.Name = "btnDanisan";
            btnDanisan.Size = new Size(130, 47);
            btnDanisan.TabIndex = 2;
            btnDanisan.Text = "Danışan";
            btnDanisan.UseVisualStyleBackColor = false;
            btnDanisan.Click += btnDanisan_Click_1;
            // 
            // FormUye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(514, 262);
            Controls.Add(panel1);
            Name = "FormUye";
            Text = "Yeni Üyelik ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnDanisan_Click_1(object sender, EventArgs e)
        {
            FormDanisanUye formDanisanUye = new FormDanisanUye();
            formDanisanUye.Show();
            this.Hide();
        }

        #endregion

        private Label label1;
        private Button btnDiyetisyen;

        private Panel panel1;
        private Button btnDanisan;
    }
}