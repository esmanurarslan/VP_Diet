﻿using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class listItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listItem));
            lblUsername = new Label();
            panel1 = new Panel();
            circularPictureBox1 = new CircularPictureBox();
            btnIncele = new Button();
            lblPuan = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ControlLightLight;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(90, 16);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "AD SOYAD";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(165, 215, 198);
            panel1.Controls.Add(circularPictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 93);
            panel1.TabIndex = 2;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = Color.White;
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(12, 16);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(60, 63);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 0;
            circularPictureBox1.TabStop = false;
            // 
            // btnIncele
            // 
            btnIncele.BackColor = Color.FromArgb(165, 215, 198);
            btnIncele.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIncele.Location = new Point(155, 61);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(94, 29);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.UseVisualStyleBackColor = false;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.BackColor = SystemColors.ControlLightLight;
            lblPuan.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuan.Location = new Point(90, 36);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(15, 17);
            lblPuan.TabIndex = 5;
            lblPuan.Text = "a";
            // 
            // listItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblPuan);
            Controls.Add(btnIncele);
            Controls.Add(panel1);
            Controls.Add(lblUsername);
            Name = "listItem";
            Size = new Size(252, 93);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private Panel panel1;
        private CircularPictureBox circularPictureBox1;
        private Button btnIncele;
        private Label lblPuan;
    }
}
