using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    internal class NumberService
    {
        static private List<int> _arr = new List<int> { -55, -10, -1, 10, 15, 20, 1, 3, 5, 7, 99, 100, 101 };

        public static void PrintNumbers(Action<int> f)
        {
            //for (int i = 0; i < _arr.Count; i++)
            //{
            //    f(_arr[i]);
            //}
            foreach (var x in _arr)
            {
                f(x);
                //tao lần lượt gửi data cho mày, cho hàm f() hàm f() làm gì với data kệ
                //nếu f() check x > 0 mới in, PrintNumbers() chính là hàm in ra các số > o
            }

        }
        //style cũ: thiết kế đủ các loại hàm cung cấp data! Đủ cỡ nào cx ko là đủ, do nhu
        //cầu tính toàn khác nhau trên bộ data: có người tính chẵn, lẻ, âm, dương, nguyên
        //tố, chia hết 5, chia 10...

        // VIẾT HÀM ĐẾM CÁI GÌ ĐÓ TRONG DÃY SỐ TRÊN: ĐẾM CHẴN, ĐẾM LẺ, ĐẾM NGUYÊN TỐ

        public static void Count1(Func<int, bool> f) // hàm CheckNT(int)
        {
            int count = 0;
            foreach (var x in _arr)
            {
                if (f(x)) count++;
            }
            Console.WriteLine("Count: " + count);
        }

        public static void Count2(Predicate<int> f) // hàm CheckNT(int)
        {
            int count = 0;
            foreach (var x in _arr)
            {
                if (f(x)) count++;
            }
            Console.WriteLine("Count: " + count);
        }

    }
}
