namespace AnonymousFunc
{
    // khai báo class Delegate map vào/đại diện cho đám hàm void F(int), có vào ko ra
    // đại diện cho 2 hàm ở dưới luôn do phù hợp format style

    delegate void PlayNumberDelegate(int x); // map, đại diện 

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Play methods with an input and return nothing-void");
        //    PlayNumberDelegate playNumber = CloneNumber; // nhân bản 3 lần
        //    // Muốn gọi CloneNumber(5) phải đưa data vào
        //    // playNumber biến đại diện = tên hàm gốc, thì đại diện cx đưa data vào như bản gốc

        //    playNumber(5);
        //    playNumber.Invoke(3);

        //    // muốn gọi hàm bình phương, gọi mình nó, hay nối tiếp với hàm đã ủy quyền trước đó; dùng =; hoặc +=;
        //    Console.WriteLine("In ra bình phương");
        //    playNumber = PowerBy2Number; // tớ playNumber là tên khác cảu cậu, nick
        //                                 // cam kết kết nối, chưa run(); CẤM KO () HIỂU LÀ RUN,
        //                                 // MỚI ỦY QUYỀN CHƯA THỰC THI, THỰC THI CẦN () PHẢI SAU KHI ỦY QUỀN
        //    playNumber.Invoke(10); //100
        //    playNumber(5);//25

        //    // MULTICAST
        //    playNumber += CloneNumber; // Power() trước rồi Clone() sau
        //    playNumber(6); // 6^2 = 36; 666

        //}

        // hàm mà sẽ đem đi cho thằng khác gọi, đặt nick name, thì để ở đâu cũng được,
        // miến là phài thuộc về class, nếu là static thì phải chấm trực tiếp
        //                              nếu là non-static thì phải new rồi mới chấm

        //OOP căn bản

        // hàm nhận vào 1 con số, in ra con số đó 3 lần sát nhau
        static void CloneNumber(int n) => Console.WriteLine($"{n}{n}{n}");

        // hàm nhận vào 1 con số, in ra bình phương của nó
        static void PowerBy2Number(int x)
        {
            Console.WriteLine($"The {x}^2 = {x * x}"); // interpolation
            //Console.WriteLine("The " + x + "^2 =" + (x*x)); // ghép chuỗi
            //Console.WriteLine("The {0}^2 = {1}", x, (x*x));  // place holder
        }

        // TUI MUỐN CÓ HÀM NHẬN VÁO 1 CON SỐ NGUYÊN NHƯNG: IN RA, LẶP LẠI THÀNH 4 SỐ
        // NHẬN 9 => 9999
        // C1: TẠO HÀM 4 SỐ CHÍN NHƯ 3 SỐ Ở TRÊN - TẠO HÀM TƯỜNG MING - EXPLICIT
        static void CloneNumbersLikeGoldFormat(int n) => Console.WriteLine($"{n}{n}{n}{n}");

        // C2: DÙNG ANONYMOUS FUNCTION: THIẾT KẾ 1 HÀM KO THÈM CÓ TÊN, CHỈ CẦN ĐẦU VÁO TUÂN THEO
        // ĐỊNH DẠNG CỦA DELEGATE ĐÃ KHAI BÁO; VIẾT CODE NGAY TRÊN CÂU LỆNH GÁN HỢP ĐỒNG ỦY QUYỀN
        //static void Main(string[] args)
        //{
        //    //      void F(int x)
        //    //PlayNumberDelegate playNumber = CloneNumbersLikeGoldFormat;
        //    //playNumber(9);

        //    PlayNumberDelegate playNumber = delegate (int n) { Console.WriteLine($"{n}{n}{n}{n}"); };
        //    // ĐEM CODE NGAY ĐÂY, LÀM BIẾNG LÀM HÀM RỜI CÓ TRƯỚC | TÊN HÀM KO QUAN TRỌNG, ĐẶT LÀ GÌ CX ĐC
        //    // CODE LÀ QUAN TRỌNG VÌ DÍNH ĐỄN XỬ LÝ CHỮ DELEGATE Ở LỆNH GÁN CHÍNH LÀ THAY CHO 1 TÊN HÀM
        //    // LẼ RA VIẾT TÊN RIÊNG CHỖ KHÁC 
        //    playNumber(9);// HÀM KO CÓ TÊN, THÌ SAO GỌI ĐƯỢC, ĐƯA TÊN ĐÓ CHO TK NICK DELEGATE GIỮ GIÙM;
        //                  // BẢN CHẤT HÀM VẪN CÓ TÊN, LẤY TÊN NICK NAME RA DÙNG
        //                  // HÀM KO CÓ TÊN, MAY QUÁ, CÓ NICK ĐỂ GỌI, GỌI HÀM TRỞ LẠI QUỸ ĐẠO BÌNH THƯỜNG,
        //                  // ÍT NHẤT PHẢI CÓ 1 TÊN, HOẶC 2 TÊN ỦY QUYỀN
        //                  // EM SINH RA ÉO CÓ TÊN, ỦY QUYỀN TÊN LUÔN - ANONYMOUS FUNCTION 
        //                  // HÀM VÔ DANH, GỌI EM QUA NICK NAME - ON THE GO - TAKE A WAY
        //                  // HÀM CƠ ĐỘNG NGAY Ở CHỖ ỦY QUYỀN

        //}

        static void Main(string[] args)
        {
            // TUI MUỐN CÓ HÀM MŨ 5 , 10^5 = 10*10*10*10*10 = 100000
            // C1: LÀM 1 HÀM CỐ ĐỊNH NHƯ Ở TRÊN
            // C2: ANONYMOUS FUNC
            PlayNumberDelegate playNumber = delegate (int x) { Console.WriteLine($"{x}^5 = {x*x*x*x*x}"); };

            playNumber(10);// 100 000
        }

    }
}
