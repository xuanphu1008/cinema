using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Helper
    {
        //Hàm mã hóa băm mật khẩu
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //Hàm kiểm tra tên đăng nhập
        public static bool IsValidUserName(string userName)
        {
            string userNamePattern = @"^[a-zA-Z0-9]+$";
            return userName.Length >= 4
                && Regex.IsMatch(userName, userNamePattern);
        }

        //Hàm kiểm tra mật khẩu
        public static bool IsPasswordValid(string passWord) 
        {
            string passwordPattern = @"^[a-zA-z0-9]+$";
            return Regex.IsMatch(passWord, passwordPattern);
        }

        //Hàm kiểm tra xem có trường dữ liệu nào bị trống không
        public static void IsNullFields(params (string fieldName, string fieldValue)[] inputs)
        {
            foreach (var (fieldName, fieldValue) in inputs)
            {
                if (string.IsNullOrWhiteSpace(fieldValue))
                {
                    throw new ArgumentException($"Trường '{fieldName}' không được để trống.");
                }
            }
        }
    }
}
