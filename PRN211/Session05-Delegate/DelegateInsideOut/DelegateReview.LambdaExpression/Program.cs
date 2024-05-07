using System.Linq.Expressions;

namespace DelegateReview.LambdaExpression
{
    //CHALLENGE: IN CHO TUI TÔNG CÁC SÔ TỪ 1..100 -> 5050
    //hàm void F()
    delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f = delegate () // anonymous function
            {
                int sum = 0;
                for (int i = 0; i <= 100; i++)
                {
                    sum += i;

                }
                Console.WriteLine("The sum 1 ... 100: " + sum);
            };

            f.Invoke();

            //tui mún tính tổng các số chẵn từ 1..10
            //2 4 6 8 10 => 30
            //KĨ THUẬT RÚT GỌN PHÂN SỐ/BIỂU THỨC
            //RÚT GỌN ANONYMOUS METHOD ĐỂ CHỈ CÒN CÁI DÂY NIT => LAMBDA EXPRESSION
            f = () =>
            {
                int sum = 0;
                for (int i = 0; i <= 10; i++)
                {
                    if (i % 2 == 0)
                        sum += i;

                }
                Console.WriteLine("The sum of even numbers from 1 to 10: " + sum);
            };
            f();
            //BIỂU THỨC LAMDA: BẢN CHẤT LÀ HÀM ANONYMOUS NHƯNG VIẾT RÚT GỌN ĐẾN MỨC TỐI GIẢN
            //Có CÂU: LAMDA LÀ ANONYMOUS
            //ANONYMOUS KO HẲN LÀ LAMDA NẾU CHƯA RÚT GỌN TỐI GIẢN

            //EXPRESSION BODY VÀ LAMBDA EXPRESSION XÀI CHUNG KÝ HIỆU =>
            //NHƯNG KHÁC NHAU:
            // * EXPRESSION BODY: hàm vẫn còn FULL TÊN, hàm chỉ có 1 lệnh, rút gọn luôn cả cặp dấu {}
            // * LAMBDA EX: bối cảnh hàm vô danh, chơi với delegate
            //              hàm ko có tên, có thể rút gọn {}
            //              hoặc ko tuy hàm có nhiều lệnh hay ít lệnh. Hàm 1 lệnh được quyền loại bỏ {}

            //CÚ PHÁP GÕ LAMDA
            //Tên-data-type-delegate biến-trỏ-hàm = delegate () {...}; //ANONYMOUS

            // LAMBDA
            //Tên - data - type - delegate biến - trỏ - hàm = () => { ...}:
            //                                                RÚT GỌN TIẾP...
            // RÚT GỌN CHỈ CHỪA LẠI THAM SỐ () => VỚI THÂN HÀM {}
        }
    }
}
