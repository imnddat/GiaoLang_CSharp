using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;

        //tạm thời hok có select tất cả user như bên Category
        //CategoryRepo select hết để đổ vào combo, dropdown
        //BookRepo select hết để đổ vào grid
        //ở đây ta select đúng cái row thoả email và pass hoặc là ko thấy

        public UserAccount? GetAccount(string email, string password)
        {
            _context = new BookManagementDbContext();
            //_context.UserAccounts.  
            //  .Where(đưa vào hàm Lambda nhận vào 1 Acc trả về true/false) -> trả về 1 list user thỏa điều kiện
            //  .Select(đưa vào Lambda trả về) list Acc
            //  .FirstOrDefault(Lambda) trả về 1 dòng hoặc null ko tìm thấy theo tiêu chí Lambda

            //return _context.UserAccounts.FirstOrDefault(delegate (UserAccount x)
            //{
            //    if (x.Email == email && x.Password == password)
            //        return true;
            //    return false;
            //});

            return _context.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}
