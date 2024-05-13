namespace Zodiac
{
    partial class ZodiacManager
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
            lblTitle = new Label();
            picImage = new PictureBox();
            btnShowImage = new Button();
            pnlImage = new Panel();
            btnCheckZodiac = new Button();
            btnQuit = new Button();
            lblDay = new Label();
            lblMonth = new Label();
            lblYourZodiac = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(52, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(349, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Zodiac Calculator";
            // 
            // picImage
            // 
            picImage.BackColor = SystemColors.ActiveCaption;
            picImage.Location = new Point(25, 17);
            picImage.Name = "picImage";
            picImage.Size = new Size(415, 410);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 1;
            picImage.TabStop = false;
            // 
            // btnShowImage
            // 
            btnShowImage.FlatStyle = FlatStyle.Flat;
            btnShowImage.ForeColor = Color.Black;
            btnShowImage.Location = new Point(164, 256);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(102, 32);
            btnShowImage.TabIndex = 3;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = SystemColors.ControlLight;
            pnlImage.Controls.Add(picImage);
            pnlImage.Location = new Point(478, 55);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(459, 442);
            pnlImage.TabIndex = 3;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.FlatStyle = FlatStyle.Flat;
            btnCheckZodiac.ForeColor = Color.Black;
            btnCheckZodiac.Location = new Point(36, 256);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(102, 32);
            btnCheckZodiac.TabIndex = 2;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = true;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.ForeColor = Color.Black;
            btnQuit.Location = new Point(294, 256);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(102, 32);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.Location = new Point(41, 113);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(96, 17);
            lblDay.TabIndex = 6;
            lblDay.Text = "Your Birth Day";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonth.Location = new Point(41, 171);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(114, 17);
            lblMonth.TabIndex = 7;
            lblMonth.Text = "Your Birth Month";
            // 
            // lblYourZodiac
            // 
            lblYourZodiac.AutoSize = true;
            lblYourZodiac.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblYourZodiac.Location = new Point(36, 346);
            lblYourZodiac.Name = "lblYourZodiac";
            lblYourZodiac.Size = new Size(181, 28);
            lblYourZodiac.TabIndex = 8;
            lblYourZodiac.Text = "Your Zodiac sign is";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(185, 112);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(100, 23);
            txtDay.TabIndex = 0;
            txtDay.Text = "1";
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(185, 170);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(100, 23);
            txtMonth.TabIndex = 1;
            txtMonth.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 510);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 9;
            label1.Text = "fb/imnddat";
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(984, 561);
            Controls.Add(label1);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblYourZodiac);
            Controls.Add(lblMonth);
            Controls.Add(lblDay);
            Controls.Add(btnQuit);
            Controls.Add(btnCheckZodiac);
            Controls.Add(pnlImage);
            Controls.Add(btnShowImage);
            Controls.Add(lblTitle);
            Name = "ZodiacManager";
            Text = "Zodiac Calculator";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox picImage;
        private Button btnShowImage;
        private Panel pnlImage;
        private Button btnCheckZodiac;
        private Button btnQuit;
        private Label lblDay;
        private Label lblMonth;
        private Label lblYourZodiac;
        private TextBox txtDay;
        private TextBox txtMonth;
        private Label label1;
    }
}
