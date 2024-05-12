namespace Numerology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. IN HẾT DÃY SỐ CÓ TRONG NUMBERSERVICE
            NumberService.PrintNumbers(x => Console.Write(x + " "));

            //2. IN CÁC SỐ ÂM 
            Console.WriteLine("\n--------------------------");
            Console.WriteLine(" < 0 ");
            NumberService.PrintNumbers(xx =>
            {
                if (xx < 0)
                    Console.WriteLine(xx);
            });
            NumberService.Count1(n => n < 0);

            //3. ĐẾM SỐ DƯƠNG
            Console.WriteLine("----------------------------");
            Console.WriteLine(" > 0 ");
            NumberService.Count2(n => n > 0);
        }
    }
}
