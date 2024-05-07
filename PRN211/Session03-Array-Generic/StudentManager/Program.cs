using StudentManager.Entities;
//Java: import studentmanager.entities.*;
namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithValueTypeArrayV2();
            PlayWithReferenceTypeArray();
        }

        // Tôi muốn lưu trữ danh sách các SV - Mỗi SV nào đó chính là 1 Object được tạo ra từ khuôn Student!!!
        // mỗi sv chính là new Student(gọi constructor có tham số vào đây - param-constructor)
        //                  new Student() {truyền value cho các Prop Id = "HE1", Name = "An"}
        //                          object initializer
        // đừng quên mỗi SV tạo ra 1 tên gọi nhanh, gọi tắt, giống messi, r7, chipu...
        // biến objet = new ???(){};
        // muốn lưu nhiều SV, cần nhiều biến SV và nhiều new SV()

        static void PlayWithReferenceTypeArray() 
        {
            //int yob = 2003; // 1 vùng ram vì single value
            //Student s1 = new Student(); // 2 vùng ram vì value phức tạp
            //Student s2 = new Student(){...}; // object
            // tên gọi/biến và value

            //nhiều sv thì nhiều biến và nhiều new
            // chơi mảng, thì new mảng là 1 chuyện khác so với new Student()
            // new nào và new nào, tỉnh táo
            // new mảng SV hay new từng SV

            //30 biến cái đã - mảng - new [] chú ý ngoặc [] hay ()
            Student[] arr = new Student[30];
            // có biến Student kiểu s1, s2, s3, s4, ....
            // nay tương ứng arr[0], arr[1], arr[2], arr[3]
            // gán giá trị/lưu hồ sơ từng SV thì sao, thì gán =
            // arr[0] = 5;
            arr[0] = new Student(); //value phức tạp cần 2 vùng ram, nhưng vẫn ẩn biến 
            arr[1] = new Student() { Id = "SE10", Name="An", Email="an@...", Yob=2000, Gpa=10.0};
            // Student s = new Student(){Id = ...};
            arr[2] = new Student() { Id = "SE50", Name = "Dung", Email = "dung@...", Yob = 2005, Gpa = 5.0 };
            arr[3] = new Student() { Id = "SE40", Name = "Binh", Email = "binh@...", Yob = 2004, Gpa = 4.0 };
            arr[4] = new Student() { Id = "SE88", Name = "Cuong", Email = "cuong@...", Yob = 2002, Gpa = 8.0 };
            Console.WriteLine("The Student List");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]); // gọi ToString()
            }
            foreach (Student x in arr)
            {
                Console.WriteLine(x);
            }

            // for each chơi hết mảng
            // for i được quyền chơi đến chỗ mình thích
            // mảng thường for đến chỗ đang có, ko for hết trừ FI mảng FULL
            // Mảng thường ngta có biến count để biết mảng đang có bao nhiêu phần tử được gán giá trị, bao nhiêu biến đã được gán value

        }

        static void PlayWithValueTypeArrayV2()
        { // kỹ thuật khai báo mảng style thứ 2, vẫn cùng kết quả, vẫn xử lý như nhau, chỉ khác cách gán giá trị
            int[] arr = { 5, 10, 15, 20, 30, 35, 40, 45, 50 };// new ngầm số phần tử trong mảng, có biến trong mảng == số value được gán, bài này mảng [10]
            //int[] arr = { 5,      10,     15,     20,     30,     35, 40, 45, 50 };
            //          arr[0]   arr[1]   arr[2]
            // int a = 5, b = 10, c = 15 
            // gán giá trị ngay khi khai báo mảng
            // các biến lẻ trong mảng sẽ đc gán ngay value, biến-thứ-i[i] = value gì???

            // CÓ ƯU VÀ NHƯỢC CHO MỖI CÁCH KHAI BÁO!!!
            // IN MẢNG ĐI CÁI ĐÃ
            Console.WriteLine("The array is printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(@"

The array is printed by using for each");

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(@"


"); // verbatim - raw string
            foreach (int x in arr)
            {
                Console.Write("{0} ", x);
            }
        }

        //Java cung cấp 2 loại kiểu dữ liệu/ hình thái-hình dãng thể hiện dữ liệu và cách nó được lưu trên ram
        //1. PRIMITIVE DATA TYPE: Tốn 1 vùng ram
        // int, long, float, double, char, boolean

        //2. OBJECT DATA TYPE, REFERENCE DATA TYPE, "POINTER"
        //                        TỐN 2 VÙNG RAM: 1 VÙNG TÊN GỌI/ BIẾN
        //                                   VÀ 1 VÙNG NEW, VÙNG OBJECT BỰ NHIỀU RAM
        // string, String, File, Exception, Random, Math, Dog, Cat, Person, Student....

        //C# GẦN GIỐNG 100%
        //1. VALUE TYPE (tốn 1 vùng ram ~ PRIMITIVE BÊN JAVA)
        // int, long, float, double, char, bool

        //2. REFERENCE DATA TYPE, "POINTER"
        //                        TỐN 2 VÙNG RAM: 1 VÙNG TÊN GỌI/ BIẾN
        //                                   VÀ 1 VÙNG NEW, VÙNG OBJECT BỰ NHIỀU RAM
        // string, String, File, Exception, Random, Math, Dog, Cat, Person, Student

        static void PlayWithValueTypeArrayV1()
        {// Bàn về biến/value mà tốn 1 vùng ram: int, long, float...
            //hãy lưu giúp tôi 10 con số nguyên (1000cx) của trò chơi 5 10
            // sau đó tính tổng
            //ANSWER 1: DÙNG KHAI BÁO BIẾN LẺ NHƯ TRUYỀN THỐNG
            int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, b = 30, c = 35, d = 40, e = 45, f = 50;

            // tính tổng
            int sum = a1 + a2 + a3 + a4 + a5 + b + c + d + e + f;
            // Nếu nhiều số thì vỡ mặt

            //ANSWER 2: DÙNG ARRAY
            //int[] arr = new int[10];
            //MẢNG LÀ KĨ THUẬT KHAI BÁO NHIỀU BIẾN CÙNG 1 LÚC NHƯNG
            // CÁC BIẾN PHẢI CÙNG KIỂU DỮ LIỆU, CÙNG TÊN, Ở SÁT NHAU TRONG RAM, KHAI CÙNG 1 LÚC!!!

            // ĐỂ PHÂN BIỆT MỖI BIẾN TA DÙNG [INDEX SỐ THỨ TỰ CỦA MỖI BIẾN ĐẾM TỪ 0]
            int[] arr = new int[10];
            // 10 BIẾN LÀ: arr[0]   arr[1]  arr[2]  arr[3]  arr[4]  arr[5]...
            //              a1      a2      a3      a4      a5      b
            arr[0] = 5; //~ a1 = 5 ở trên khi khai báo lẻ
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20;
            arr[4] = 25;
            arr[5] = 30;
            // [6], [7], [8], [9] mình làm biếng gán
            // in ra kết quả
            Console.WriteLine("The array has vaules of");
            Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[6] + " " + arr[7]);
            // ko hiệu quả

            // XÀI FOR: Có nhiều loại for
            Console.WriteLine("The array is printed by using  traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write(arr[i] + " "); // ghép chuỗi truyền thông
                //Console.Write("{0} ", arr[i]); // place holder
                Console.Write($"{arr[i]} ");
            }

            // ANSWER 3: DÙNG COLLECTION: ARRAYLIST, LIST, MAP, SET...
        }
    }
}