namespace WinFormsApp1
{
    partial class DiyetisyenPanel
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
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            grafikPanel1 = new Panel();
            grafikPanel2 = new Panel();
            grafikPanel3 = new Panel();
            grafikPanel4 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label3 = new Label();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label8 = new Label();
            kullanıcıAdLbl = new Label();
            label10 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(kullanıcıAdLbl);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 640);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(233, 233, 233);
            panel2.Location = new Point(850, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 640);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(233, 233, 233);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(grafikPanel3);
            panel3.Controls.Add(grafikPanel4);
            panel3.Controls.Add(grafikPanel2);
            panel3.Controls.Add(grafikPanel1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(275, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 589);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 17);
            label1.Name = "label1";
            label1.Size = new Size(182, 38);
            label1.TabIndex = 0;
            label1.Text = "Danışanlarım";
            // 
            // grafikPanel1
            // 
            grafikPanel1.BackColor = Color.White;
            grafikPanel1.Location = new Point(244, 58);
            grafikPanel1.Name = "grafikPanel1";
            grafikPanel1.Size = new Size(296, 120);
            grafikPanel1.TabIndex = 1;
            // 
            // grafikPanel2
            // 
            grafikPanel2.BackColor = Color.White;
            grafikPanel2.Location = new Point(244, 184);
            grafikPanel2.Name = "grafikPanel2";
            grafikPanel2.Size = new Size(296, 120);
            grafikPanel2.TabIndex = 2;
            // 
            // grafikPanel3
            // 
            grafikPanel3.BackColor = Color.White;
            grafikPanel3.Location = new Point(244, 310);
            grafikPanel3.Name = "grafikPanel3";
            grafikPanel3.Size = new Size(296, 120);
            grafikPanel3.TabIndex = 2;
            // 
            // grafikPanel4
            // 
            grafikPanel4.BackColor = Color.White;
            grafikPanel4.Location = new Point(244, 436);
            grafikPanel4.Name = "grafikPanel4";
            grafikPanel4.Size = new Size(296, 120);
            grafikPanel4.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(8, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 99);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(8, 163);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 99);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(8, 268);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 99);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(8, 373);
            panel7.Name = "panel7";
            panel7.Size = new Size(230, 99);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(8, 478);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 99);
            panel8.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 31);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 8;
            label3.Text = "Ahmet Beyin Grafikleri";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(23, 581);
            button2.Name = "button2";
            button2.Size = new Size(206, 48);
            button2.TabIndex = 16;
            button2.Text = "Parola Değiştir";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 124);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 19;
            label8.Text = "Kullanıcı Adı";
            // 
            // kullanıcıAdLbl
            // 
            kullanıcıAdLbl.AutoSize = true;
            kullanıcıAdLbl.Location = new Point(24, 147);
            kullanıcıAdLbl.Name = "kullanıcıAdLbl";
            kullanıcıAdLbl.Size = new Size(101, 20);
            kullanıcıAdLbl.TabIndex = 20;
            kullanıcıAdLbl.Text = "kullanıcı@123";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 219);
            label10.Name = "label10";
            label10.Size = new Size(231, 20);
            label10.TabIndex = 21;
            label10.Text = "-------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 310);
            label2.Name = "label2";
            label2.Size = new Size(231, 20);
            label2.TabIndex = 22;
            label2.Text = "-------------------------------------";
            // 
            // DiyetisyenPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1110, 641);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DiyetisyenPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiyetisyenPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel grafikPanel1;
        private Panel grafikPanel3;
        private Panel grafikPanel4;
        private Panel grafikPanel2;
        private Panel panel4;
        private Label label3;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
        private Label kullanıcıAdLbl;
        private Label label2;
        private Label label10;
    }
}