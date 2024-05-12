namespace Students
{
    //CHALLENGE: TA CÓ DANH SÁCH SINH VIÊN...
    //List<Student> arr = new List<Student>(){new Student(){Id = "SE1", Name = "An"},
    //                                        new Student(){},
    //                                        new Student(){},
    //                                        new Student(){},
    //                                        };

    //TA IN TOÀN BỘ SV, TA IN SV Ở TỈNH NÀY, TA IN SV CÓ ĐIỂM GPA >= 8, GPA >= 8 Ở BÌNH DƯƠNG
    //ĐƯA LAMBDA VÀO ARR.WHERE( s => {s.Id s. Gpa});
    //TAO LÀ HÀM .WHERE() CỦA LIST ARR, VÀ TAO CÓ RẤT NHIỀU SV TRONG TAY
    //TAO THẢY TỪNG SV TÊN LÀ S CHO HÀM CỦA MÀY ĐƯA VÀO. MÀY MÚN LÀM GÌ VỚI S THÌ MÀY LÀM
    //2 CƠ CHỀ XỬ LÍ: TAO LIST ĐƯA TỪNG ĐỨA, TỪNG OBJECT, CON SỐ CHO HÀM NGOÀI, BÊN NGOÀI
    //                      LÀM GÌ THÌ LÀM -> ACTION<>: FOREACH...

    //                TAO LIST ĐƯA TỪNG ĐỨA CHO CHÚNG MÀY HÀM NGOÀI, HÀM NGOÀI BÁO TAO KU ĐÓ HỢP LỆ KO,
    //                      TAO LIST KIỂM SOÁT TRỞ LẠI: SUM, COUNT, WHERE...

    //LINQ: Language Integrated Query: KĨ THUẬT TRUY VẤN DATA TRONG RAM THEO 2 STYLE:
    // HÀM LAMBDA - GỐC         - METHOD SYNTAX
    // CÂU "SQL" VIẾT NGƯỢC     - QUERY SYNTAX
    // MERGE
    // . XÀI CHUỐI ... BẢN CHẤT LÀ TRẢ VỀ OBJECT CHẤM TIẾP ĐƯỢC

    // Java: Stream API, Đầu vào của hàm bao() sẽ là object xuất phát từ interface chỉ có duy nhất 1 hàm
    //          - interface chỉ cho phép có tối đa 1 hàm abstract
    //              functional interface
    // @Functional Interface
    // public interface DeathRacer
    // lambda của Java ->   C# =>
    //  LINQ ~ STREAM API (KO NHẦM LẪN VỚI I/O STREAM - TẬP TIN)

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
