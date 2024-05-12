namespace PassByFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TÍNH TỔNG CHẴN
            Console.WriteLine("Sum of evens");
            SumOnDemand(CheckEven);

            //TÍNH TỔNG LẺ
            Console.WriteLine("Sum of odds");
            SumOnDemand(xx => xx % 2 != 0);

            //TÍNH TỔNG TẤT CẢ
            Console.WriteLine("Sum all");
            SumOnDemand(x => true);
            // đưa x nào cũng là true, hàm trả về true cho mọi x
        }

        static bool CheckEven(int n) => n % 2 == 0; // expression body


        //static bool CheckEven(int x)
        //{
        //    if(x%2==0) // nó mang đúng/sai - true/false
        //        return true;
        //    return false;
        //}

        //CHALLENGE: VIẾT GÀM TÍNH TỔNG CỦA 1 DÃY SỐ CHO TRƯỚC
        //           VẪN DÃY SỐ ĐÓ TỔNG SỐ CHẴN, TỔNG SỐ LẺ
        //          VẪN DÃY SỐ ĐÓ, ĐẾM CÁC SỐ LẺ

        static void DoOnDemand(Predicate<int> f)
        {

        }

        //TÍNH TOÁN THEO ĐIỀU KIỆN ĐƯA VÀO:
        //SUM: SUM CÁI GÌ (ĐK ĐƯA VÀO): SUM CHĂN, SUM LẺ, SUM NGUYÊN TỐ
        //COUNT: COUNT CÁI GÌ
        static void SumOnDemand(Func<int, bool> f) // hàm bool F(int x)
        {                                           // checkEven(int x) -> true/false
            List<int> arr = new List<int>() { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int result = 0;

            foreach (int x in arr)
            {
                if (f(x) == true) // checkEven(x)
                    result += x;
            }
            Console.WriteLine("Sum: " + result);
        }


        static void DoOnDemand()
        {
            List<int> arr = new List<int>() { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int result = 0;

            foreach (int x in arr)
            {
                result += x;
            }

            foreach (int x in arr)
            {
                if (x % 2 == 0)    //if đúng con x (tiêu chí nào đó) thì
                {
                    result += x;
                }
            }
            foreach (int x in arr)
            {
                if (x % 2 != 0)  //if đúng con x (tiêu chí nào đó) thì
                    result++;
            }
        }
    }
}
