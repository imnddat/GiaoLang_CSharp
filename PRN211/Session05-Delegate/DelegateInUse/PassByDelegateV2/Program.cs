namespace PassByDelegateV2
{
    // ngang cơ nhau: delegate, class, interface, struct
    internal class ShowBiz
    {
        //_fields, properties {get; set; }, methods: constructor, ToString()...
        //một constructor default nếu Class/khuôn ko có phễu được tạo sẵn
        //_fields, properties, methods: PUBLIC, PRIVATE, PROTECTED,
        //STATIC (THUỘC VỀ CỘNG ĐỒNG), NON-STATIC (THUỘC VỀ OBJECT)
        //  . TRỰC TIẾP                   . QUA NEW OBJECT

        public static void PrintSongLyricThe1()
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

        public void PrintSongLyricLover()
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
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#4: IN RA LỜI CÁC BÀI HÁT, GỌI HÀM NẰM Ở CLASS KHÁC PHẢI DÙNG QUA DELEGATE

            Console.WriteLine("C#4: CALL THE METHODS OUTSIDE - IN ANOTHER CLASS");
            Action f1 = ShowBiz.PrintSongLyricThe1;

            ShowBiz song = new ShowBiz(); // default construtor
            Action f2 = song.PrintSongLyricLover;

            f1.Invoke();
            f2();

            Action f3 = new ShowBiz().PrintSongLyricLover;
            //NGUYÊN LÝ DẤU =, A = B
            // Ở ĐÂU XÀI A ĐƯỢC THÌ Ở ĐÓ XÀI B 
            f3();
        }
    }
}
