using StudentManagerV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    internal class Cabinet
    {// tương tự Cái Tủ đựng hồ sơ ngoài đơi
        // nó có đặc trưng, thông tin là: 1 mảng, 1 ko gian rộng rãi để cất trữ đồ gì đó
        // nó sẽ có các hành động: CRUD CREATE, RETRIEVE            (READ), UPDATE, DELETE
        //                                      select sum()        select *
        //                                      select join left, right
        // mở ngăn tủ, nhét 1 bộ hồ sơ vào: ADD/CREATE
        // mở ngăn tủ, tìm lấy 1 bộ, chỉnh sửa thêm ảnh, giấy A4 ghi chú, cất trở lại: UPDATE
        // mở ngăn tủ, "chôm" làm biến mất 1 bộ hồ sơ đang có: DELETE/REMOVE
        // mở ngăn tủ, tìm 1 bộ hồ sơ, thấy rồi, sao chụp lại, rồi cất vào chỗ cũ: SEARCH, READ/RETRIEVE ONE
        // mở ngăn tủ, sắp xếp cho gọn gàng theo tiêu chí: ngày tháng năm, tên (nghi phạm): SORT/RETRIEVE

        // TỦ CẦN CHỖ CHỮA ĐỒ
        private Student[] _list = new Student[300];
        private int _count = 0; //mặc định mảng chưa có phần tử nào, Tủ đang có 0 hồ sơ
                                //và từ từ bổ sung dần và hồ sơ vào vị trí thứ count tăng dần dần từ 0

        // tại sao _list nghĩa là backin filed mà ko chơi property/ ẩn backing chỉ Get() Set()
        //public Student[] Students { get; set; }
        //.Students = ?? 300 bộ hồ sơ, ko hợp lý nếu bị phải làm: nhét 1 lúc 300 bộ hồ sơ, vài trăm hồ sơ,
        //do prop của Tủ là mảng hồ sơ, khi Set() phải là Set() mảng
        // int Yob của SV là Set() lẻ 1 giá trị
        // prop mảng thì Set() mảng, prop lẻ thì Set() lẻ
        // QUAY VỀ TRUYỀN THỐNG, CLASS CÓ 1 MẢNG, TỦ CÓ 1 KHÔNG GIAN RỖNG, VÀ TỪ TỪ NHÉT VÔ

        // NHÉT TỪ TỪ HỒ SƠ, ADD() TỪ TỪ SẼ HỢP LÝ HƠN -> HÀM ADD() 1 HỒ SƠ RA ĐỜI!!!

        // TƯ DUY THIẾT KẾ KIỂU SOLID (OOP: 4 + 5)
        // S: SINGLE RESPONSIBILITY - THIẾT KẾ 1 CLASS ĐỪNG LÀM NHIỀU VIỆC QUÁ KHÁC BIỆT /KLQ
        // HÀM NÀY CẤT HỒ SƠ VÀO ĐÚNG VỊ TRÍ, VIỆC ĐÓ ỔN, VÌ ĐÓ LÀ VIỆC CỦA CÁI TỦ

        // CÒN VIỆC NHẬP THÔNG TIN HỒ SƠ TRƯỚC KHI CẤT VÀO TỦ, ĐÓ LÀ VIỆC CỦA CHỖ KHÁC, CLASS KHÁC
        // GIẢ SỬ APP CẦN NHẬP INFO TỪ WEB, CONSOLE, MOBILE, TOUCH, DESKTOP APP
        // RÕ RÀNG NHẬP ĐÂU KO CẦN BIẾT, ĐƯA CHO TUI INFO TUI CẤT GIỮ
        // TƯ DUY NÀY GIÚP APP TA CHƠI VỚI NHIỀU LOẠI UI
        //GẮN NHẬP VÀO HÀM NÀY KO OK, KO GIÚP APP TRỞ NÊN DỄ BẢO TRÌ, NÂNG CẤP, FLEXIBLE
        // LÀM RIÊNG XỬ LÝ Ở ĐÂY, NHẬP CHỖ KHÁC LÀ VẬY -> NGUYÊN LÝ S
        public void AddNewStudent(string id, string name, string email, int yob, double gpa)
        {
            // add vào vị trí nào trong Tủ, trong mảng??
            _list[_count] = new Student() {Id=id, Name=name, Email=email, Yob=yob, Gpa=gpa };
            _count++;
            // kiểm tra tràn Tủ if
        }

        // kiểm tra tủ, in danh sách sinh viên
        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the cabinet");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]); // gọi ToString
            }
        }


    }
}
