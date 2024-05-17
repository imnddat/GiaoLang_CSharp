namespace BookManagement
{
    partial class BookManagerMainUI
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
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            lblBookList = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            grbAction = new GroupBox();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grbAction.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(29, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(397, 71);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.BackColor = SystemColors.GradientInactiveCaption;
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grbSearchCriteria.Location = new Point(29, 114);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(917, 100);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = "Search Criteria";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(772, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.Location = new Point(555, 50);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(160, 25);
            txtDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookName.Location = new Point(174, 50);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(160, 25);
            txtBookName.TabIndex = 0;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookDescription.Location = new Point(392, 50);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(136, 21);
            lblBookDescription.TabIndex = 4;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.Location = new Point(59, 50);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(95, 21);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBookList.Location = new Point(29, 242);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(99, 30);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(26, 46);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(178, 47);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(26, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(26, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 47);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(748, 604);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(29, 289);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowTemplate.Height = 25;
            dgvBookList.Size = new Size(653, 400);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // grbAction
            // 
            grbAction.Controls.Add(btnCreate);
            grbAction.Controls.Add(btnUpdate);
            grbAction.Controls.Add(btnDelete);
            grbAction.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grbAction.Location = new Point(722, 289);
            grbAction.Name = "grbAction";
            grbAction.Size = new Size(224, 273);
            grbAction.TabIndex = 2;
            grbAction.TabStop = false;
            grbAction.Text = "Action";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(984, 731);
            Controls.Add(grbAction);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblTitle);
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grbAction.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbSearchCriteria;
        private Label lblBookList;
        private TextBox txtBookName;
        private Label lblBookDescription;
        private Label lblBookName;
        private Button btnSearch;
        private TextBox txtDescription;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExit;
        private DataGridView dgvBookList;
        private GroupBox grbAction;
    }
}
