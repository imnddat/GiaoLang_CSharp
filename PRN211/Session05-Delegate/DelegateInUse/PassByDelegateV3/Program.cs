using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PassByDelegateV3
{
    //C#5: IN RA LỜI CỦA 2 BÀI HÁT THÔNG QUA TRUYỀN HÀM IN BÀI HÁT VÀO 1 HÀM IN TẬP TRUNG;
    // 1 HÀM CHỊU TRÁCH NHIỆM THẦU/MỘT CÁI HUB TRUNG TÂM
    // NHẬN CÁC LỆNH IN KHÁC NHAU ĐƯỢC ĐƯA VÀO !!!

    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSongLyricThe1();
            PrintSongLyricLover();

            Console.WriteLine("C#5: CALL 2 EXPLICIT METHODS VIA DELEGATE VAR");
            Action f = PrintSongLyricThe1; //luật sư = thân chủ
            f += PrintSongLyricLover;//luật sư = 2 thân chủ

            f(); //2 thân chủ cùng đc nói qua miêng của f, run()
            Console.WriteLine("\n\nC#5: CALL 2 EXPLICIT METHODS AS TRADITIONAL\n");
            PrintOnDemand(); //RUN HÀM CHÍNH ONDEMAND() THÌ 2 HÀM CON BÊN TRONG ĐC RUN()

            Console.WriteLine("\n\nC#5: PRINT ON DEMAND - DEPENDENCY INJECTION STYLE\n");
            //PrintOnDemand(Action f = tên hàm nào đó có sắn, nhiều hàm có sắn);
            //PrintOnDemand(Action f = một biến f đc trỏ sẵn tên hàm);
            //PrintOnDemand(Action f = anonymous function);
            //PrintOnDemand(Action f = lambda expression):
            //PrintOnDemand (Action f = () => {});
            //PrintOnDemand (Action f = delegate() {});
            //HÀM NGOÀI ĐC TRUYỀN VÀO HÀM CHÍNH POD()
            //1 LOGIC XỬ LÍ BÊN NGOÀI ĐC PASS VÀO BÊN TRONG HÀM CHÍNH POD(???)
            //DEPENDENCY INJECTION
            //HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGẢ THAM SỐ => LẬP TRÌNH HÀM - FUNCTIONALPROGRAMMING

            //HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGẢ THAM SỐ => HÀM CHÍNH LÀM GÌ THÌ LÀM ĐI
            //                              NHỚ GỌI HÀM QUA NGẢ THAM SỐ SAU KHI CHÁN CHÊ
            //CALL BACK FUNCTION

            //JAVA: CÓ LAMBDA EX
            //  TRUYỀN HÀM VÀO PHẢI BAO CÁI HÀM LẠI TRONG 1 INTERFACE CHỈ CÓ DUY NHẤT
            //  1 HÀM - INTERFACE CHỈ CÓ DUY NHẤT 1 HÀM GỌI LÀ @Functional Interface
            //      dùng kèm với kỹ thuật ANONYMOUS CLASS

            //ĐỪNG NHẦM LẪN PASS HÀM VÀO HÀM VỚI PASS 1 OBJECT STUDENT S VÀO 1 HÀM
            //void PrintOnDemand(Student s) //truyền tham chiếu, truyền nhiều hàm của
            //OBJECT; KO TRUYỀN HÀM ĐƠN NHƯ MÌNH ĐANG HỌC!!!KO LAMBDA VÀ DELEGATE GÌ CẢ
            //KO CALLBACK GÌ CẢ

            Action fxxx = PrintSongLyricThe1;
            fxxx += PrintSongLyricLover;
            fxxx += PrintSongLyricsAugust;

            // GỌI HÀM CHÍNH, DEPENDENCY INJECTION - TAO CHÍCH VÀO HÀM CHÍNH 3 CÁI HÀM KHÁC
            PrintOnDemand(fxxx);

            //C#6: TUI MUỐN IN BÀI HÁT TIẾP THEO: CAROLINA - TAYLOR SWIFT
            // CHƠI QUAN IN DỊCH VỤ:
            //PrintOnDemand(PrintSongLyricLover); // (Action f = PrintSongLyricLover;)
            Console.WriteLine("\n\nC#5: PRINT ON DEMAND - DEPENDENCY INJECTION STYLE USING ANONYMOUS & LAMBDA EX\n");

            PrintOnDemand(delegate ()
            {
                Console.WriteLine("\n\nThe song Carolina - by Taylor Swift\n\n");
            });

            PrintOnDemand(() => { Console.WriteLine("\n\n8/3/2024 > Chúng ta của tương lai | Sơn Tùng MTP vs Hải Tủ\n\n"); });
            //HÀM NÀO MÀ NHẬN VÀO DELEGATE, THÌ HÀM NÀY KHI RUN, NÓ RUN LUÔN HÀM DELEGATE BÊN TRONG - CALL BACK
            //GỌI 1 HÀM RUN, NHƯNG LÀ 2 HÀM RUN() HÀM CHÍNH TRAI BAO BÊN NGOÀI VÀ HÀM TRUYỀN THÁI Y VÀO

            //Action f2 = delegate () { };
            //PrintOnDemand(f2);
            // nguyên lý dấu = 

            //C#6: HÃY IN RA CÁC SỐ TỪ 1...100
            //c#7: HÃY IN RA CÁC SỐ NGUYÊN TỐ TỪ 1 .... 100
            // ĐỀU LÀ HÀM ACTION F
            Console.WriteLine("C#6: Hàm KLQ"); //NHƯNG ỐN, VÌ CHỈ LÀ VOID F() THÔI MÀ
                                               //ĐƯA HÀM ĐÂY, TAO GỌI THEO NHU CÂU ACTION CỦA MÀY

            // CLASS CÓ HÀM NHẬN DELEGATE BÊN NGOÀI ĐƯA VÀO, XÀI DI, CLASS LINH HOẠT VỚI
            // CÁC XỬ LÝ ĂN THEO NHU CẦU BÊN NGOÀI. TÁC GIẢ CỦA HÀM KHỎI MẤT CÔNG SUY NGHĨ NHIỀU
            // VỀ NÊN CUNG CẤP MÓN GÌ, AI MUỐN GÌ ĐƯA VÀO TUI HÀM CHÍNH PHỤC VỤ

            // DELEGATE VÀ EVENT LÀ TRI KỈ!!!!
            // LOOSE COUPLING , DI
            PrintOnDemand(() =>
            {
                Console.WriteLine("The list of numbers from 1 ... 100");
                for (int i = 1; i <= 100; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            });
        }

        static void PrintOnDemand() // hàm chính
        {
            Console.WriteLine("The main-method code ... code ....");
            Console.WriteLine("The main-method code ... code ....");
            Console.WriteLine("Call 2 sub-method to print");
            PrintSongLyricThe1(); // 2 hàm con
            PrintSongLyricLover();

            PrintSongLyricsAugust(); // sửa hàm chính ở phút cuối
            // TIGHT COUPLING - HÀM CHÍNH PrindOnDeman() phụ thuộc vào 3 hàm
            // hard-code luôn. SAU NÀY MUỐN IN BÀI KHÁC, 1 BÀI KHÁC THÌ PHẢI SỬA CODE TRỰC TIẾP

            // CÓ CÁCH HAY HƠN: IN GÌ THÌ ĐƯA VÀO, TRONG HÀM CHÍNH PrintOnDemand
            // chỉ có LỆNH IN ĐÚNG CÁI ĐƯA VÀO, đưa vào gì in cái đó, ko HARD-CODE gì cả
            // -> LOOSE COUPLING - RÀNG BUỘC LỎNG LẺO, FLEXIBLE, ADAPTIVE VỚI BÊN NGOÀI ĐƯA VÔ
            // THAY VÌ MÌNH GẮN CỨNG VỚI THỨA ĐÃ LÀM SẴN

            // TUI - PintOnDemand() ko gắn hard-code với hàm nào cả, muốn làm gì thì đưa tên vào
            // bên ngoài vào đây, tao in cho, tao gọi cho

        }

        static void PrintOnDemand(Action f) // hiện tương Overload/overloading
        {
            Console.WriteLine("The main-method code ... code ....");
            Console.WriteLine("The main-method code ... code ....");
            Console.WriteLine("Call any outside method passed into...");
            Console.WriteLine("For now I'm flexible to receive your request");
            Console.WriteLine("Tell me, what do you want, I call it/do it for you ...");

            f(); //RUN BẤT KÌ HÀM NÀO ĐƯA VÀO QUA NGẢ THAM SỐ!!!!!!!!!
                 //GIỐNG RUN() 3 HÀM CŨ HARD-CODE Ở DƯỚI
                 //NAY ĐƯA TÊN HÀM MÚN RUN QUA NGÃ THAM SỐ
                 //ĐƯA TỪNG 3 THẮNG Ở DƯỚI QUA NGÀ THẠM SỐ, 3 HÀM VẪN ĐC RUN NHƯ CŨ!!!
                 //NHƯNG NAY CÒN RUN ĐC HÀM BẤT KÌ MIỄN LÀ GỬI QUA THAM SỐ ACTION ĐÚNG STYLE HÀM
                 //LOOSE COUPLING
                 //DEPENDENCY INJECTION: CHÍCH VÀO CHO EM 1 HÀM KHÁC BÊN NGOÀI QUA NGẢ THAM SỐ
                 //CHÍCH/PASS HÀM NÀO, RUN HÀM ĐÓ

            //PrintSongLyricsThel(); //3 HÀM HARD-CODE, TIGHT-COUPLING
            //PrintSongLyricsLover();
            //PrintSongLyricsAugust);  //GỌI CHUNG NÓ LÀ CHỮ F TỪ BÊN TRÊN ĐƯA VÀO
        }

        public static void PrintSongLyricsAugust()
        {
            Console.WriteLine("The song August - by Taylor Swift");
            Console.WriteLine();
        }


        public static void PrintSongLyricThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"I'm doing good, I'm on some new shit
...
");//verbatim
        }

        public static void PrintSongLyricLover()
        {
            Console.WriteLine("The song Lover - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"We could leave the Christmas lights up 'til January
...
");
        }
    }
}
