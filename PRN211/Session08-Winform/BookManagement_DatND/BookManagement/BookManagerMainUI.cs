using Repositories.Entities;
using Services;

namespace BookManagement
{
    public partial class BookManagerMainUI : Form
    {
        //backing filed _
        private Book _selected = null; // chờ ai đó nhấn 1 dòng trong grid/table thì nó được gán = cuốn sách đang chọn
                                       // đẩy cuốn sách đc chọn sang màn hình update

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

            if (dgvBookList.SelectedRows.Count > 0)
            {
                // nếu chọn ít nhất 1 dòng, thì cứ lấy dòng đầu tiên, đẩy sang BookDetailForm
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem; // lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .Datasource = List<Book>
            }

            //nếu user chọn Cell thay vì chọn nguyên dòng, reset biến _selected về null

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //đẩy sang DetailForm
            //khai biến, new, gán prop, show dialog
            //thằng form detail: mở lên, check selected khác
            //null hem? khác null mode EDIT, SHOW DATA ĐC GỬI SANG
            if (_selected != null) // người dùng phải chọn 1 dòng trong grid
            {
                BookDetailForm f = new BookDetailForm();
                // đưa sách sang
                f.SelectedBook = _selected;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a certain book to edit", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // ta lấy ra 2 chuỗi đang nằm trong textBookNamr và txtDescription
            // và t where trên danh sách book đang có

            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;

            //dgvBookList.DataSource = books.Where(
            //    delegate (Book x)
            //    {
            //        return x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower());
            //    }
            //    ).ToList();


            dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower())
                || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
