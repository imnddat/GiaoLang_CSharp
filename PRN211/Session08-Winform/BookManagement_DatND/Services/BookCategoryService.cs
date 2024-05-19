using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        // CUNG CẤP DATA CHO FORM, THỰC RA LÀ CUNG CẤP DATA CHO CÁI DROPDOWN, BẤM XỔ, COMBOX
        //LẼ RA PHẢI LẤY TẤT CẢ CATEGORY TỪ DB - NHƯNG TẠM THỜI HARD-CODED TRƯỚC, ĐỂ MAI TÍNH....

        private BookCategoryRepository _repo = new BookCategoryRepository();
        //new ngay đây luôn, ko sợ phần Db bị xung đột do mỗi hàm bên trong repo đã tự new cái DbContext rồi!!!
        //DbContext new 1 lần rồi CRUD dễ bị loạn ram!!!
        public List<BookCategory> GetAllCategory()
        {
            return _repo.GetBookCategories();
        }

    }
}
