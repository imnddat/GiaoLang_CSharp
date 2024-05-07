using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveStory
{
    // 3 THĂNG NGANG CƠ NHAU, ĐỨNG NGANG HÀNG NHAU:
    // * INTERFACE
    // * CLASS (TAO CHỨA INFO CỦA OBJECT NGOÀI ĐỜI, HÀNH ĐỘNG)
    // * DELEGATE (CLASS ĐẶC BIỆT - TAO CHỈ CHỨA TÊN HÀM NGOÀI KIA)

    //public class X[void X()] delegate
    //{
    //    _nickHamNaoDo = ????
    //}

    public delegate void SendLoveMessageDelegate();

    internal class KuKia
    {
        public static void MeetSweetHeart()
        {
            Console.WriteLine("Hey Baby, oh my sweet heart");
            // KuKia phải nhận lời gửi gắm của Tui và Bạn -> chính là trỏ đến hàm nhắn tin
            // mà lẽ ra Tui Bạn phải trực tiếp run, trực tiếp nói, nay Kukia
            // SẼ RUN GIÙM DELEGATE CHO KUKIA, CHO NICK NAME, TAO CHUYỂN LỜI CỦA TAO CHO MÀY RUN

            //SendLoveMessageDelegate message = new SendLoveMessageDelegate(Tui.TellHer);
            SendLoveMessageDelegate message = Tui.TellHer;
            message += Ban.NhanEm;

            Console.WriteLine("By the way, you hace messages from ...");
            // gọi hàm nhắn tin, nhưng ko gọi truwch tiếp mà gọi qua delegate
            // do 2 tin này được capture dưới dạng biến delegate, bỏ vào vùng new Delegate

            // gọi gián tiếp, ủy quyền
            message();

            // gọi trực tiếp: Tui.TellHer()  Ban.NhanEm()

        }
    }
}
