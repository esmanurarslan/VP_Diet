using System.Windows.Forms;

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
            lblUsername = new Label();
            panel1 = new Panel();
            circularPictureBox1 = new CircularPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ControlLightLight;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(99, 29);
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
            panel1.Size = new Size(84, 86);
            panel1.TabIndex = 2;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackColor = Color.White;
            circularPictureBox1.Location = new Point(12, 16);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(53, 52);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 0;
            circularPictureBox1.TabStop = false;
            // 
            // listItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(lblUsername);
            Name = "listItem";
            Size = new Size(209, 82);
            Load += listItem_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private Panel panel1;
        private CircularPictureBox circularPictureBox1;
    }
}
