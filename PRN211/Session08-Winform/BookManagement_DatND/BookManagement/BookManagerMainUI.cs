using Repositories.Entities;
using Services;

namespace BookManagement
{
    public partial class BookManagerMainUI : Form
    {
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        public void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            BookService service = new BookService();
            dgvBookList.DataSource = null; // xóa trắng grid
            dgvBookList.DataSource = service.GetAllBooks();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là
            //class BookDetailFrom, khác truyền thống là nó có
            //phần render bề mặt!!!
            //Nó 1 class nên nó sẽ có _field, prop, methods như bt
            //khai báo biến, new như bt
            //thêm phần render
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); // render
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            // người ùng có thể chọn 1 dòng hay nhiều dòng cho nên ta sẽ lấy dòng đầu tiên được chọn nếu người ta chọn nhiều dòng

            if(dgvBookList.SelectedRows.Count > 0)
            {
                // nếu chọn ít nhất 1 dòng, thì cứ lấy dòng đầu tiên, đẩy sang BookDetailForm
                Book selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem; // lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .Datasource = List<Book>

                //đẩy sang DetailForm
                //khai biến, new, gán prop, show dialog
                //thằng form detail: mở lên, check selected khác
                //null hem? khác null mode EDIT, SHOW DATA ĐC GỬI SANG
                BookDetailForm f = new BookDetailForm();
                // đưa sách sang
                f.SelectedBook = selected;
                f.ShowDialog();
            }
        }
    }
}
