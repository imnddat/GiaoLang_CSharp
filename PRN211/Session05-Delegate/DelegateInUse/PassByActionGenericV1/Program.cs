namespace PassByActionGenericV1
{
    //CHALLENGE #1: VIẾT HÀM NHẬN VÀO CON SỐ, IN RA CON SỐ ĐÓ NẾU ĐÓ LÀ SỐ CHẴN
    //                                                                  SỐ LẺ
    //                                        IN RA CON SỐ ĐÓ NẾU CON SỐ ĐÓ >= SỐ ĐÓ 
    //                                          IN RA CON SỐ ĐÓ NẾU NÓ LÀ SỐ NGUYÊN TỐ

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //gọi lẻ 4 hàm là style truyền thống, ko thèm nói
        //    PrintEvenNumber(5); // ko in
        //    PrintOddNumber(5); // 5
        //    PrintPrimeNumber(5); // 5
        //    PrintNumberGtEq50(5); // ko in
        //    Console.WriteLine("Round 2");
        //    PrintEvenNumber(10); //10
        //    PrintOddNumber(11); //11
        //    PrintPrimeNumber(13); //13
        //    PrintNumberGtEq50(50);//50
        //}


        //làm hàm style thầu dịch vụ
        static void PrintOnDemand()
        {
            PrintEvenNumber(10); //10
            PrintOddNumber(11); //11
            PrintPrimeNumber(13); //13
            PrintNumberGtEq50(50);//50 // tight coupling, luôn luôn chạy 4 hàm, thêm hàm phải sửa code
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Print even number from 5 10 15 20");
        //    PrintOnDeman(PrintEvenNumber); //IN CHẴN TỪ DÃY 5 10 15 20

        //    Console.WriteLine("Print odd number from 5 10 15 20");
        //    PrintOnDeman(PrintOddNumber); //IN lẻ TỪ DÃY 5 10 15 20

        //    Console.WriteLine("Print prime number from 5 10 15 20");
        //    PrintOnDeman(PrintPrimeNumber); //IN TỪ DÃY 5 10 15 20

        //    Console.WriteLine("Print >=50 number from 5 10 15 20");
        //    PrintOnDeman(PrintNumberGtEq50); //IN TỪ DÃY 5 10 15 20

        //    //C2: IN RA CÁC SỐ CHIA HẾT CHO 5
        //    //C3: CÓ SỐ NÀO, IN SỐ ĐÓ
        //    Console.WriteLine("Print divisable by 5 numbers from 5 10 15 20 25 26 29");
        //    PrintOnDeman(xxx =>
        //    {
        //        if (xxx % 5 == 0)
        //            Console.WriteLine(xxx);

        //    });

        //    Console.WriteLine("Print all numbers from 5 10 15 20 25 26 29");
        //    PrintOnDeman(xxx => { Console.WriteLine(xxx); });
        //    //tao cung cấp 1 con xxx bên trong của tao cho mày, mày làm gì với x kệ mày
        //    //có thằng sẽ check xxx là nguyên tố thì mới in, có thằng thì check chẵn
        //    //mới in, có thằng ko check gì cả in luôn! ! ! ! !!!!!!


        //}
        //TAO LÀ 1 HÀM NHẬN VÀO 1 HÀM KHÁC CÓ THAM SỐ INT X
        //tao chịu trách nhiệm gọi hàm bên ngoài đưa vào, tao thảy cho nó 1 con số
        //tao phó mắc cho hàm đó làm gì thì làm với con số tao thảy cho
        //TAO TRỞ NÊN LINH HOẠT VỚI NHU CẦU XỬ LÍ DATA CỦA MỌI NGƯỜI
        //KHI TAO CHỈ THẢY DATA CỦA TAO CHO MỌI NGƯỜI
        static void PrintOnDemand(Action<int> f) // PrintEvenNumber = lambda
        {
            // giả sử mình có sẵn data 5 10 15 20 25 26 29
            f(5); // f đại diện - luật sư của nhiều hàm khác cùng style void F(int x)
            //data bên trong class mình viết chưa HamBao() sẽ gửi cho hàm đâu đó bên ngoài
            f(10);
            f(15);
            f(20);
            f(25);
            f(26);
            f(29);
            //NHỜ BÊN NGOÀI FILTER DATA THEO CÁCH CỦA HỌ
            //TẬP DATA 5 10 15 20... TRONG NỘI TẠI SẼ ĐC CUNG ỨNG RA BÊN NGOÀI
            //BÊN NGOÀI XEM XÉT DATA PHÙ HỢP HAY KO VÀ SẼ DÙNG
            //CUNG ỨNG DỊCH VỤ XỬ LÍ DATA THEO NHU CẦU
            //BÁC NÀO MÚN XỬ LÍ, EM ĐƯA DATA BÁC LO XỬ LÍ
        }

        static void Main(string[] args)
        {
            Console.WriteLine(">=50");
            PrintOnDemandV2(PrintNumberGtEq50);

            //C#4: IN SỐ CHIA HẾT CHO 3
            Console.WriteLine("Divisable by 3");
            PrintOnDemandV2(ahihi =>
            {
                if (ahihi % 3 == 0)
                    Console.WriteLine(ahihi);
            });
        }
        static void PrintOnDemandV2(Action<int> f) // PrintEvenNumber = lambda
        {
            // NẾU TA CÓ NHIỀU DATA CẦN SÀNG LỌC THEO NHU CẦU BÊN NGOÀI, ĐƯA DATA VÀO MẢNG

            // LEVEL HÔM QUA: TAO GỌI MÀY, MÀY LÀM ĐI Action f, LÀM TRỌN GÓI ĐÓNG KÍN
            // LEVEL HÔM NAY: TAO GỌI MÀY, MÀY LÀM ĐI Action<int> f.
            //              TAO TỬ TẾ GỬI THÊM INFO CHO MÀY, MÀY LÀM GÌ INFO KỆ MÀY

            // NẾU TAO CÓ NHIỀU DATA, TAO ĐƯA HẾT CHO MÀY QUA VÒNG FOR() MỚI GỌI ĐƯỢC MÀY NHIỀU LẦN;
            // MÀY LÀM GÌ VỚI ĐÁM DATA VÀ KÊU GỌI XỬ LÝ Ở BÊN NGOÀI

            // BÊN NGOÀI MUỐN IN CHẴN, IN LẺ, IN NGUYÊN TỐ, ÂM DƯƠNG... HỖ TRỢ HẾT

            List<int> list = new List<int> { 5, 10, 15, 20, 1, 3, 5, 7, 100, 101,99 };
            foreach (var x in list)
            {
                f(x);
            }
        }

        static void PrintEvenNumber(int n)
        {
            if (n % 2 == 0) Console.WriteLine("{0}", n); //place holder
        }

        static void PrintOddNumber(int n)
        {
            if (n % 2 != 0) Console.WriteLine($"{n}"); // interpolation
        }

        static void PrintNumberGtEq50(int n)
        {
            if (n >= 50) Console.WriteLine(n);
        }
        static void PrintPrimeNumber(int n)
        {
            if (n < 2)
                return;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return;

            }
            Console.WriteLine("{0}", n);
        }
    }
}
