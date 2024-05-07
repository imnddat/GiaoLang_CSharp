using System.Threading.Channels;

namespace LambdaExpression
{
    delegate void PlayNumberDelegate(int x); // nhóm hàm nhận vào 1 con x, muôn slamf gì với x thì làm
    // 3 cách chơi hàm: 
    // C1: làm 1 hàm tường minh - explicit, nhận x, làm gì đó, in ra kq
    // C2: làm 1 hàm ẩn danh - anonymous method/function - implicit, éo thèm đặt tên hàm
    //                          éo thèm viết code riêng, tất cả gom cho thằng delegate, nick name,
    //                          mày lấy code của tao, khỏi cần tên tao
    // C3: Từ C2 CẮT BỚT CODE DƯ THỪA!!! => LAMBDA EXPRESSION (CODE KHÁ GIỐNG EXPRESSION BODY KHI CÙNG XÀI => NHƯNG COI CHỪNG, KHÁC ĐẤY)

    // HÀM VÔ DANH RÚT GON => BIỂU THỨC LAMBDA
    // BIỂU THỨC LAMBDA LÀM HÀM VÔ DANH TRONG DELEGATE
    // HÀM VÔ DANH KO HẲN LÀ LAMBDA NẾU VẪN VIẾT FULL {}
    // LAMBDA GIỐNG EXPRESSION BODY VỀ KÝ HIỆU => VÀ SỰ LƯỢC BỚT NHƯNG EXPRESSION BODY PHẢI CÓ FULL CẢ TÊN HÀM
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayNumberDelegate playNumber = MakeTriple;
            playNumber(3);

            // C2: anonymous function
            playNumber = delegate (int x) { Console.WriteLine($"{x}{x}{x}{x}"); };
            playNumber(9);

            // C3: Lambda expression
            playNumber = (int xxx) => Console.WriteLine($"{xxx}{xxx}{xxx}{xxx}{xxx}");
            playNumber(10);

            // C3: RÚT GỌN HƠN 
            playNumber = (a) => Console.WriteLine($"{a} {a} {a} {a} {a} {a}");// vòng lên bên trên định nghĩa
                                                                         // ở delegate biết ngay (kiểu int,
                                                                         // ko cần ghi kiểu, ghi tên biến là đc)

            playNumber(68);

            // C3: RÚT GỌN HƠN NỮA
            playNumber = a => Console.WriteLine($"{a} {a} {a} {a} {a} {a} {a}");// vòng lên bên trên định nghĩa
                                                                         // ở delegate biết ngay (kiểu int,
                                                                         // ko cần ghi kiểu, ghi tên biến là đc)

            playNumber(6789);

            playNumber = ngocTrinh => Console.WriteLine($"{ngocTrinh}^3 = {Math.Pow(ngocTrinh, 3)}");
            playNumber(56); //175 616
        }

        // C1: HÀM TƯỜNG MINH
        static void MakeTriple(int n) => Console.WriteLine($"{n}{n}{n}");
        //                              expression body: hàm chỉ có 1 lệnh duy nhất, ko cần ngoặc hay return
    }
}
