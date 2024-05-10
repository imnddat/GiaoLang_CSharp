using System.Xml;

namespace ActionGenericDelegate
{
    //C#6: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    // VIẾT HÀM LẺ CÓ SẴN NGOÀI KIA
    // ANONYMOUS FUNC, LAMBDA EXPRESSION => XÀI DELEGATE ÒI

    //C#7: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    //              DÙNG ANONYMOUS

    //C#8: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    //              DÙNG Lambda expression


    //MICROSOFT BẢO RẰNG: HÀM MÀ KO TRẢ RA GÌ CẢ, GỌI LÀ HÀNH ĐỘNG, ACTION
    //TUY NHIÊN CÓ LOẠI HÀNH ĐỘNG/HÀM CÓ CẦN ĐẦU VÀO, 1 ĐẦU, 2 ĐẦU, 3 ĐẦU VÀO...
    //N ĐẦU VÀO -> CŨNG LÀ HÀNH ĐỘNG, CŨNG LÀ ACTION
    //TUY THẾ 1 ĐẦU VÀO CÓ THỂ INT, LONG, STUDENT, FLOAT
    //2 ĐẦU VÀO CÓ THỂ LÀ INT| INT, INT/LONG, STRING/STRING, STRING/INT...

    //HÀM NHIỀU THAM SỐ | THAM SỐ KHÁC NHAU VỀ DATA TYPE, THỨ TỰ DATA TYPE!!!
    //VÔ CHỪNG LOẠI HÀM NHƯ THẾ NÀY???
    //GENERIC XUẤT HIỆN, DÙ BẠN INT, LONG, CHAR, PERSON, STUDENT, BẠN LÀ DATA TYPE <T>
    //MÀ THÔI, LÚC NÀO CẦN DÙNG, THAY<T> BẰNG DATA TYPE CỤ THỂ

    public delegate void OneInputNoOutputDelegate(int n);
    //                  void F(int x)
    //KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, KO ĐẦU VÀO, THÌ XÀI
    //                  Action f = ...
    //KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, CÓ ĐẦU VÀO, 1, 2, 3, 4,... 16 ĐẦU VÀO
    //THÌ XÀI, KHAI BÁO, DÙNG DELEGATE CÓ SẴN, STYLE GENERIC NHƯ SAU

    //Action<int>           f = hàm có 1 đầu vào int
    //Action<char>          f = hàm có 1 đầu vào char
    //Action<Student>       f = hàm có 1 đầu vào Student
    //Action<int, int>      f = hàm có 2 đầu vào int, int
    //Action<Student, int>  f = hàm có 2 đầu vào String, int
    //Action<16 đầu vào>    f = hàm có 16 đầu vào, tuỳ data type bạn cần


    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("C#6: Call method as normal");
        //    ComputeExponent(5);

        //    Console.WriteLine("C#7: Call method using anonymous func");
        //    OneInputNoOutputDelegate f1 = ComputeExponent; //đc quyền hàm cùng style, BẰNG TÊN HÀM NÀO ĐÓ NGOÀI KIA, HÀM CÓ 2 TÊN, THÊM NICK
        //    OneInputNoOutputDelegate f2 = delegate (int xxx)
        //    {
        //        Console.WriteLine($"{xxx}^2 = {xxx * xxx}");
        //        Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");
        //    };
        //    f2(10);

        //    Console.WriteLine("C#8: Call method using lambda expression");
        //    OneInputNoOutputDelegate f3 = (int xxx) => { };
        //    OneInputNoOutputDelegate f4 = (xxx) => { };
        //    OneInputNoOutputDelegate f5 = xxx => { };
        //    OneInputNoOutputDelegate f6 = xxx => Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");
        //    f6(100);
        //}

        static void Main(string[] args)
        {
            OneInputNoOutputDelegate f1 = ComputeExponent;// truyền thống

            Action<int> f2 = ComputeExponent;
            Console.WriteLine("C#9: Using Action<> Generic on the method with up to 16 params");
            f2(20);

            //C#10: DÙNG ACTION<> TÍNH MŨ 3 CỦA 1 CON SỐ VÀ IN RA. DÙNG LUÔN
            //ANONYMOUS & LAMBDA EX
            Action<int> f3 = delegate(int x)
            {
                Console.WriteLine($"{x}^2 = {Math.Pow(x, 3)}");
            };
            Action<int> f4 = (int x) => 
            { 
                Console.WriteLine($"{x}^2 = {Math.Pow(x, 3)}"); 
            };
            Action<int> f5 = x => Console.WriteLine($"{x}^3 = {Math.Pow(x, 3)}");
            Console.WriteLine("C#10: ^3");
            f5(30);

            //C#11: VIẾT HÀM IN RA DIỆN TÍCH HÌNH CHỮ NHẬT - WIDTH, LENGTH
            Console.WriteLine("C#11: Compute Rectangle Area:");
            Action<double, double> f6 = ComputeRectangleArea;
            Action<double, double> f7 = (double x, double y) => { };
            Action<double, double> f8 = (x, y) => Console.WriteLine($"Dien tich Hinh chu nhat: {x*y}");
            f8(4, 5);

            //C#12: IN RA CÁC SỐ CHẴN TỪ 1 ĐẾN N...
            Console.WriteLine("C#12: Even Numbers ");
            Action<int> printEvens = n => 
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be > 0");
                    return;
                }   
                Console.WriteLine($"The list of even numbers from 1..{n}");
                for (int i = 1; i <= n; i++)
                {
                    if(i%2 == 0)
                        Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            printEvens(100);
        }

        static void ComputeExponent(int x) => Console.WriteLine($"{x}^2 = {Math.Pow(x, 2)}");

        static void ComputeRectangleArea(double width, double length)
        {
            Console.WriteLine($"Area ({width}x{length}) = {width * length}");
        }

        static void PrintNumbers(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("n must be > 0");
                return;
            }
            Console.WriteLine($"The list of even numbers from 1..{n}");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
            //static void ComputeExponent(int x) {
            //    double result = Math.Pow(x, 2);
            //    Console.WriteLine($"{x}^2 = {result}");
            //    Console.WriteLine($"{x}^2 = {x*x}");
            //    Console.WriteLine($"{x}^2 = {Math.Pow(x,2)}");
            //}
        }
}
