namespace DelegateIntro
{
    // delegate sẽ khai báo ở bên ngoài class khác, và nằm dưới namespace/package
    // Solution có nhiều Project
    // Project có nhiều Namespace
    // Namespace có nhiều class

    // tao - delegate là 1 data type /class cho nhóm object phức tạp là cái đám hàm tao trỏ/quản lý, đại điện, tao bình đẳng với các class/data type khác

    public delegate void X(); // X: tui là class X đại diện cho 1 đám hàm ở dưới hay đâu đó có chung style là void ???()
                              // CHÍNH LÀ LỆNH KHAI BÁO CLASS VIẾT NGẮN GỌN - VIẾT NGOÀI CLASS KHÁC (NEWBIE)

    //public class X [void X()] Delegate
    //{
    //      public x(đưa-vào-tên-hàm-cần-cất-trữ)
    //      do X đại diện cho 1 đám hàm, đưa hàm đây tao cất trữ đại diện trỏ - delegate
    //}

    // X f = value là tên hàm ở dưới, là nick name cho tên hàm nào ở dưới
    //      f là tên gọi khác cho cái đám ở dưới cùng style X
    // int x = value


    // KHAI BÁO BIẾN VÀ SỬ DỤNG THÌ PHẢI Ở TRONG HÀM, HAY TRONG CLASS KHÁC NÀO ĐÓ !!!
    // X SẴN SÀNG LÀ DATA TYPE BÌNH ĐẲNG NHƯ PERSON, DOG, CAT, PET, RECTANGLE
    // DÙNG NHƯ DATA BÌNH THƯỜNG

    public class Person
    {
        
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Student s = new Student();
        //    //int   yob = 2003;
        //    //X     f1 = Tên hàm nào đó cùng style X đã định nghĩa ở trên
        //    //       f1 trỏ đến hàm đó cùng style X
        //    //      f1 là nick name, là đại diện, nhận ủy quyền, ủy nhiệm từ hàm khác
        //    //      f1 là con trỏ hàm, biến trỏ đến 1 hàm cụ thể
        //    //      f1 và hàm lúc này là 1
        //    //      gọi f1 cũng như gọi hàm
        //    //      dùng f1() và hàm() đểu run hàm như nhau
        //    //      run qua biến ủy quyền - run gián tiếp
        //    //      run trực tiếp tên hàm - run truyền thống

        //    X f1 = new X(TellHer);
        //    // f1 là tên khác, nick name của TellHer
        //    // f1 và TellHer là như nhau, là 1 lúc này f1 cũng là TellHer
        //    // giống như sếp là NTT, TB 1994, chúng ta của tương lai
        //    // f1 trỏ TellHer, f1 là con trỏ hàm
        //    // f1 đại diện cho TellHer, f1 là delegate 
        //    //      ủy quyền

        //    X f2 = NhanEm;
        //    // viết tắt, bỏ new chi=o tự nhiên như style để giống như int yob = 2003;
        //    // int[] arr = new int [300];
        //    // int[] arr = {5,10,15,20,25,30};
        //    // Student s = new Student (...);
        //    // Student s = new (...);

        //    // HẾT SỨC LƯU Ý, KHAI GÁN BIẾN / NICK NAME CHO 1 HÀM CỤ THỂ NÀO ĐÓ: TUYỆT ĐỐI KO GHI TÊN HÀM KÈM () DẤU NGOẶC!!!
        //    // VÌ GHI () NGHĨA LÀ RUN HÀM LUÔN RỒI
        //    // TRONG KHI ĐÓ LỆNH X f2 = NhanEm mang ý nghĩa là đặt nickname cho 1 hàm cụ thể nào đó, gán giá trị cho biến,
        //    // giá trị hơi đặc biệt 1 tí: giá trị là 1 cái hàm; đưa tên hàm chứ ko phải run() hàm

        //    //TellHer();
        //    //NhanEm();

        //    // GỌI HÀM
        //    // GỌI TRỰC TIẾP: NHƯ 2 LỆNH Ở TRÊN - TRUYỀN THỐNG

        //    // TA GỌI QUA CON TRỎ HÀM, BIẾN DELEGATE, BIẾN ỦY QUYỀN, BIẾN NICKNAME
        //    // BIẾN F1 ĐẠI DIỆN HÀM NÀO ĐÓ, GỌI HÀM TRỰC TIẾP HOẶC GỌI QUA ỦY QUYỀN

