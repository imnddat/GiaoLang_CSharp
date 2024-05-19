using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        // class này chơi trực tiếp với SQL Server qua DbContext (có sẵn CS)
        // class này sẽ bị gọi bởi BookService
        // UI <---> BookService <---> BookRepository ---> DbContext <---> Table
        // [1]          [2]                 [3]
        // UI phải khai báo Service
        //      Service phải khai báo Repo
        //              Repo phải khai báo Context
        //                      Context phải khai báo Connection String

        //TA Ở ĐÂY BỊ SERVICE GỌI
        //TA Ở ĐÂY ĐI GỌI DBCONTEXT
        //TA CUNG CẤP CÁC HÀM CRUD TABLE BOOK CƠ BẢN
        //AddBook() UpdateBook() DeleteBook() GetBooks() Get() lấy 1 cuốn

        private BookManagementDbContext _context;
        // ko new, sẽ new ở từng hàm trong Repo

        public List<Book> GetBooks()
        {
            //_context = new BookManagementDbContext();
            _context = new();
            return _context.Books.ToList();
        }

        //hàm này sẽ cập nhật 1 cuốn sách có sẵn, phải nhờ đến DbContext như thường lệ
        //Cuốn sách đưa cho hàm này từ trên UI -> Service -> đây là Repo -> gọi DbContext, chỗ nào đó phải new Book() và đẩy vào hàm này
        public void UpdateBook(Book book)
        {
            _context = new();
            _context.Books.Update(book);//SQL: UPDATE BOOK SET BOOKNAME = ... ....WHERE
                                        // BOOKID = book.BookId
            _context.SaveChanges(); // run sql
        }

        public void AddBook(Book book)
        {
            _context = new();
            _context.Books.Add(book);//SQL: INSERT BOOK VALUES(BookId = book.BookId,...

            _context.SaveChanges(); // run sql
        }

        public void DeleteBook(Book book)
        {
            _context = new();
            _context.Books.Remove(book);

            _context.SaveChanges();
        }
    }
}
