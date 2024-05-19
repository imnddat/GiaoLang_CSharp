namespace BookManagement
{
    partial class LoginForm
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
            grbAccountInfo = new GroupBox();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblTitle = new Label();
            grbAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbAccountInfo
            // 
            grbAccountInfo.BackColor = SystemColors.GradientActiveCaption;
            grbAccountInfo.Controls.Add(btnCancel);
            grbAccountInfo.Controls.Add(btnLogin);
            grbAccountInfo.Controls.Add(txtPassword);
            grbAccountInfo.Controls.Add(txtEmail);
            grbAccountInfo.Controls.Add(lblPassword);
            grbAccountInfo.Controls.Add(lblEmail);
            grbAccountInfo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic);
            grbAccountInfo.Location = new Point(107, 177);
            grbAccountInfo.Name = "grbAccountInfo";
            grbAccountInfo.Size = new Size(564, 303);
            grbAccountInfo.TabIndex = 0;
            grbAccountInfo.TabStop = false;
            grbAccountInfo.Text = "Account Info";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(336, 226);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 28);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnLogin.Location = new Point(150, 226);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 28);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtPassword.Location = new Point(237, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(247, 25);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtEmail.Location = new Point(237, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 25);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(87, 142);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(87, 76);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold);
            lblTitle.Location = new Point(194, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(397, 71);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Book Manager";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(grbAccountInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            grbAccountInfo.ResumeLayout(false);
            grbAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbAccountInfo;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblTitle;
        private Button btnCancel;
    }
}