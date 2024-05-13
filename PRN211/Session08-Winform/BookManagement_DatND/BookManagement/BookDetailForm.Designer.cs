namespace BookManagement
{
    partial class BookDetailForm
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
            label1 = new Label();
            btnSave = new Button();
            grbBookDetail = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtBookDescription = new TextBox();
            lblCategory = new Label();
            lblPrice = new Label();
            lblAuthor = new Label();
            llbQuantity = new Label();
            lblDate = new Label();
            lblBookDescription = new Label();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookID = new Label();
            lblTitle = new Label();
            btnCancel = new Button();
            grbBookDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 65);
            label1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(758, 145);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // grbBookDetail
            // 
            grbBookDetail.BackColor = SystemColors.GradientInactiveCaption;
            grbBookDetail.Controls.Add(cboBookCategoryId);
            grbBookDetail.Controls.Add(dtpPublicationDate);
            grbBookDetail.Controls.Add(txtAuthor);
            grbBookDetail.Controls.Add(txtPrice);
            grbBookDetail.Controls.Add(txtQuantity);
            grbBookDetail.Controls.Add(txtBookDescription);
            grbBookDetail.Controls.Add(lblCategory);
            grbBookDetail.Controls.Add(lblPrice);
            grbBookDetail.Controls.Add(lblAuthor);
            grbBookDetail.Controls.Add(llbQuantity);
            grbBookDetail.Controls.Add(lblDate);
            grbBookDetail.Controls.Add(lblBookDescription);
            grbBookDetail.Controls.Add(txtBookName);
            grbBookDetail.Controls.Add(txtBookId);
            grbBookDetail.Controls.Add(lblBookName);
            grbBookDetail.Controls.Add(lblBookID);
            grbBookDetail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grbBookDetail.Location = new Point(30, 110);
            grbBookDetail.Name = "grbBookDetail";
            grbBookDetail.Size = new Size(675, 494);
            grbBookDetail.TabIndex = 0;
            grbBookDetail.TabStop = false;
            grbBookDetail.Text = "Book Detail";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(256, 435);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(180, 25);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(256, 264);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(180, 25);
            dtpPublicationDate.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAuthor.Location = new Point(256, 382);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(250, 25);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice.Location = new Point(513, 323);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(120, 25);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantity.Location = new Point(256, 323);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 25);
            txtQuantity.TabIndex = 4;
            // 
            // txtBookDescription
            // 
            txtBookDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBookDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookDescription.Location = new Point(256, 155);
            txtBookDescription.Multiline = true;
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.ScrollBars = ScrollBars.Vertical;
            txtBookDescription.Size = new Size(377, 80);
            txtBookDescription.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(59, 435);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 21);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(420, 322);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 21);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.Location = new Point(59, 381);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(61, 21);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author";
            // 
            // llbQuantity
            // 
            llbQuantity.AutoSize = true;
            llbQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llbQuantity.Location = new Point(59, 322);
            llbQuantity.Name = "llbQuantity";
            llbQuantity.Size = new Size(72, 21);
            llbQuantity.TabIndex = 7;
            llbQuantity.Text = "Quantity";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(59, 267);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(129, 21);
            lblDate.TabIndex = 6;
            lblDate.Text = "Publication Date";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookDescription.Location = new Point(59, 159);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(94, 21);
            lblBookDescription.TabIndex = 5;
            lblBookDescription.Text = "Description";
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookName.Location = new Point(256, 101);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(250, 25);
            txtBookName.TabIndex = 1;
            // 
            // txtBookId
            // 
            txtBookId.BorderStyle = BorderStyle.FixedSingle;
            txtBookId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookId.Location = new Point(256, 50);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(160, 25);
            txtBookId.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.Location = new Point(59, 105);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(95, 21);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookID.Location = new Point(59, 50);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(68, 21);
            lblBookID.TabIndex = 3;
            lblBookID.Text = "Book ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(30, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(550, 71);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(758, 223);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 47);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(984, 631);
            Controls.Add(btnCancel);
            Controls.Add(grbBookDetail);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "BookDetailForm";
            Text = "BookDetailForm";
            Load += BookDetailForm_Load;
            grbBookDetail.ResumeLayout(false);
            grbBookDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private GroupBox grbBookDetail;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private Label lblBookName;
        private Label lblBookID;
        private Label lblTitle;
        private Label lblPrice;
        private Label lblAuthor;
        private Label llbQuantity;
        private Label lblDate;
        private Label lblBookDescription;
        private Button btnCancel;
        private DateTimePicker dtpPublicationDate;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtBookDescription;
        private Label lblCategory;
        private ComboBox cboBookCategoryId;
    }
}