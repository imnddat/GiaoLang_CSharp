namespace DelegateReview.AnonymousFunc
{
    // khai báo data type, class chứa các hàm thuộc style void F()
    public delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call method directly - not using delegate");
            PrintNumbers(); //ko xài thân chủ - luật sư, call hàm directly
                            // chơi trực tiếp hàm với tên gọi gốc - truyền thống

            NoInputNoOutputDelegate f = PrintNumbers; // ko dùng () vì đó là run hàm
            Console.WriteLine("Call method directly - not using delegate");
            f();

            f = delegate () // hàm ẩn danh - anonymous function
            {
                Console.WriteLine("The list of even number from 1 ... 100");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                        //Console.Write("{0} ", i);
                        //Console.Write($"{i} ");
                }

                Console.WriteLine();
            };
            //VIP ĐỂ KẾT THÚC 1 LỆNH - 1 PHÉP GÁN HỢP ĐỒNG LUẬT SƯ THÂN CHỦ
            //đoạn code ở trên, mày thuộc hàm nào??? hàm phải có tên
            //dạ đoạn code trên ngày xưa em thuộc hàm PrinteEvenNumbers
            //nay bán cái tên đi rồi, còn lại xử lí thôi, gọi hàm cũ qua tên
            //mới f, delegate uỷ quyền hàm cũ, xử lí hàm cũ cho chữ f nó đại diện

            //HÀM GỐC CẦN TÊN, MÀ SẼ GỌI QUA HỢP ĐỒNG VỚI LUẬT SƯ!!!
            //HÀM ẨN DANH - ANONYMOUS FUNCTION
            //ĐOẠN CODE CỦA HÀM GỐC, NAY DÙNG NICK NAME/TÊN LUẬT SƯ! ! !
            //CHỈ CÒN 1 TÊN MÀ KO LÀ TÊN GỐC
            //GỌI QUA TÊN MỚI
            //luật sư phát ngôn, run hàm
            Console.WriteLine("Call method indirectly - anonymous function");
            f();

            Console.WriteLine("Even - Odd numbers");
            // VIẾT HÀM IN RA CÁC SỐ "CHẴN + LẺ"
            f += delegate ()
            {
                Console.WriteLine("The list of odd number from 1 ... 100");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                    //Console.Write("{0} ", i);
                    //Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            Console.WriteLine("Call method indirectly - anonymous function again");
            //f.Invoke();

            // IN thêm dãy chia hết cho 5
            f += delegate () {
                Console.WriteLine("The list number % 5 from 1 ... 100");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 5 == 0)
                        Console.Write(i + " ");
                    //Console.Write("{0} ", i);
                    //Console.Write($"{i} ");
                }
            };
            f();


        }

        // CHALLENGE: VIẾT HÀM IN RA CÁC SỐ TỰ NHIÊN CHẴN TỪ 1...100
        //static void PrintEvenNumbers()
        //{
        //    Console.WriteLine("The list of even number from 1 ... 100");
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 2 == 0)
        //            Console.Write(i + " ");
        //        //Console.Write("{0} ", i);
        //        //Console.Write($"{i} ");
        //    }
        //    Console.WriteLine();
        //}


        // CHALLENGE: VIẾT HÀM IN RA CÁC SỐ TỰ NHIÊN TỪ 1...100

        static void PrintNumbers()
        {
            Console.WriteLine("The list of number from 1 ... 100");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
                //Console.Write("{0} ", i);
                //Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

    }
}
