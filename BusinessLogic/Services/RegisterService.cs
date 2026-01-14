using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOs;
using DataAccessLayer.SqlQueries;
using DataAccessLayer;
using Utilities;
using System.Configuration;
using System.Text.RegularExpressions;

namespace BusinessLogic.Services
{
    public class RegisterService
    {
        private readonly DbConnector _dbConnector;


        public RegisterService()
        {
            _dbConnector = new DbConnector();
        }

        public bool RegisterNewCustomer(RegisterDTO registerDTO)
        {
            Helper.IsNullFields(
                ("Email", registerDTO.eMail),
                ("Tên đăng nhập", registerDTO.userName),
                ("Mật khẩu", registerDTO.passWord)
            );
            if (!IsValidFullName(registerDTO.fullName))
            {
                throw new ArgumentException("Họ tên không được chứa ký tự đặc biệt hoặc số.");
            }
            if (!IsValidPhoneNumber(registerDTO.phoneNumber))
            {
                throw new ArgumentException("Số điện thoại chỉ được chứa các số từ 0-9.");
            }
            if (!IsValidEmail(registerDTO.eMail))
            {
                throw new ArgumentException("Email không được chứa ký tự đặc biệt nào ngoài '@'.");
            }
            if (!Helper.IsValidUserName(registerDTO.userName)) 
            { 
                throw new ArgumentException("Tên đăng nhập không được chứa ký tự đặc biệt và phải >= 4 ký tự.");
            }
            if (IsExistValue(registerDTO.phoneNumber, registerDTO.eMail, registerDTO.userName)) 
            {
                throw new ArgumentException("Email, số điện thoại hoặc tên đăng nhập đã tồn tại!");
            }

            // Mã hóa mật khẩu trước khi lưu
            string hashedPassword = Helper.HashPassword(registerDTO.passWord);


                var parameters = new[]
                {
                    new SqlParameter("@FullName", registerDTO.fullName),
                    new SqlParameter("@Email", registerDTO.eMail),
                    new SqlParameter("@PhoneNumber", registerDTO.phoneNumber),
                    new SqlParameter("@DateOfBirth", registerDTO.dateOfBirth),
                    new SqlParameter("@UserName", registerDTO.userName),
                    new SqlParameter("@PassWord", hashedPassword)
                };

                var rowsAffected = _dbConnector.ExecuteNonQuery(RegisterQueries.InsertNewAccount, parameters);
                return rowsAffected > 0;
        }

        //Hàm kiểm tra định dạng email
        public static bool IsValidEmail(string eMail)
        {
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-z]+$";
            return Regex.IsMatch(eMail, emailPattern);
        }

        //Hàm kiểm tra định dạng số điện thoại
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^[0-9]+$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        //Hàm kiểm tra Họ tên
        public static bool IsValidFullName(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                return false;

            string fullNamePattern = @"^[\p{L}\s]+$";
            return Regex.IsMatch(fullName, fullNamePattern);
        }

        //Hàm kiểm tra tên đăng nhập hoặc email hoặc số điện thoại đã tồn tại
        public bool IsExistValue(string phoneNumber, string eMail, string userName)
        {
            var parameters = new[]
            {
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Email", eMail),
                new SqlParameter("@UserName", userName),
            };
            int count = (int)_dbConnector.ExecuteScalar(RegisterQueries.CheckUserExist, parameters);
            return count > 0;
        }
    }
}
