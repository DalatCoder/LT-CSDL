using Lab08.BUS;
using Lab08.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_N_Layer
{
    public partial class frmFood : Form
    {
        // Danh sách toàn cục bảng Category
        List<Category> listCategory = new List<Category>();
        // Danh sách toàn cục bảng Food
        List<Food> listFood = new List<Food>();
        // Đối tượng Food đang chọn hiện hành
        Food foodCurrent = new Food();

        public frmFood()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            //Gán các ô bằng giá trị mặc định
            txtName.Text = "";
            txtPrice.Text = "0";
            txtUnit.Text = "";
            txtNotes.Text = "";

            // Thiết lập index = 0 cho ComboBox
            if (cbbCategory.Items.Count > 0)
                cbbCategory.SelectedIndex = 0;
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu vào ComboBox
            LoadCategory();
            // Đổ dữ liệu vào ListView
            LoadFoodDataToListView();
        }

        private void LoadCategory()
        {
            //Gọi đối tượng CategoryBL từ tầng BusinessLogic
            CategoryBL categoryBL = new CategoryBL();
            // Lấy dữ liệu gán cho biến toàn cục listCategory
            listCategory = categoryBL.GetAll();
            // Chuyển vào Combobox với dữ liệu là ID, hiển thị là Name
            cbbCategory.DataSource = listCategory;
            cbbCategory.ValueMember = "ID";
            cbbCategory.DisplayMember = "Name";
        }
        public void LoadFoodDataToListView()
        {
            //Gọi đối tượng FoodBL từ tầng BusinessLogic
            FoodBL foodBL = new FoodBL();
            // Lấy dữ liệu
            listFood = foodBL.GetAll();
            int count = 1; // Biến số thứ tự
            // Xoá dữ liệu trong ListView
            lsvFood.Items.Clear();
            // Duyệt mảng dữ liệu để đưa vào ListView
            foreach (var food in listFood)
            {
                // Số thứ tự
                ListViewItem item = lsvFood.Items.Add(count.ToString());
                // Đưa dữ liệu Name, Unit, price vào cột tiếp theo
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                // Theo dữ liệu của bảng Category ID, lấy Name để hiển thị
                string foodName = listCategory
                .Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);
                // Đưa dữ liệu Notes vào cột cuối
                item.SubItems.Add(food.Notes);
                count++;
            }
        }

        private void lsvFood_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvFood.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvFood.Items[i].Selected)
                {// Lấy các tham số và gán dữ liệu vào các ô
                    foodCurrent = listFood[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;
                    // Lấy index của Combobox theo FoodCategoryID
                    cbbCategory.SelectedIndex = listCategory
                    .FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }
    }
}
