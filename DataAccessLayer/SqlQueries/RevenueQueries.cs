using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SqlQueries
{
    public  class RevenueQueries
    {
        public const string GetMovies = @"
                            SELECT MovieName, TotalTickets, RevenueDate, TotalRevenue
                            FROM MovieRevenueByDate";
        public const string GetProducts = @"
                            SELECT 
                                ID, 
                                productName,  
                                sold, 
                                price * sold AS totalPrice
                            FROM 
                                products;
                                ";
        public const string GetRevenueByRange = @"
                            SELECT MovieName, TotalTickets, RevenueDate, TotalRevenue
                            FROM MovieRevenueByDate
                            WHERE RevenueDate BETWEEN @StartDate AND @EndDate
                            ORDER BY RevenueDate";


    }
}
