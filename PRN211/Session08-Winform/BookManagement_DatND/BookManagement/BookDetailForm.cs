﻿using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class BookDetailForm : Form
    {
        //vì DetailForm cx là 1 class, nên nó có prop như bt. Hơn bt
        //là nó là class có thể render(Bố/Cha clas Form của SDK lo
        //phần render - mối quan hệ kế thừa
        public Book SelectedBook { get; set; } = null;
        // mặc định form này mở lên, ko có book nào cả
        // nếu muốn có book thì phải .SelectedBook = cái muốn gắn vào!!!
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MỞ MÀN HÌNH DETAIL THÌ TA SẼ:
            //1. FILL ĐẦY CATEGORY DROPDOWN - LẤY DATA TỪ TABLE CATEGORY
            //2. NẾU LÀ EDIT 1 CUỐN SÁCH THÌ FILL DATA CỦA CUỐN SÁCH MÚN
            // EDIT VÀO CÁC Ô TƯƠNG ỨNG
            //3. NẾU LÀ TẠO MỚI CUỐN SÁCH, THÌ CỨ ĐỂ MÀN HÌNH TRỐNG CHỜ
            //USER NHẬP INFO - KO CẦN LÀM GÌ THÊM

            BookCategoryService cat = new BookCategoryService();
            cboBookCategoryId.DataSource = cat.GetAllCategory();
            cboBookCategoryId.DisplayMember = "BookGenreType";

            //chọn cột để lấy value thực sự cần dùng - what
            //you see is not what you get
            //Chọn Self Help dễ cho user →> code map sang
            //value 5 của cột BookCategoryId, dùng làm FK đẩy
            //vào table BOOK
            cboBookCategoryId.ValueMember = "BookCategoryId";

            //vi diệu
            //nhảy đến giá trị bất kì nào mình thích trong cbo
            //mặc định là đầu danh sách xổ 1
            //cboBookCategoryId.SelectedValue = 5; //default với mình là sách Self Help 

            //CHECK CÓ PHẢI LÀ EDIT KO
            // CHECK BIẾN SELECTEDBOOK COI CÓ ĐƯỢC SET KHÁC NULL KO
            // NẾU CÓ SÁCH THÌ FILL VÀO CÁC Ô
            if (SelectedBook != null)
            {
                lblTitle.Text = "Update Selected Book";
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookId.Enabled = false; // ko cho edit cột BookID trong Mode Edit
                txtBookName.Text = SelectedBook.BookName;
                txtBookDescription.Text = SelectedBook.Description;
                //dtpPublicationDate.Text = SelectedBook.PublicationDate.ToString();
                dtpPublicationDate.Value = SelectedBook.PublicationDate;
                //DateTime data type
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author;

                cboBookCategoryId.SelectedValue = SelectedBook.BookCategoryId;

            }
            else
            {
                lblTitle.Text = "Create a new Book";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtBookDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboBookCategoryId.SelectedValue.ToString())
            };

            BookService service = new BookService();
            if(SelectedBook != null)
            {
                service.UpdateBookFromUI(book);
            }else
            {
                service.AddBookFromUI(book);
            }

            Close(); // sau khi add/update thì tắt form detail
        }
    }
}
