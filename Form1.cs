using System.Data;

namespace LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private bool initialLoad = true;
        private Dictionary<int, bool> confirmedRows = new Dictionary<int, bool>();
        private DataTable tbOrder = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOrder.Columns.Add("Food");
            tbOrder.Columns.Add("Amount", typeof(int));
            tbOrder.Columns.Add("Table");
            tbOrder.PrimaryKey = new DataColumn[] { tbOrder.Columns["Food"] };


            ChoseTablecomboBox1.Items.Add("Table 1");
            ChoseTablecomboBox1.Items.Add("Table 2");
            ChoseTablecomboBox1.Items.Add("Table 3");
            ChoseTablecomboBox1.Items.Add("Table 4");
            ChoseTablecomboBox1.Items.Add("Table 5");

            // Đặt giá trị mặc định cho ComboBox

            if (initialLoad)
            {
                ChoseTablecomboBox1.SelectedIndex = -1;
            }


            ShowOrderdataGridView1.DataSource = tbOrder;
            initialLoad = false; // Đặt biến initialLoad thành false sau khi đã khởi tạo lần đầu

        }

        private void AddFoodToOrder(string foodName)
        {
            string selectedTable = ChoseTablecomboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Please choose Table before choosing food.");
                return;
            }

            if (!string.IsNullOrEmpty(selectedTable))
            {
                DataRow[] rows = tbOrder.Select($"Food = '{foodName}' AND [Table] = '{selectedTable}'");

                if (rows.Length > 0)
                {
                    // Tăng số lượng
                    rows[0]["Amount"] = Convert.ToInt32(rows[0]["Amount"]) + 1;
                }
                else
                {
                    // Thêm một dòng mới
                    DataRow r = tbOrder.NewRow();
                    r["Food"] = foodName;
                    r["Amount"] = 1;
                    r["Table"] = selectedTable;
                    tbOrder.Rows.Add(r);
                }

                // Kiểm tra xem có hàng nào trong DataGridView
                if (ShowOrderdataGridView1.Rows.Count > 0)
                {
                    // Nếu có, hiển thị TextBox
                    foodNameTextBox.Visible = true;
                }
               

            }

        }

        private void Breadbutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Bread");
        }

        private void Cerealbutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Cereal");
        }

        private void Bunbutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Bun");
        }

        private void Phobutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Pho");
        }

        private void ComTambutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Com Tam");
        }

        private void BanhCanhbutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Banh Canh");
        }

        private void ComSuonbutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Com Suon");
        }

        private void Nuibutton_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Nui");
        }

        private void ChoseTablecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gắn kết dữ liệu với bàn được chọn
            string selectedTable = ChoseTablecomboBox1.SelectedItem?.ToString();


        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            // Đặt giá trị của ComboBox thành rỗng
            ChoseTablecomboBox1.SelectedIndex = -1;
            foodNameTextBox.Visible = false;

            tbOrder.Clear(); // Xóa dữ liệu từ DataGridView
        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {

        }

        private void ChosecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ChoseTablecomboBox1.SelectedItem?.ToString();

        }

        private DataRow FindFoodInOrder(string foodName)
        {
            DataRow foundRow = tbOrder.Rows.Find(foodName);
            return foundRow;
        }

        // Hàm để xóa một món ăn từ đơn hàng
        

        private void RemoveSelectedFoodButton_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có bất kỳ hàng nào trong DataGridView hay không
            if (ShowOrderdataGridView1.Rows.Count > 0)
            {
                // Lấy tên món ăn từ TextBox
                string foodToRemove = foodNameTextBox.Text;
                

                // Kiểm tra xem tên món ăn có được nhập không
                if (string.IsNullOrEmpty(foodToRemove))
                {
                    MessageBox.Show("Please enter the name of the food you want to remove.");
                    return;
                }

                // Lặp qua tất cả các dòng trong DataTable
                foreach (DataRow row in tbOrder.Rows)
                {
                    if (row["Food"].ToString() == foodToRemove)
                    {
                        // Xóa dòng khỏi DataTable
                        tbOrder.Rows.Remove(row);
                        break; // Nếu bạn muốn dừng sau khi xóa dòng đầu tiên tìm thấy
                    }
                }
            }
            if (ShowOrderdataGridView1.Rows.Count == 0)
            {
                // Nếu không có hàng nào trong DataGridView, ẩn TextBox
                foodNameTextBox.Visible = false;
            }
        }

        private void foodNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}