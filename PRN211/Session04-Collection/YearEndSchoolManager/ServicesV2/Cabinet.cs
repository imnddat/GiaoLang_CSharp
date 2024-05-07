namespace ServicesV2
{
    public class Cabinet<T>
    {
        // danh sách các biến/object cần add vô từ từ
        // dùng mảng hoặc nhiều biến lẻ hoặc COLLECTIONS, TÚI CAO CẤP THAY CHO ARRAY

        private List<T> _list = new List<T>();

        // CRUD QUEN THUỘC
        public void AddItem(T item)
        {
            _list.Add(item);
        }

        public void PrintedAll()
        {
            Console.WriteLine("There is/are...");
            foreach (T x in _list)
            {
                Console.WriteLine(x);
            }
        }
    }
}