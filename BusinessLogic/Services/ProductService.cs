using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOs;
using DataAccessLayer.SqlQueries;
using DataAccessLayer;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic.Services
{
    public class ProductService
    {
        private readonly DbConnector _dbConnector;

        public ProductService()
        {
            _dbConnector = new DbConnector();
        }

        public bool AddProduct(ProductDTO productDTO)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@ProductName", productDTO.ProductName),
                    new SqlParameter("@Quantity", productDTO.Quantity),
                    new SqlParameter("@Sold", productDTO.Sold),
                    new SqlParameter("@ImportDate", productDTO.ImportDate),
                    new SqlParameter("@Price", productDTO.Price),
                    new SqlParameter("@Image", productDTO.Image ?? (object)DBNull.Value)
                };

                int affectedRows = _dbConnector.ExecuteNonQuery(ProductQueries.AddProduct, parameters);

                // Trả về true nếu thêm thành công ít nhất 1 dòng
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        public DataTable GetAllProducts()
        {
            return _dbConnector.ExecuteQuery(ProductQueries.GetAllProducts);
        }

        public bool UpdateProduct(ProductDTO productDTO)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@ProductName", productDTO.ProductName),
                    new SqlParameter("@Quantity", productDTO.Quantity),
                    new SqlParameter("@Sold", productDTO.Sold),
                    new SqlParameter("@ImportDate", productDTO.ImportDate),
                    new SqlParameter("@Price", productDTO.Price),
                    new SqlParameter("@Image", productDTO.Image ?? (object)DBNull.Value),
                    new SqlParameter("@ID", productDTO.ID)  // Lấy ID từ DTO (đã có sẵn)
                };

                int affectedRows = _dbConnector.ExecuteNonQuery(ProductQueries.UpdateProduct, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sản phẩm: " + ex.Message);
            }
        }

        public DataTable SearchProducts(string title)
        {
            SqlParameter[] parameters = { new SqlParameter("@ProductName", "%" + title + "%") };
            return _dbConnector.ExecuteQuery(ProductQueries.SearchProducts, parameters);
        }

        public bool DeleteProduct(string ID)
        {
            try
            {
                var parameter = new SqlParameter("@ID", ID);
                int affectedRows = _dbConnector.ExecuteNonQuery(
                    "DELETE FROM products WHERE ID = @ID",
                    parameter);

                return affectedRows > 0; // Trả về true nếu xóa thành công
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa phim: " + ex.Message);
            }
        }

        public ProductDTO GetProductById(int id)
        {
            try
            {
                var parameters = new[] { new SqlParameter("@ID", id) };
                DataTable data = _dbConnector.ExecuteQuery(
                    "SELECT * FROM products WHERE ID = @ID", parameters);

                if (data != null && data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    return new ProductDTO
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        ProductName = row["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(row["Quantity"]),
                        Sold = Convert.ToInt32(row["Sold"]),
                        ImportDate = Convert.ToDateTime(row["ImportDate"]),
                        Price = Convert.ToDecimal(row["Price"]),
                        Image = row["Image"]?.ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin sản phẩm: {ex.Message}");
            }
        }
    }
}
