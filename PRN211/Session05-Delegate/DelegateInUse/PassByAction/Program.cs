namespace PassByAction
{
    //CHALLENGE: VIẾT HÀM THẦY CÁC HÀNH ĐỘNG NÀO ĐÓ BÊN NGOÀI ĐƯA VÀO
    //          HÀM THẦU CÁC DỊCH VỤ IN ẤN NÀO ĐÓ: IN BÀI HÁT, IN SỐ, IN DÃY SỐ...
    internal class Program
    {
        static void Main(string[] args)
        {
            DoOnDemand(delegate () { Console.WriteLine("Noi nay co anh"); Console.WriteLine("Hello elm"); });

            DoOnDemand(() => { Console.WriteLine("Chúng ta ko thuộc về nhau"); Console.WriteLine("C# chắc có là của nhau"); });
        }

        static void DoOnDemand(Action f) // = hàm nào đó có style void F()
                                         // = hàm ẩn danh hay Lambda
        {
            Console.WriteLine("Do - While - for - code as normal");

            f();
        }
    }
}
