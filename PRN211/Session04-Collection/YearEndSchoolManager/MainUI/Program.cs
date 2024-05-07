using Repositories.Entities;
using Services;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LƯU TRỮ DANH SÁCH SV NGÀNH SE, NGÀNH BIZ RIÊNG BIỆT
            // LƯU TRỮ DANH SÁCH GV
            // TẤT CẢ CHỈ XÀI CABINET<???SV, GV, PHONE, CAT>

            Cabinet<Student> seList = new Cabinet<Student>();
            // Java: ArrayList<Student> seList = new ArrayList<Student>();

            Cabinet<Student> bizList = new Cabinet<Student>();

            Cabinet<Lecturer> seLecList = new Cabinet<Lecturer>();

            seList.AddItem(new Student() { Id = "SE1", Name = "An", Gpa = 8.6 });
            //                              object initialization
            seList.AddItem(new Student() { Id = "SE2", Name = "Binh", Gpa = 8.5 });

            bizList.AddItem(new Student() { Id = "SS3", Name = "Cuong", Gpa = 8.7 });

            seLecList.AddItem(new Lecturer() { Id = "00000001", Name = "Dung"});
            seLecList.AddItem(new Lecturer() { Id = "00000002", Name = "Em"});

            // in all info
            Console.WriteLine("The SE student list");
            seList.PrintedAll();

            Console.WriteLine("The BIZ student list");
            bizList.PrintedAll();

            Console.WriteLine("The SE Lecturer list");
            seLecList.PrintedAll();

        }
    }
}