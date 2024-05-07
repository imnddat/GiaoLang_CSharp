namespace DelegateReview
{
    // MỘT NAMESPACE, KO GIAN, THƯ MỤC TRÊN GIẤY TỜ ĐỂ NÓI VỀ HỘ KHẨU CỦA CÁI CLASS, NƠI Ở, ĐỊNH CƯ CỦA CÁI CLASS. 
    // THƯỜNG MẶC ĐỊNH SẼ LẤY TÊN THƯ MỤC TRÊN HDD/SSD ĐỂ NÓI VỀ HỘ KHẨU CỦA 1 CLASS - TÊN NAMESPACE - TÊN PACKAGE
    // MỘT NAMESPACE SẼ CHỨA NHIỀU CLASS ~ CÁI KHUÔN SẼ NẰM Ở ĐÂU TRONG XƯỞNG SX
    // MỘT XƯỞNG CÓ NHIỀU KHUÔN - NAMESPACE CÓ NHIỀU CLASS
    // TA CÓ THỂ KHAI BÁO CÁC CLASS RIÊNG RẼ, MIỄN LÀ PHẦN ĐẦU NÓI RẰNG NÓ THUỘC VỀ KO GIAN NÀO,
    // HỘ KHẨU NÀO, NAMESPACE NÀO
    // ĐẦU TẬP TIN SOURCE CODE SẼ CHỨA CÁI KHAI BÁO NAMESPACE ĐỂ QUẢN LÝ CÁC CLASS THUỘC VỀ NÓ. 

    // TRONG 1 TẬP TIN SOURCE, TA CÓ THỂ KHAI BÁO CÁC CLASS KHÁC NGOÀI CLASS DEFAULT CÓ SẴN KHI TẠO TẬP TIN SOURCE

    public class Lecturer
    {

    }
    public class Student
    {
        // là 1 cái khuôn có nhiều khoảng trống bên trong để đổ vào các info của 1 object cần đúc, cần lưu trữ
    }

    // Student      s                   = new Student(...) {...};
    //data-type     biến/nickname               object, value
    //              tên gọi cho 1               phức tạp

    // delegate là kỹ thuật thiết kế 1 cái class đặc biệt
    // class này ko lưu info của các object theo style truyền thống;
    // mà nó đi lưu thông tin là: TÊN CỦA CÁC HÀM TỒN TẠI ĐÂU ĐÓ NGOÀI KIA

    //public class X [void X()] : Delegate
    //{
    //    // biến lưu 1 tên hàm, hay nhiều tên hàm
    //    //_list-tên-của-các-hàm-cần-lưu-trỏ-đến

    //    public X(đưa-vào-tên-hàm-cần-lưu) { ... }

    //    public void Invoke() // dùng để duyệt qua danh sách các hàm đang có và run() hàm luôn
    //}

    // xài class đặc biệt này: 
    // X        f =    new X(đưa-hàm-nào-đó-vào-đây);
    //Student   biến        value - là tên hàm nào đó

    // CHO PHÉP VIẾT NGẮN GỌN CÚ PHÁP KHAI BÁO CLASS LƯU TRỮ TÊN HÀM
    delegate void X(); // tui X đại diện cho 1 loạt các hàm có cùng style void F()

    // MỘT NAMESPACE SẼ CHỨA 3 THẰNG NGANG CƠ NHAU - CÙNG LEVEL: 
    //1. CLASS TRUYỀN THỐNG: STUDENT, PERSON, DOG, PET,...
    //2. INTERFACE - DẠNG CLASS ĐẶC BIỆT (CHỨA HÀM ABSTRACT KO CÓ CODE)
    //3. DELEGATE - DẠNG CLASS ĐẶC BIỆT (CHỨA BÊN TRONG TÊN HÀM)

    //CHALLENGE: LÀM VIỆC VỚI CÁC HÀM CÓ SYTLE VOID F() - DÙNG CLASS STYLE DELEGATE

    public delegate void NoInputNoOutputDelegate();

    // XÀI CLASS TRONG CLASS KHÁC VÌ CLASS LÀ DATA TYPE
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f1 = new NoInputNoOutputDelegate(TellHerMessage1);
            //                      f1 là tên gọi khác, nickname, 2nd name của hàm gốc có tên TellHerMessage1
            // có thể hình dung: muốn chơi với hàm TellHerMessage1; ta có thể dùng tên gọi thay thế là f1
            //                  LUẬT SƯ =    THÂN CHỦ
            //HÃY NÓI CHUYỆN VỚI F CŨNG CHÍNH LÀ NÓI CHUYỆN VỚI TELLHERMESSAGE1
            //1 HÀM CÓ 2 TÊN
            //CUỐI GIỜ: BÁN 1 TÊN CHO QUỶ DỮ!!! CHỈ CÒN LẠI 1 TÊN, NHƯNG KO LÀ TÊN GỐC

            NoInputNoOutputDelegate f2 = TellHerMessage2; //new ngầm, làm biếng xài new
            //gọi 2 hàm thử coi
            //thay vì gọi trực tiếp, làm việc trực tiếp với tên gốc của hàm
            //ta làm việc qua nick name, 2nd name, luật sư
            //f2 = TellHerMessage2          thì f2() = TellHerMessage2()
            //bằng nhau về tên gọi          bằng nhau về run() hàm

            Console.WriteLine("See messages lst time...");
            f1();
            f2.Invoke(); //tương đương nhau, vào trong vùng new để lôi các tên hàm gốc ra và run()
                         //luật sư nói là thân chủ nói, nick name run() nghĩa là hàm gốc run()

            //Program app = new ProgramO;
            //app.TellHerMessage30);

            Console.WriteLine("See messages 2nd time...");
            f1();
            f2 = new Program().TellHerMessage3;
            f2.Invoke(); //f2();

            Console.WriteLine("See messages 3rd time ...");
            f1 += new Program().TellHerMessage3; // cộng đôn int a = 5; a += 5 => a = 10
            f1(); // 1  3
            f2(); // 3
                  //1 LUẬT SƯ ĐẠI DIỆN CHO NHIỀU THÂN CHỦ
                  //1 TÊN ĐẠI DIỆN CHO NHIỀU TÊN HÀM GỐC
                  //MUTTCAST DFI FGATFSI
        }

        static void TellHerMessage1()
        {
            Console.WriteLine("1. Cuộc sống elm ổn ko?");
        }
        static void TellHerMessage2() => Console.WriteLine("2. Xa anh em phải hạnh phúc!");
        // expression body: hàm chỉ có 1 lệnh; dẹp luôn return nếu có
        //                  dùng => để tách riêng tên hàm và thân hàm (body of function)
        //                  nhưng hàm phải vẫn còn đầy đủ tên họ
        // vì nó rất giống biểu thức lambda - lambda expression, nhưng khác

        public void TellHerMessage3() => Console.WriteLine("3. Giữa Mai và Đào, anh chỉ được chọn elm.");
    }
}
