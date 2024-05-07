using Repositories.Entities;

namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> seList = new List<Student>();

            List<Student> bizList = new List<Student>();

            List<Lecturer> seLecList = new List<Lecturer>();

            seList.Add(new Student() { Id = "SE1", Name = "An", Gpa = 8.6 });
            //                              object initialization
            seList.Add(new Student() { Id = "SE2", Name = "Binh", Gpa = 8.5 });

            bizList.Add(new Student() { Id = "SS3", Name = "Cuong", Gpa = 8.7 });

            seLecList.Add(new Lecturer() { Id = "00000001", Name = "Dung" });
            seLecList.Add(new Lecturer() { Id = "00000002", Name = "Em" });

            Console.WriteLine("The SE student list");
            //seList.PrintedAll();

            Console.WriteLine("The BIZ student list");
            //bizList.PrintedAll();

            Console.WriteLine("The SE Lecturer list");
            //seLecList.PrintedAll();

        }

        static void PlayWithIntegerList()
        {
            //lưu trữ và in ra 10 số nguyên từ 1..10
            //int[] arr = new int[10];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr là biến con trỏ, là biến tham chiếu, là biến trỏ vùng nhớ bự new int[10]
            //vùng nhớ bự này như cái túi chứa bên trong 10 biến int khác arr[0] arr[1] ...
            //ta nhẩn nha gán từng value cho từng biến int - mảng đã học rồi
            //arr là biến con trỏ, trỏ cái túi bự chứa nhiều biến khác bên trong là data ta
            //sẽ lưu trữ

            //Java: List<Integer> arr = new ArrayList<Integer>();
            //Java: ArrayList<Integer> arr = new ArrayList<Integer>();
            // Java: Cấm ko được new List, LIST là abstract, interface, chỉ được new ARRAYLIST

            // arr là biến con trỏ, trỏ vùng new bự, chứa bên vùng new bự là các biến int
            //nhưng sẽ được add vào từ từ, nở từ từ các biến int được nhét vào - giống cái túi co giãn

            // arr.Add(value int nào đó)
            // arr[i] = value int nào đó nếu chơi mảng

            // lấy ra biến int nào đó arr.Get(position)

            //C#: LIST VÀ ARRAYLIST ĐỀU NEW ĐƯỢC
            // KHUYÊN DÙNG LIST, KO NÊN DÙNG ARRAYLIST VÌ KO AN TOÀN NẾU KO HIỂU RÕ VỀ NÓ

            // C#: List<Student>   List<int>
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            // list ~~ arr bên mảng ~ Java là con trỏ, biến trỏ tới vùng new bự ...

            Console.WriteLine($"There is/are {list.Count} item(s) in list/bag");
            //Console.WriteLine("The integer list printed by using for i");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    //Console.WriteLine(list.get(i)); // Java
            //    Console.WriteLine(list[i]); // xài như mảng[position] kỹ thuật này gọi là Index
            //                                    // XÀI DANH SÁCH NÀO ĐÓ THEO STYLE MẢNG
            //}

            Console.WriteLine("The integer list printed by using for each");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}