using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOs;
using DataAccessLayer;
using DataAccessLayer.SqlQueries;
using Utilities;

namespace BusinessLogic.Services
{
    public class EmployeeService
    {
        private readonly DbConnector _dbConnector;
        public EmployeeService()
        {
            _dbConnector = new DbConnector();
        }

        public bool AddEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                string hashedPassword = Helper.HashPassword(employeeDTO.Password);
                var parameters = new[]
                {
                    new SqlParameter("@EmployeeName", employeeDTO.EmployeeName),
                    new SqlParameter("@Gender", employeeDTO.Gender),
                    new SqlParameter("@DateOfBirth", employeeDTO.DateOfBirth),
                    new SqlParameter("@Shift", employeeDTO.Shift ?? (object)DBNull.Value),
                    new SqlParameter("@PhoneNumber", employeeDTO.PhoneNumber ?? (object)DBNull.Value),
                    new SqlParameter("@Salary", employeeDTO.Salary),
                    new SqlParameter("@Role", employeeDTO.Role),
                    new SqlParameter("@UserName", employeeDTO.UserName),
                    new SqlParameter("@Password", hashedPassword),
                    
                };

                int affectedRows = _dbConnector.ExecuteNonQuery(EmployeeQueries.AddEmployee, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        public DataTable GetAllEmployees()
        {
            return _dbConnector.ExecuteQuery(EmployeeQueries.GetAllEmployees);
        }

        public DataTable SearchEmployees(string name)
        {
            SqlParameter[] parameters = { new SqlParameter("@EmployeeName", "%" + name + "%") };
            return _dbConnector.ExecuteQuery(EmployeeQueries.SearchEmployees, parameters);
        }

        public bool DeleteEmployee(string employeeId)
        {
            try
            {
                var parameter = new SqlParameter("@EmployeeId", employeeId);
                int affectedRows = _dbConnector.ExecuteNonQuery(
                    EmployeeQueries.DeleteEmployee,
                    parameter);

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }

        public bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                // Kiểm tra các giá trị tham số trước khi gọi ExecuteNonQuery
                Console.WriteLine("Cập nhật nhân viên với các giá trị:");
                Console.WriteLine($"Tên: {employeeDTO.EmployeeName}, Giới tính: {employeeDTO.Gender}, Ngày sinh: {employeeDTO.DateOfBirth}, Ca làm việc: {employeeDTO.Shift}");

                var parameters = new[]
                {
                    new SqlParameter("@EmployeeName", employeeDTO.EmployeeName),
                    new SqlParameter("@Gender", employeeDTO.Gender),
                    new SqlParameter("@DateOfBirth", employeeDTO.DateOfBirth),
                    new SqlParameter("@Shift", employeeDTO.Shift ?? (object)DBNull.Value),
                    new SqlParameter("@PhoneNumber", employeeDTO.PhoneNumber ?? (object)DBNull.Value),
                    new SqlParameter("@Salary", employeeDTO.Salary),
                    new SqlParameter("@Role", employeeDTO.Role),
                    new SqlParameter("@EmployeeId", employeeDTO.EmployeeId)
                };

                // Kiểm tra câu lệnh SQL và các tham số (debug)
                string query = EmployeeQueries.UpdateEmployee;
                foreach (var param in parameters)
                {
                    query = query.Replace(param.ParameterName, param.Value.ToString());
                }
                Console.WriteLine("Câu lệnh SQL: " + query);

                int affectedRows = _dbConnector.ExecuteNonQuery(EmployeeQueries.UpdateEmployee, parameters);

                // Kiểm tra kết quả trả về
                if (affectedRows > 0)
                {
                    Console.WriteLine("Cập nhật thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Không có bản ghi nào bị thay đổi.");
                    return false;
                }
            }
            catch (SqlException ex)
            {
                // Log lỗi SQL chi tiết
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
                throw new Exception("Lỗi khi cập nhật nhân viên: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Log lỗi tổng quát và ghi thông tin chi tiết
                Console.WriteLine($"Lỗi tổng quát: {ex.Message}");
                throw new Exception("Lỗi khi cập nhật nhân viên: " + ex.Message);
            }
        }

    }
}
