using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessLogic.DTOs;
using DataAccessLayer.SqlQueries;
using DataAccessLayer;
using Utilities;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Data;

namespace BusinessLogic.Services
{
    public class LoginService
    {
        private readonly DbConnector _dbConnector;

        public LoginService()
        {
            _dbConnector = new DbConnector();
        }

        public string LoginAccount(LoginDTO loginDTO)
        {
            // Kiểm tra các trường không được null hoặc rỗng
            Helper.IsNullFields(
                ("Tên đăng nhập", loginDTO.userName),
                ("Mật khẩu", loginDTO.passWord)
            );

            // Kiểm tra tính hợp lệ của tên đăng nhập
            if (!Helper.IsValidUserName(loginDTO.userName))
            {
                throw new ArgumentException("Tên đăng nhập không được chứa ký tự đặc biệt và phải >= 4 ký tự.");
            }

            // Băm mật khẩu
            string hashedPassword = Helper.HashPassword(loginDTO.passWord);

            // Các tham số truyền vào truy vấn SQL
            var parameters = new[]
            {
                new SqlParameter("@UserName", loginDTO.userName),
                new SqlParameter("@PassWord", hashedPassword)
            };

            // Sửa truy vấn trong LoginQueries để trả về vai trò của người dùng
            string query = LoginQueries.GetUserRole; // Cần định nghĩa truy vấn mới để lấy vai trò

            // Thực hiện truy vấn và lấy vai trò
            var result = _dbConnector.ExecuteScalar(query, parameters);

            // Nếu kết quả null hoặc không có dữ liệu, trả về null (đăng nhập thất bại)
            if (result == null || result == DBNull.Value)
            {
                return null;
            }

            // Trả về vai trò của người dùng (chuỗi như "Admin" hoặc "Staff")
            return result.ToString();
        }

        public List<string> GetUsersWithoutRole()
        {
            var users = new List<string>();
            var result = _dbConnector.ExecuteQuery(LoginQueries.GetUsersWithoutRole);

            foreach (DataRow row in result.Rows) // Duyệt qua các hàng trong DataTable
            {
                users.Add(row["userName"].ToString());
            }

            return users;
        }


        public void AssignRole(string userName, string role)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Role", role)
            };

            _dbConnector.ExecuteNonQuery(LoginQueries.UpdateUserRole, parameters);
        }


    }
}