        //    f1(); // vì câu lệnh x f1 = TellHer; do đó TellHer() là chạy hàm
        //          // thì f1 cũng là chạy hàm TellHer();
        //          // gọi hàm gián tiếp, hàm đã được ỦỶ QUYỀN CHO THẰNG KHÁC CHẠY THAY VÌ TỰ CHẠY
        //          // ỦY QUYỀN, ỦY NHIỆM, ỦY THÁC, ĐẠI DIỆN => DELEGATE
        //          // DELEGATE: LÀ Ỹ THUẬT ĐẶT TÊN GỌI KHÁC CHO 1 CÁI HÀM CỤ THỂ NÀO ĐÓ!!!!
        //          // VÀ KHI ĐÓ HÀM CỤ THỂ SẼ CÓ 2 CÁCH GỌI: GỌI TRỰC TIẾP NHƯ XƯA NAY
        //          //                                        GỌI HÀM QUA TÊN NICK NAME ỦY QUYỀN
        //    f2();

        //    // CÁCH GỌI THỨ 3: gọi qua hàm Invoke() được tạo sẵn, giống .ToString()
        //    Console.WriteLine("Call message by using Invoke() method inside the X class");
        //    f1.Invoke(); // X là class có nhiều hàm bên trong như class Student
        //    f2.Invoke(); // bên trong còn chứa cả tên hàm !!!
        //                 // có quyền gọi hàm từ bên trong hay gọi tắt()
        //}


        // chơi delegate style nhiều hàm được nhồi vào biến thuộc style X
        // 1 LUẬT SỰ ĐẠI DIỆN NHIỀU THÂN CHỦ
        // 1 CON TRỎ TRỎ ĐA HÀM, VẪN 1 VÙNG NEW X()
        // X CÒN ĐÓNG VAI THÙNG CHỨA TÊN HÀM, BOX CHỨA TÊN HÀM, CABINET, CONTAINER
        // HƠN LÀ 1 CLASS CHỨA BÊN TRONG 1 INFO ĐƠN LẺ KIỂU PERSON, CAT, DOG
        //static void Main(string[] args)
        //{
        //    X f = new X(TellHer);  // int x = 10
        //    f += NhanEm;            // x += 5, ghép 10 + 5
        //    f += SayHelloToSweetHeart;

        //    // f là gã luật sư cho 3 thân chủ thay vì chỉ 1 - multicast delegates

        //    // GỌI 3 HÀM CÙNG LÚC
        //    //1. Gọi lẻ truyền thống TellHer() NhanEm() SayHelloTo()
        //    //2. Gọi qua f(), duyệt mảng/list các tên hàm đã add() vào và () và run ()
        //    //3. Gọi qua f.Invoke() duyệt mảng/list ...

        //    f();
        //}

        //static void Main(string[] args)
        //{
        //    X f = TellHer; // new X(TellHer); tạo ko giản để add nhiều hàm
        //    f += NhanEm;
        //    f += SayHelloToSweetHeart;

        //    f.Invoke(); // f()
        //}

        static void Main(string[] args)
        {
            X f = TellHer;
            f = NhanEm; // đè con trỏ

            f(); // đáp án ra gì???  int a = 10; a = 11 -> a đang là 11
                // TẠI 1 THỜI ĐIỂM BIẾN CHỈ LƯU 1 VALUE, TÊN GỌI ỨNG 1 VALUE !!!
                // TỪ BỎ THÂN CHỦ TELLHER KÝ HỢP ĐỒNG VỚI THÂN CHỦ MỚI
        }
        static void TellHer() => Console.WriteLine("Cuộc sống em ổn không. Xa anh elm phải anh phúc!!!");
        static void NhanEm() => Console.WriteLine("Chúc em hạnh phúc bên người. ");
        static void SayHelloToSweetHeart() => Console.WriteLine("Bánh mì ko? Hai ta về chung một nhà hem! Chúng ta của tương lai");

        // còn nhiều hàm nữa trong tương lai ở đây, mà có thể ở Project khác, ...DLL khác
        static void HelloWorld() => Console.WriteLine("Hello Delegate");
    }
}
