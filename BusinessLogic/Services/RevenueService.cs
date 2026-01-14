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
    public class RevenueService
    {
        private readonly DbConnector _dbConnector;

        public RevenueService()
        {
            _dbConnector = new DbConnector();
        }

        public DataTable GetMovies()
        {
            return _dbConnector.ExecuteQuery(RevenueQueries.GetMovies);
        }

        public DataTable GetProducts()
        {
            return _dbConnector.ExecuteQuery(RevenueQueries.GetProducts);
        }

        public DataTable GetRevenueByRange(DateTime startDate, DateTime endDate)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@StartDate", SqlDbType.Date) { Value = startDate.Date },
                new SqlParameter("@EndDate", SqlDbType.Date) { Value = endDate.Date }
            };

            // Chuyển đổi List<SqlParameter> thành SqlParameter[]
            return _dbConnector.ExecuteQuery(RevenueQueries.GetRevenueByRange, parameters.ToArray());
        }





    }
}
