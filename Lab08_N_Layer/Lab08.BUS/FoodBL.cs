using Lab08.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.BUS
{
    /// <summary>
    /// Lớp FoodBL có các phương thức xử lý bảng Food
    /// </summary>
    public class FoodBL
    {
        //Đối tượng CategoryDA từ DataAccess
        FoodDA foodDA = new FoodDA();
        //Phương thức lấy hết dữ liệu
        public List<Food> GetAll()
        {
            return foodDA.GetAll();
        }
        // Phương thức lấy về đối tượng Food theo khoá chính
        public Food GetByID(int ID)
        {
            // Lấy hết
            List<Food> list = GetAll();
            // Duyệt để tìm kiếm
            foreach (var item in list)
            {
                if (item.ID == ID) // Nếu gặp khoá chính
                    return item; // thì trả về kết quả
            }
            return null;
        }
        //Phương thức tìm kiếm theo khoá
        public List<Food> Find(string key)
        {
            List<Food> list = GetAll(); // Lấy hết
            List<Food> result = new List<Food>();
            // Duyệt theo danh sách
            foreach (var item in list)
            {
                // Nếu từng trường chứa từ khoá
                if (item.ID.ToString().Contains(key)
                || item.Name.Contains(key)
                || item.Unit.Contains(key)
                || item.Price.ToString().Contains(key)
                || item.Notes.Contains(key))
                    result.Add(item); // Thì thêm vào danh sách kết quả
            }
            return result;
        }
        //Phương thức thêm dữ liệu
        public int Insert(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 1);
        }
        //Phương thức xoá dữ liệu với ID cho trước
        public int Delete(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 2);
        }
    }
}
