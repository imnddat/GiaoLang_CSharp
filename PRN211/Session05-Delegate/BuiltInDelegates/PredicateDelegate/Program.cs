namespace PredicateDelegate
{
    //MICROSOFT BẢO RẰNG: NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO, CHỈ CÓ 1 ĐẦU VÀO VÀ
    //HÀM TRẢ VỀ ĐÚNG SAI
    //MỞ RỘNG THÊM: TOÁN LOGIC, TOÁN MỆNH ĐỀ - CÂU PHÁT BIỂU ĐÚNG SAI
    //CÓ HÀM MỆNH ĐỀ - HÀM NHẬN 1 ĐẦU VÀO SAU ĐÓ TRẢ VỀ 1 CÂU PHÁT BIỂU ĐÚNG
    //SAI HÀM NÀY ĐC GỌI LÀ HÀM TIÊN ĐOÁN, HÀM DỰ ĐOÁN, HÀM MỆNH ĐỀ, HÀM ĐÁNH
    //GIÁ, HÀM LƯỢNG GIÁ, PREDICATE - LOGIC VỊ TỰ

    // Ông X là 1 nhà toán học -> câu này ko biết đúng sai, vì X là biển
    //Hàm IsNhaToanHoc( ông/bà X nào đó)
    //Hàm nhận vào con người, trả ra đúng sai nếu đó là nhà toán học hay ko
    //  IsNhaToanHoc(Ngô Bảo Châu )
    //              => Ông Ngô Bảo Châu là 1 nhà toán học => mệnh đề ĐÚNG
    //  IsNhaToanHoc(giáo.làng ) => SAI MOẸ NÓ RỒI, GÃ LÀM THUÊ CHO TƯ BẢN
    //ĐAM MÊ CODE, KO ĐAM MÊ TIỀN 7H SÁNG ĐẾN 7H5P CÒN VÀI PHÚT NỮA! ! !

    // Predicate(???) => true/false
    // HÃY ĐOÁN XEM ??? LÀ ĐÚNG HAY SAI

    //MICROSOFT BẢO RẰNG: NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO, CHỈ CÓ 1 ĐẦU VÀO VÀ HÀM
    //TRẢ VỀ ĐÚNG SAI
    //THAY VÌ KHAI BÁO Func<double, bool> THÌ KHAI BÁO LÀ Predicate<doube> là đủ
    //THAY VÌ KHAI BÁO Func<int, bool> THI KHAI BÁO LÀ Predicate<int> là đủ
    //THAY VÌ KHAI BÁO Func<Student, bool> THÌ KHAI BÁO LÀ Predicate<Student> là đủ
    //kiểm tra xem Student x có đúng là???
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#18: VIẾT HÀM TRẢ VỀ 1 CON SỐ GPA, TRẢ VỀ NÓ LỚN HƠN HAY BẰNG 8 HAY KO
            Func<double, bool> checkGPA = gpa => gpa >= 8;
            Predicate<double> checkGPA1 = gpa => gpa >= 8;
            //                  hàm     nhận vào
            //                          con gpa     trả ra có đúng là
            //                                      nó lớn hơn 8 hay ko?
            // đúng sai
            Console.WriteLine("Final fantasy: 10>=8? " + checkGPA1(10));

            //LINQ TRONG COLLECTION, LIST TOÀN XÀI LAMBDA!!! FILLTER DATA
            // LỆNH CUỐI CÙNG
            //CÂU VIEW
            var x = 2004.715; //7h15PM
            var fx = (double a, double b, double c) => a + b + c;
            Func<double, double, double, double> fxx = (a, b, c) => a + b + c;
            // hàm tính chu vi tam giác, tổng 3 số
        }
    }
}
