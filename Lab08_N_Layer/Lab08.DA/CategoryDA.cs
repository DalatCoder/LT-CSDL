using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.DA
{
    /// <summary>
    /// Lớp quản lý Category: DA = DataAccess
    /// </summary>
    public class CategoryDA
    {
        //Phương thức lấy hết dữ liệu theo thủ tục Food_GetAll
        public List<Category> GetAll()
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_GetAll;
            // Đọc dữ liệu, trả về danh sách các đối tượng Category
            SqlDataReader reader = command.ExecuteReader();
            List<Category> list = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                category.Type = Convert.ToInt32(reader["Type"]);
                list.Add(category);
            }
            // Đóng kết nối và trả về danh sách
            sqlConn.Close();
            return list;
        }
        //Phương thức thêm, xoá, sửa theo thủ tục Category_InsertUpdateDelete
        public int Insert_Update_Delete(Category category, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_InsertUpdateDelete;
            // Thêm các tham số cho thủ tục; Các tham số này chính là các tham số trong thủ tục;
            //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xoá, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput; // Vừa vào vừa ra
            command.Parameters.Add(IDPara).Value = category.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 200)
            .Value = category.Name;
            command.Parameters.Add("@Type", SqlDbType.Int)
            .Value = category.Type;
            command.Parameters.Add("@Action", SqlDbType.Int)
            .Value = action;
            // Thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
    }
}
