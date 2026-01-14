using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SqlQueries
{
    public class ProductQueries
    {
        public const string AddProduct = @"
            INSERT INTO products 
            (productName, quantity, sold, importDate, price, image) 
            VALUES 
            (@ProductName, @Quantity, @Sold, @ImportDate, @Price, @Image)";

        public const string CheckProductExists = "SELECT COUNT(*) FROM Movies WHERE ID = @ID";

        public const string GetAllProducts = @"
            SELECT ID, productName, quantity, sold, importDate, price
            FROM products";

        public const string SearchProducts = @"SELECT ID, productName, sold, quantity, importDate 
                                                FROM products 
                                                WHERE ProductName LIKE @ProductName";
        public const string DeleteProduct = "DELETE FROM products WHERE ID = @ID";
        public const string UpdateProduct = @"UPDATE products
                                    SET productName = @ProductName,
                                        quantity = @Quantity,
                                        sold = @Sold,
                                        importDate = @ImportDate,
                                        price = @Price,
                                        image = @Image
                                    WHERE ID = @ID;";
    }
}
