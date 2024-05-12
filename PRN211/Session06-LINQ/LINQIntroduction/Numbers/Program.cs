namespace Numbers
{
    // CHALLENGE #1: LƯU TRỮ 1 DANH SÁCH SỐ NGUYÊN CHO TRƯỚC
    //              SAU ĐÓ IN RA: CÁC SỐ DƯƠNG
    //                              CÁC SỐ ÂM
    //                              CÁC SỐ NGUYÊN TỐ
    //                              CÁC SỐ CHIA HẾT CHO 5...
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //IN TẤT CẢ
        //    Console.WriteLine("Print all");
        //    PrintListOnDemand(x => true);

        //    //IN SỐ DƯƠNG
        //    Console.WriteLine("-------------------------------");
        //    Console.WriteLine(" > 0 ");
        //    PrintListOnDemand(x => x > 0);
        //}

        static void Main(string[] args)
        {
            //PlayWithBuiltInOnDemandMethods();
            PlayWithBuiltInOnDemandMethodsV2();
        }

        static void PlayWithBuiltInOnDemandMethodsV2()
        {
            List<int> arr = new List<int>() { -10, -100, 50, 2, 1, 5, 10, 13, -2 };

            var result = from x in arr // với mọi x thuộc tập arr
                         where x > 0 // xem x nào > 0
                         select x; // thì lấy x đó mà trả về dùng tiếp
            // câu query giống như sql dùng để truy vấn data trong ram - LINQ THEO STYLE QUERY SYNTAX

            //RUNTIME CHẠY THÌ CONVERT VỀ LAMBDA NHƯ ĐÃ VIẾT, . WHERE(X => x > 0)
            //METHOD SYNTAX

            Console.WriteLine(">0 using query");
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Divisable by 2");
            result = from x in arr
                     where x % 2 == 0
                     select x;
            result.ToList().ForEach(x => Console.WriteLine(x));

        }
        static void PlayWithBuiltInOnDemandMethods()
        {
            List<int> arr = new List<int>() { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            // tui muốn in tất cả dãy số
            //arr có sẵn 1 loạt các hàm để xử lý data mà nó cất trữ, thay vì ta phải tự làm.
            //Hàm style on demand cũng cần Action, Action<>, Func<>, Predicate<>
            //tùy hàm loại hàm: count, sum, trung bình...

            //1. In tất cả
            Console.WriteLine("Print all");
            arr.ForEach(x => Console.WriteLine(x));

            //2. In số âm
            Console.WriteLine("Print < 0");
            arr.ForEach(x => { if (x < 0) Console.WriteLine(x); });

            //3. Trả vê các dương cho tui 50, 2, 1, 5, 10, 13
            //HÀM DEMAND TRẢ VÊ LIST ĐỂ TA DÙNG TIÊP THAY VÌ CHỈ IN RA
            Console.WriteLine("<0 List => Print list");
            List<int> result = arr.Where(x => x > 0).ToList();
            result.ForEach(x => Console.WriteLine(x));
        }

        static void PrintListOnDemand(Predicate<int> f)
        {
            List<int> arr = new List<int>() { -10, -100, 50, 2, 1, 5, 10, 13, -2 };

            foreach (var x in arr)
            {
                if (f(x))
                    Console.WriteLine(x);
            }
        }
    }
}
