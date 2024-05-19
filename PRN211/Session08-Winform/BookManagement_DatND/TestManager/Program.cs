using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManagementDbContext context = new BookManagementDbContext();

            List<Book> arr = context.Books.ToList(); // convert toàn bộ sách về dạng list


            // 1. in tất cả sách
            //arr.ForEach(x => Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate));

            // 2. In ra tất cả sách thuộc chủ đề 5
            arr.ForEach(x =>
            {
                if (x.BookCategoryId == 5)
                    Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate);
            });
        }
    }
}
