using Repositories;
using Repositories.Entities;

namespace Services
{
    //3-layer Architecture
    // UI-Forms --- Services ---    Repositories ---                    DB
    // MainUI ---   BookService --- BookRepository (Book Entity) ---    Book Table
    // request/reponse          <-------->      
    // đưa data xuống DB                    Chơi trực tiếp DB: lên, xuống
    // lấy data từ DB show                                      CRUD table thực sự
    //      RAM                                             DB ĐĨA CỨNG HDD/SSD
    public class BookService
    {
        //class này trung chuyển dữ liệu giữa Forms UI vs CSDL
        // nó chứa data trong RAM, xử lý mọi thứ thuật toán nếu cần rồi đẩy lên UI
        // hoặc cất xuống DB
        // chứa các list các Book đọc từ DB và show UI
        // chứa info cuốn sách lấy từ màn hình UI dự định cập nhật xuống DB

        // THƯỜNG SẼ CHỨA CÁC HÀM CRUD NHƯNG CHỈ TRONG RAM - LINQ CÓ THỂ NHẢY VÀO

        //giả bộ đã đọc data từ DB lên rồi, giờ show ra màn hình UI
        //tạm thời hard-coded danh sách các cuốn sách trong RAM
        //bữa tới học cách lấy từ DB thực sự
        //lấy xong thì cx phải có n cuốn sách trả về trong RAM

        // gọi Repo để lấy data từ DB thực sự
        //làm ẩu thì có thể gọi trực tiếp DbContext
        //làm 3-layer thì Service gọi Repo, Repo gọi DbContext, DbContext chứa kết nối CSDL
        //nhờ ai giúp thì phải khai báo người đó

        private BookRepository _repo = new BookRepository();

        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

        public void AddBookFromUI(Book book)
        {
            _repo.AddBook(book); // chuyển theo dây chuyền UI -> Service -> Repo -> DbContext
        }

        public void UpdateBookFromUI(Book book)
        {
            _repo.UpdateBook(book); // chuyển theo dây chuyền UI -> Service -> Repo -> DbContext
        }

        public void DeleteBookFromUI(Book book)
        {
            _repo.DeleteBook(book);
        }
    }
}
