namespace WinFormsApp1
{
    partial class DietitianItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DietitianItem));
            pcbConsultant = new CircularPictureBox();
            btnInspect = new CustomButton();
            lblNameSurname = new Label();
            panel1 = new Panel();
            lblMail = new Label();
            lblGender = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbConsultant).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbConsultant
            // 
            pcbConsultant.BackColor = SystemColors.AppWorkspace;
            pcbConsultant.Image = (Image)resources.GetObject("pcbConsultant.Image");
            pcbConsultant.Location = new Point(13, 14);
            pcbConsultant.Margin = new Padding(2);
            pcbConsultant.Name = "pcbConsultant";
            pcbConsultant.Size = new Size(65, 67);
            pcbConsultant.SizeMode = PictureBoxSizeMode.Zoom;
            pcbConsultant.TabIndex = 0;
            pcbConsultant.TabStop = false;
            // 
            // btnInspect
            // 
            btnInspect.BackColor = Color.FromArgb(233, 233, 233);
            btnInspect.FlatAppearance.BorderSize = 0;
            btnInspect.FlatStyle = FlatStyle.Flat;
            btnInspect.ForeColor = Color.Gray;
            btnInspect.Location = new Point(165, 85);
            btnInspect.Margin = new Padding(2);
            btnInspect.Name = "btnInspect";
            btnInspect.Size = new Size(78, 25);
            btnInspect.TabIndex = 1;
            btnInspect.Text = " Incele";
            btnInspect.UseVisualStyleBackColor = false;
            btnInspect.Click += btnInspect_Click;
            // 
            // lblNameSurname
            // 
            lblNameSurname.AutoSize = true;
            lblNameSurname.BackColor = Color.Transparent;
            lblNameSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameSurname.ForeColor = SystemColors.WindowFrame;
            lblNameSurname.Location = new Point(82, 14);
            lblNameSurname.Margin = new Padding(2, 0, 2, 0);
            lblNameSurname.Name = "lblNameSurname";
            lblNameSurname.Size = new Size(117, 20);
            lblNameSurname.TabIndex = 2;
            lblNameSurname.Text = "Name Surname";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblMail);
            panel1.Controls.Add(lblGender);
            panel1.Location = new Point(82, 33);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 48);
            panel1.TabIndex = 3;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.ForeColor = Color.Black;
            lblMail.Location = new Point(10, 22);
            lblMail.Margin = new Padding(2, 0, 2, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 1;
            lblMail.Text = "Mail";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(10, 7);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender";
            // 
            // DietitianItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            Controls.Add(panel1);
            Controls.Add(lblNameSurname);
            Controls.Add(btnInspect);
            Controls.Add(pcbConsultant);
            Margin = new Padding(2);
            Name = "DietitianItem";
            Size = new Size(252, 116);
            ((System.ComponentModel.ISupportInitialize)pcbConsultant).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularPictureBox pcbConsultant;
        private CustomButton btnInspect;
        private Label lblNameSurname;
        private Panel panel1;
        private Label lblMail;
        private Label lblGender;
    }
}
