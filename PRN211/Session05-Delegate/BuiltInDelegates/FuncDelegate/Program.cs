namespace FuncDelegate
{
    //C#13: VIẾT HÀM NHẬN VÀO 1 CON SỐ, SAU ĐÓ TRẢ VỀ BÌNH PHƯƠNG CỦA NÓ
    //CÓ RETURN, KO IN RA TRONG HÀM
    delegate double OneInputOneOutputDelegate(double x);
    //              double F(double x);

    //MS LẠI BẢO RẰNG, NẾU HÀM CÓ TRẢ VỀ GIÁ TRỊ int, long, char, Student, Car, Pet....
    //và hàm có thể có đầu vào hay ko, kệ, THÌ HÃY XÀI 1 DELEGATE STYLE GENERIC
    //TÊN LÀ FUNC
    //Func<int> -> hàm ko đầu vào, trả về int
    //Func<long> -> hàm ko đâu vào, trả vê Long
    //Func<string> -> hàm ko đầu vào, trả về string
    //Func<Dog> -> hàm ko đầu vào, trả về Dog
    //Func<int, int> -> hàm có đầu vào int, trả về int
    //Func<double, double, double> -> hàm có 2 đầu vào double double, trả về double
    //BÊN PHẢI NHẤT LÀ ĐẦU RA, CÒN LẠI LÀ ĐẦU VÀO, CHƠI GENERIC CẢ ĐÁM
    // HÀM 5 ĐẦU VÀO, + 1 ĐẦU RA => 6 GENERIC
    // HÀM CÓ TỐI ĐA 16 ĐẦU VÀO T1 T2 T3 ... T16 CỘNG VỚI THẰNG ĐẦU RA TResult
    // HÀM CÓ KO ĐẦU VÀO => HÀM 17 LOẠI HÀM

    //Func<int, int, long, char, Student, float, Pet, Lecture, ..., int>
    //     --------------------------------------------------       ----
    //              đầu vào                                         đầu ra


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#13: Method Return Value");
            OneInputOneOutputDelegate f1 = ComputeExponent;
            f1(5); //25 ko có 25 mặc dù vẫn tính
            var result = f1(5); //double result = f1(5);
            Console.WriteLine("5^2 = " + result);
            Console.WriteLine("10^2 = " + f1(10));

            //C#14: TÍNH BÌNH PHƯƠNG CỦA 1 CON SỐ RỒI TRẢ VỀ KQ
            Func<int, double> f2 = x => x*x;
            Console.WriteLine("C#14 - METHOD RETURNS VALUE USING FUNC<>");
            Console.WriteLine("1000^2 = " + f2(1000)); //1 triệu

            //C#15: TÍNH CHU VI TAM GIÁC
            Func<double, double, double, double> f3 = (a, b, c) => a + b + c;
            Console.WriteLine("C#15 - TRIANGLE FUNC<>");
            Console.WriteLine("3+4+5 = " + f3(3, 4, 5)); //12

            //C#16: VIẾT HÀM TRẢ VỀ 1 CON SỐ BẤT KỲ(NGẪU NHIÊN/BẠN THÍCH)

            Func<int> myNumber = () => 6789;// Java Math.Random(...);
            Console.WriteLine("C#16 - RANDOM NUMBER<>");
            Console.WriteLine("My own number " + myNumber());

            //C#17: VIẾT HÀM NHẬN VÀO 1 CON SỐ DOUBLE GPA - ĐIỂM TRUNG BÌNH
            //TRẢ VỀ TRUE NẾU GPA >= 8, TRẢ VỀ FALSE NẾU GPA < 8
            Console.WriteLine("C#17 - CHECK HÀNG");
            Console.WriteLine("10 >= 8? " + CheckGradeGtEq8(10));

            Func<double, bool> check = gpa => gpa >= 8;
            Console.WriteLine("5 >= 8? " + check(5));
        }

        //<html>    5 > 3           >< dùng đánh dấu tag
        //          5 &gt; 3
        //          greater than

        static bool CheckGpa(double gpa) => gpa >= 8;
        static bool CheckGradeGtEq8(double gpa)
        {
            //if(gpa >= 8)    // biểu thức so sánh luôn trả về true/false
            //    return true; // return luôn biểu thức so sánh cho rồi
            //                 // đằng nào cũng cần ném ra true/false   
            //                 // ném ra luôn biểu thức so sánh
            //return false;

            return gpa >= 8; //true/false
        }
        static double ComputeExponent(double x) => x * x;

        //static double ComputeExponent(double x)
        //{
        //    return x * x;
        //}
    }
}
