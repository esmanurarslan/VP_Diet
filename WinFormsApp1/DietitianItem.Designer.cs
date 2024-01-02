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
            pcbConsultant = new CircularPictureBox();
            btnInspect = new CustomButton();
            lblNameSurname = new Label();
            panel1 = new Panel();
            lblCity = new Label();
            lblGender = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbConsultant).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbConsultant
            // 
            pcbConsultant.BackColor = SystemColors.AppWorkspace;
            pcbConsultant.Location = new Point(21, 43);
            pcbConsultant.Name = "pcbConsultant";
            pcbConsultant.Size = new Size(128, 137);
            pcbConsultant.TabIndex = 0;
            pcbConsultant.TabStop = false;
            // 
            // btnInspect
            // 
            btnInspect.BackColor = Color.FromArgb(165, 215, 198);
            btnInspect.FlatAppearance.BorderSize = 0;
            btnInspect.FlatStyle = FlatStyle.Flat;
            btnInspect.ForeColor = Color.White;
            btnInspect.Location = new Point(380, 152);
            btnInspect.Name = "btnInspect";
            btnInspect.Size = new Size(127, 40);
            btnInspect.TabIndex = 1;
            btnInspect.Text = " Incele";
            btnInspect.UseVisualStyleBackColor = false;
            btnInspect.Click += btnInspect_Click;
            // 
            // lblNameSurname
            // 
            lblNameSurname.AutoSize = true;
            lblNameSurname.BackColor = Color.Transparent;
            lblNameSurname.ForeColor = SystemColors.ControlDarkDark;
            lblNameSurname.Location = new Point(155, 23);
            lblNameSurname.Name = "lblNameSurname";
            lblNameSurname.Size = new Size(180, 32);
            lblNameSurname.TabIndex = 2;
            lblNameSurname.Text = "Name Surname";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(lblCity);
            panel1.Controls.Add(lblGender);
            panel1.Location = new Point(183, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 76);
            panel1.TabIndex = 3;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(17, 36);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(44, 25);
            lblCity.TabIndex = 1;
            lblCity.Text = "City";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(17, 11);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 25);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender";
            // 
            // DietitianItem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(lblNameSurname);
            Controls.Add(btnInspect);
            Controls.Add(pcbConsultant);
            Name = "DietitianItem";
            Size = new Size(522, 208);
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
        private Label lblCity;
        private Label lblGender;
    }
}
