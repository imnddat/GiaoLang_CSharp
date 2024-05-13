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

        public List<Book> GetAllBooks()
        {
            // gọi Repository, chính xác là gọi class
            // BookRepository trả về sách từ DB

            List<Book> arr = new List<Book>();

            arr.Add(new Book()
            {
                BookId = 1,
                BookName = "Đời Ngắn Đừng Ngủ Dài-Short Life Don't Sleep Long",
                Author = "Robin Sharma",
                PublicationDate = "2023-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 2,
                BookName = "Mình Là Nẵng, Việc Của Mình Là Chói Chang-I Am the Sun, My Job Is to Shine Bright",
                Author = "Kazuko Watanabe",
                PublicationDate = "2023-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 3,
                BookName = "Tuổi Trẻ Đáng Giá Bao Nhiêu-How Much Is Youth Worth",
                Author = "Rosie Nguyễn",
                PublicationDate = "2018-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 4,
                BookName = "Snow Crash",
                Description = "Hiro lives in a Los Angeles where franchises line the freeway...",
                Author = "Neal Stephenson",
                PublicationDate = "2001-01-01",
                BookCategoryId = 2
            });

            // object initialization
            return arr;
        }
    }
}
