using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Zodiac
{
    //Class Form1 chính là class kế thừa (inherit/inheritance) cái class gốc mà
    //Windows cung cấp để render ra cửa sổ tương tác

    //Form là class Cha, Parent, class gốc có khả năng render 1 HCN ~web page
    //để cung cấp mặt sàn tương tác với user

    //Ta lập trình app GUI, app Desktop, tức là cái app chạy trên nền Desktop,
    //có icon biểu tượng trên thanh Taskbar, chính là tạo ra 1 class kế thừa class Form.

    // Con          kế thừa     Cha
    // Dog          kế thừa     Pet
    // Rectangle                Shape
    // chữ kế thừa trong Java là extends
    //                  C#  là   :


    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            //Image img = Image.FromFile("signs\\HotGirl.jpg");

            //1. Đưa ảnh vào RAM
            Image img = Image.FromFile(@"signs\HotGirl.jpg");
            //đường dẫn đến bức ảnh dùng dấu \ với Windows
            //dấu / với Linux, MacOS
            //dấu \ lại còn đóng vai trò biểu diễn kí tự đặc biệt \n: xuống hàng, \t tab
            //do đó ta phải \\ để cho Win biết rằng
            //ta đang xà \ theo style bình thường

            //2. Show ảnh <img src = "">
            picImage.Image = img;
        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);

            string zodiacEN = ZodiacCalculator.GetZodiacEnglish(month, day);

            string zodiacVN = ZodiacCalculator.GetZodiacVietnamese(zodiacEN);

            string zodiacImage = "signs\\" + zodiacEN + ".jpg";

            // load ảnh và cập nhập status - cung gì
            Image img = Image.FromFile(zodiacImage);
            picImage.Image = img;

            lblYourZodiac.Text = "Your zodiac sign is " + zodiacEN + " | " + zodiacVN;


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to exit?","Exit?",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //hàm này trả về giá trị lựa chọn của user khi user bấm nút Yes|No| Ok | Cancel...
            //=> giá trị này thuộc data type DialogResult
            //Dialog: đoạn hội thoại

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }


}
