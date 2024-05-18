using Microsoft.EntityFrameworkCore;
using Repositories;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManagementDbContext context = new BookManagementDbContext();
            context.Books.ForEachAsync(x => Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate));
        }
    }
}
