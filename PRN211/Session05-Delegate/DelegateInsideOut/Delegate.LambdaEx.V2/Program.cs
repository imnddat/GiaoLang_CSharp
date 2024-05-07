namespace Delegate.LambdaEx.V2
{
    //TA CHƠI HÀM CÓ 1 ĐẦU VÀO, KO TRẢ VỀ GÌ CẢ, STYLE VOID F(INT).
    //CHALLENGE: IN CÁC SỐ TỪ 1. ..N
    //CHƠI ANONYMOUS, CHƠI LAMDA
    delegate void OneInputNoOutputDelegate(int n);
    internal class Program
    {
        static void Main(string[] args)
        {
            OneInputNoOutputDelegate f = delegate (int n)
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be greater than 0!!!");
                    return;
                }
                Console.WriteLine("The list of numbers from 1 to " + n);
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            f(100);

            Console.WriteLine("Lambda version 1");
            OneInputNoOutputDelegate f1 = (int n) => // bỏ tên hàm
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be greater than 0!!!");
                    return;
                }
                Console.WriteLine("The list of numbers from 1 to " + n);
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            f1(100);

            Console.WriteLine("Lambda version 2");
            OneInputNoOutputDelegate fn = (n) => // bỏ kiểu dữ liệu
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be greater than 0!!!");
                    return;
                }
                Console.WriteLine("The list of numbers from 1 to " + n);
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            fn(100);

            Console.WriteLine("Lambda version 3");
            fn = n => // bỏ dấu ()
            {
                if (n < 1)
                {
                    Console.WriteLine("n must be greater than 0!!!");
                    return;
                }
                Console.WriteLine("The list of numbers from 1 to " + n);
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            fn(100);

            Console.WriteLine("Lambda version 4");
            fn = ngocTring => // đặt tên biến bất kỳ
            {
                if (ngocTring < 1)
                {
                    Console.WriteLine("n must be greater than 0!!!");
                    return;
                }
                Console.WriteLine("The list of numbers from 1 to " + ngocTring);
                for (int i = 0; i <= ngocTring; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            fn(56);

        }

        static void PrintIntegerList(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("n must be greater than 0!!!");
                return;
            }
            Console.WriteLine("The list of numbers from 1 to "+ n);
            for (int i = 0; i <=n ; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
