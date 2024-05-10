namespace ActionDelegate
{
    //CHALLENGE #1: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM ĐÃ RA VIỆN RỒI!!!
    //                             VIẾT THEO STYLE TRUYỀN THỐNG, NHỚ RUN HÀM

    //CHALLENGE #2: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM VÀ 35 TRIỆU!!!
    //              DÙNG DELEGATE & ANONYMOUS FUNCTION

    //CHALLENGE #3: VIẾT HÀM IN RA CÂU THÔNG BÁO: 8/3/2024: CHÚNG TA CỦA TƯƠNG LAI
    //              DÙNG LAMBDA

    //CHALLENGE #4: DÙNG LẠI C#1 KẾT HỢP VỚI DELEGATE

    //C#5: KO DÙNG DELEGATE DO TA TẠO RA, NOINPUTNOUTPUTDELEGATE() ANY MORE
    //MICROSOFT, .NET SDK CUNG CẤP SẴN CHO TA 1 DELEGATE STYLE VOID F()
    //GỌI LÀ: Action, làm đi, hành động đi, run đi, vậy thoy, ko cần vào, ko cần ra
    //NẾU SAU NÀY BẠN CẦN LÀM VIỆC VỚI HÀM KO-VÀO-KO-RA THÌ TA KO CẦN TẠO DELEGATE
    //MÀ XÀI LUÔN Action và chỉ việc khai báo biến = trỏ đến hàm nào là xong

    //C#5: VIẾT HÀM IN RA CÂU THÔNG BÁO "8/3/2K4: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG
    //M-TP vs.HẢI TÚ vS. THIỀU BẢO TRÂM"

    delegate void NoInputNoOutputDelegate();
    //      void    F() style

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Challenge 1: Call Method As Normal");
        //    ShowNotification();

        //    Console.WriteLine("Challenge 2: Call method using anonymous function");
        //    NoInputNoOutputDelegate f = delegate ()
        //    {
        //        Console.WriteLine("Nam em và 35 triệu\n");
        //    };
        //    f();

        //    Console.WriteLine("Challenge 3: Call method using lambda expression");
        //    NoInputNoOutputDelegate f1 = () =>
        //    {
        //        Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI\n");
        //    };

        //    NoInputNoOutputDelegate f2 = () => Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI\n");
        //    f2.Invoke();

        //    Console.WriteLine("Challenge 4:Call method using delegate & explicit method");
        //    NoInputNoOutputDelegate f3 = ShowNotification;
        //    f3();

        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Use Action");
            Action f1 = ShowNotification;
            f1.Invoke();

            Action f2 = () =>
            {
                Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs.HẢI TÚ vS. THIỀU BẢO TRÂM");
            };
            f2();

            Action f3 = () => Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs.HẢI TÚ vS. THIỀU BẢO TRÂM");
            f3();
        }
        static void ShowNotification() => Console.WriteLine("2/2/2024: Nam Em đã ra viện!!!\n");
        // expression body


    }
}
