using Lab08.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.BUS
{
    /// <summary>
    /// Lớp CategoryBL có các phương thức xử lý bảng Category
    /// </summary>
    public class CategoryBL
    {
        //Đối tượng CategoryDA từ DataAccess
        CategoryDA categoryDA = new CategoryDA();
        //Phương thức lấy hết dữ liệu
        public List<Category> GetAll()
        {
            return categoryDA.GetAll();
        }
        //Phương thức thêm dữ liệu
        public int Insert(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 0);
        }
        //Phương thức cập nhật dữ liệu
        public int Update(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 1);
        }
        //Phương thức xoá dữ liệu truyền vào ID
        public int Delete(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 2);
        }
    }
}
