using BusinessLogic.DTOs;
using DataAccessLayer.SqlQueries;
using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic.Services
{
    public class CustomerService
    {
        private readonly DbConnector _dbConnector;

        public CustomerService()
        {
            _dbConnector = new DbConnector();
        }

        public DataTable GetAllCustomers()
        {
            try
            {
                return _dbConnector.ExecuteQuery(CustomerQueries.GetAllCustomers);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng: " + ex.Message);
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                // Đặt tham số vào mảng
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id }
                };

                int affectedRows = _dbConnector.ExecuteNonQuery(CustomerQueries.DeleteCustomer, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        public DataTable SearchCustomers(string keyword)
        {
            try
            {
                // Đặt tham số vào mảng
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Keyword", SqlDbType.VarChar) { Value = "%" + keyword + "%" }
                };

                return _dbConnector.ExecuteQuery(CustomerQueries.SearchCustomers, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
            }
        }

        public DataTable SearchEmployees(string name)
        {
            SqlParameter[] parameters = { new SqlParameter("@CustomerName", "%" + name + "%") };
            return _dbConnector.ExecuteQuery(CustomerQueries.SearchCustomers, parameters);
        }
    }
}
