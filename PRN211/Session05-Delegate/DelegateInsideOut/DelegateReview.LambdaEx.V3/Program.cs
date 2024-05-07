namespace DelegateReview.LambdaEx.V3
{
    internal class Program
    {
        // HÀM TÍNH DIỆN TÍCH HÌNH CHỮ NHẬT (WIDTH * LENGTH)
        // HÀM A^B, X^Y
        // HÀM PHẢI TRẢ VÊ GIÁ TRỊ, KO ĐC IN RA KQ, TRẢ VỀ ĐỀ NƠI GỌI TỰ IN
        //VOID HÀM PHẢI TỰ IN
        //STYLE HÀM: DOUBLE F(DOUBLE A, DOUBLE B)

        delegate double TwoInputsOneOutputDelegate(double a, double b);

        static void Main(string[] args)
        {
            TwoInputsOneOutputDelegate f = ComputeRectangleArea;
            double area = f(5, 10);
            Console.WriteLine("Compute area (5x10) using delegate: " + area);

            f = delegate (double width, double length)
            {
                return width * length;
            };// anonymous

            Console.WriteLine("Compute area (10x15) using anonymous: " + f(10,15));

            // lambda
            f = (double width, double length) =>
            {
                return width * length;
            };

            f = (width, length) =>
            {
                return width * length;
            };

            f = (width, length) => width * length;
            

            Console.WriteLine("Compute area (15x20) using lambda: " + f(15, 20));

            // VIẾT HÀM A^B ; 2^10 = 1024
            // Math.Pow(A, B)

            f = (a, b) => Math.Pow(a, b);

            f = (namEm, nhaPhuong) => Math.Pow(namEm, nhaPhuong);

            Console.WriteLine("2^10 = (using lambda) " + f(2, 10));

            //CÂU VIEW CHO BUỔI HOC SAU
            var fx = (int a, int b, int c) => a + b + c;
            Console.WriteLine("fx(3, 4, 5): " + fx(3, 4, 5));
        }

        static double ComputeRectangleArea(double width, double length) => width * length;


        //static double ComputeRectangleArea(double width, double length)
        //{
        //    return width * length;
        //}
    }
}
