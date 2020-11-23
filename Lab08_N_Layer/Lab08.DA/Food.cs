using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.DA
{
    /// <summary>
    /// Lớp ánh xạ bảng Food
    /// </summary>
    public class Food
    {
        // ID của bảng Food
        public int ID { get; set; }
        // Tên loại đồ ăn, thức uống
        public string Name { get; set; }
        // Đơn vị tính
        public string Unit { get; set; }
        //Loại thức ăn, ứng với bảng ở trên
        public int FoodCategoryID { get; set; }
        // Giá
        public int Price { get; set; }
        // Ghi chú
        public string Notes { get; set; }
    }
}
