namespace PassByDelegateV1
{
    //CHALLENGE #1: IN RA 2 LỜI BÀI HÁT NÀO ĐÓ CỦA TAYLOR SWIFT: THE 1, LOVER
    //          LÀM THEO STYLE TRUYỀN THỐNG

    //CHALLENGE #2: DÙNG DELEGATE ĐỂ IN BÀI HÁT

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#1: Call explicit method directly as normal - Call hàm có sẵn");
            PrintSongLyricsThe1();
            PrintSongLyricsLover();

            Console.WriteLine("C#2: Call explicit methods using delegate"); 
            Action f = PrintSongLyricsThe1; // luật sư = thân chủ; Hợp đồng ủy quyền
            f += PrintSongLyricsLover;
            // += nối thêm bài vào, trỏ 2 hàm
            // 1 luật sư = 2 hay nhiều thân chủ
            // Multicast delegates

            // = như gán biến xưa nay, chỉ trỏ 1 hàm
            // 1 luật sư = 1 thân chủ
            f();

            // CHALLENGE #3: IN RA THÊM 2 BÀI HÁT NỮA, KO ĐƯỢC TẠO HÀM LẺ CÓ SẴN RỒI GÁN
            //                  MÀ DÙNG HÀM ẨN DANH VÀ BIỂU THỨC LAMBDA

            Action f2 = delegate () 
            {
                Console.WriteLine("The song lyric August - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"[Verse 1]
salt air, and the rust on your door
...
");
            };
            Action f3 = () => 
            {
                Console.WriteLine("The song lyric Is it over now? - TaylorSwift");
                Console.WriteLine();
                Console.WriteLine(@"[Intro]
(Is it? Is it? Is it? Is it? Is it?)
...
");
            };
            Console.WriteLine("C#3: Call Anonymous/Lambda Expression methods");
            f2();
            f3();
            
        }

        static void PrintSongLyricsThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...
");//verbatim
        }


        static void PrintSongLyricsLover()
        {
            Console.WriteLine("The song Lover - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"We could leave the Christmas lights up 'til January
And this is our place, we make the rules
And there's a dazzling haze, a mysterious way about you, dear
Have I known you twenty seconds or twenty years?

[Chorus]
Can I go where you go?
Can we always be this close?
Forever and ever, ah
Take me out and take me home
You're my, my, my, my lover
...
");
        }
    }
}
