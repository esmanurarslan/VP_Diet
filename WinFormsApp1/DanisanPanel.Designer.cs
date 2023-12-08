
namespace WinFormsApp1
{
    partial class DanisanPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanisanPanel));
            leftPanel = new Panel();
            smallLeftPanel2 = new Panel();
            smallLeftPanel1 = new Panel();
            rightPanel = new Panel();
            middlePanel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            grafikPanel5 = new Panel();
            grafikPanel4 = new Panel();
            grafikPanel3 = new Panel();
            grafikPanel2 = new Panel();
            grafikPanel = new Panel();
            humanBodyPanel = new Panel();
            pictureBox1 = new PictureBox();
            middlePanel2 = new Panel();
            label3 = new Label();
            smallLeftPanel3 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            process1 = new System.Diagnostics.Process();
            process2 = new System.Diagnostics.Process();
            label5 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            label6 = new Label();
            progressBar3 = new ProgressBar();
            checkedListBox1 = new CheckedListBox();
            btnGüncelle = new Button();
            leftPanel.SuspendLayout();
            middlePanel1.SuspendLayout();
            humanBodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            middlePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(233, 233, 233);
            leftPanel.Controls.Add(btnGüncelle);
            leftPanel.Controls.Add(smallLeftPanel2);
            leftPanel.Controls.Add(smallLeftPanel1);
            leftPanel.Location = new Point(1, 1);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(192, 641);
            leftPanel.TabIndex = 0;
            
            // 
            // smallLeftPanel2
            // 
            smallLeftPanel2.BackColor = Color.White;
            smallLeftPanel2.Location = new Point(0, 145);
            smallLeftPanel2.Name = "smallLeftPanel2";
            smallLeftPanel2.Size = new Size(192, 51);
            smallLeftPanel2.TabIndex = 1;
            // 
            // smallLeftPanel1
            // 
            smallLeftPanel1.BackColor = Color.White;
            smallLeftPanel1.Location = new Point(0, 88);
            smallLeftPanel1.Name = "smallLeftPanel1";
            smallLeftPanel1.Size = new Size(192, 51);
            smallLeftPanel1.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(233, 233, 233);
            rightPanel.Location = new Point(918, 1);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(192, 641);
            rightPanel.TabIndex = 1;
            // 
            // middlePanel1
            // 
            middlePanel1.BackColor = Color.FromArgb(233, 233, 233);
            middlePanel1.Controls.Add(label2);
            middlePanel1.Controls.Add(label1);
            middlePanel1.Controls.Add(grafikPanel5);
            middlePanel1.Controls.Add(grafikPanel4);
            middlePanel1.Controls.Add(grafikPanel3);
            middlePanel1.Controls.Add(grafikPanel2);
            middlePanel1.Controls.Add(grafikPanel);
            middlePanel1.Controls.Add(humanBodyPanel);
            middlePanel1.Location = new Point(249, 40);
            middlePanel1.Name = "middlePanel1";
            middlePanel1.Size = new Size(613, 314);
            middlePanel1.TabIndex = 2;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(221, 36);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 7;
            label2.Text = "Grafikler";
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 14);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 4;
            label1.Text = "Gelişimim";
      
            // 
            // grafikPanel5
            // 
            grafikPanel5.BackColor = Color.White;
            grafikPanel5.Location = new Point(509, 202);
            grafikPanel5.Name = "grafikPanel5";
            grafikPanel5.Size = new Size(90, 84);
            grafikPanel5.TabIndex = 6;
            // 
            // grafikPanel4
            // 
            grafikPanel4.BackColor = Color.White;
            grafikPanel4.Location = new Point(413, 202);
            grafikPanel4.Name = "grafikPanel4";
            grafikPanel4.Size = new Size(90, 84);
            grafikPanel4.TabIndex = 5;
            // 
            // grafikPanel3
            // 
            grafikPanel3.BackColor = Color.White;
            grafikPanel3.Location = new Point(317, 202);
            grafikPanel3.Name = "grafikPanel3";
            grafikPanel3.Size = new Size(90, 84);
            grafikPanel3.TabIndex = 4;
            // 
            // grafikPanel2
            // 
            grafikPanel2.BackColor = Color.White;
            grafikPanel2.Location = new Point(221, 202);
            grafikPanel2.Name = "grafikPanel2";
            grafikPanel2.Size = new Size(90, 84);
            grafikPanel2.TabIndex = 3;
            // 
            // grafikPanel
            // 
            grafikPanel.BackColor = Color.White;
            grafikPanel.Location = new Point(221, 67);
            grafikPanel.Name = "grafikPanel";
            grafikPanel.Size = new Size(378, 129);
            grafikPanel.TabIndex = 1;
            grafikPanel.Paint += grafikPanel_Paint;
            // 
            // humanBodyPanel
            // 
            humanBodyPanel.BackColor = Color.White;
            humanBodyPanel.Controls.Add(pictureBox1);
            humanBodyPanel.Location = new Point(28, 67);
            humanBodyPanel.Name = "humanBodyPanel";
            humanBodyPanel.Size = new Size(165, 219);
            humanBodyPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // middlePanel2
            // 
            middlePanel2.BackColor = Color.FromArgb(233, 233, 233);
            middlePanel2.Controls.Add(checkedListBox1);
            middlePanel2.Controls.Add(progressBar3);
            middlePanel2.Controls.Add(label6);
            middlePanel2.Controls.Add(label5);
            middlePanel2.Controls.Add(label4);
            middlePanel2.Controls.Add(progressBar2);
            middlePanel2.Controls.Add(progressBar1);
            middlePanel2.Controls.Add(label3);
            middlePanel2.Location = new Point(249, 374);
            middlePanel2.Name = "middlePanel2";
            middlePanel2.Size = new Size(613, 240);
            middlePanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 17);
            label3.Name = "label3";
            label3.Size = new Size(174, 38);
            label3.TabIndex = 5;
            label3.Text = "Diyet Listem";
            
            // 
            // smallLeftPanel3
            // 
            smallLeftPanel3.BackColor = Color.White;
            smallLeftPanel3.Location = new Point(1, 203);
            smallLeftPanel3.Name = "smallLeftPanel3";
            smallLeftPanel3.Size = new Size(192, 51);
            smallLeftPanel3.TabIndex = 1;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // process2
            // 
            process2.StartInfo.Domain = "";
            process2.StartInfo.LoadUserProfile = false;
            process2.StartInfo.Password = null;
            process2.StartInfo.StandardErrorEncoding = null;
            process2.StartInfo.StandardInputEncoding = null;
            process2.StartInfo.StandardOutputEncoding = null;
            process2.StartInfo.UserName = "";
            process2.SynchronizingObject = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 119);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 9;
            label5.Text = "Karbonhidrat";
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 71);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 8;
            label4.Text = "Protein";
           
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(28, 94);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(228, 15);
            progressBar1.TabIndex = 6;
            progressBar1.Value = 85;
            
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(28, 142);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(228, 14);
            progressBar2.TabIndex = 7;
            progressBar2.Value = 55;
           
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 169);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 10;
            label6.Text = "Yağ";
          
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(28, 192);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(228, 14);
            progressBar3.TabIndex = 11;
            progressBar3.Value = 55;
          
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Tavuk 300 gr", "Yumurta 3 Adet", "Ekmek 50 gr" });
            checkedListBox1.Location = new Point(306, 71);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(293, 70);
            checkedListBox1.TabIndex = 13;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(25, 580);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(144, 48);
            btnGüncelle.TabIndex = 14;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += button1_Click;
            // 
            // DanisanPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 215, 198);
            ClientSize = new Size(1110, 641);
            Controls.Add(middlePanel2);
            Controls.Add(smallLeftPanel3);
            Controls.Add(middlePanel1);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "DanisanPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanisanPanel";
            leftPanel.ResumeLayout(false);
            middlePanel1.ResumeLayout(false);
            middlePanel1.PerformLayout();
            humanBodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            middlePanel2.ResumeLayout(false);
            middlePanel2.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Panel middlePanel1;
        private Panel smallLeftPanel2;
        private Panel smallLeftPanel1;
        private Panel middlePanel2;
        private Panel smallLeftPanel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel humanBodyPanel;
        private PictureBox pictureBox1;
        private Panel grafikPanel;
        private Panel grafikPanel5;
        private Panel grafikPanel4;
        private Panel grafikPanel3;
        private Panel grafikPanel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private System.Diagnostics.Process process1;
        private System.Diagnostics.Process process2;
        private ProgressBar progressBar3;
        private Label label6;
        private Label label5;
        private Label label4;
        private ProgressBar progressBar2;
        public ProgressBar progressBar1;
        private CheckedListBox checkedListBox1;
        private Button btnGüncelle;
    }
}