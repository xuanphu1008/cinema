using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.DTOs;
using DataAccessLayer.SqlQueries;
using DataAccessLayer;

namespace BusinessLogic.Services
{
    public class ScreeningService
    {
        private readonly DbConnector _dbConnector;

        public ScreeningService()
        {
            _dbConnector = new DbConnector();
        }

        #region Create

        public bool AddScreening(ScreeningDTO screening)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@MovieID", screening.MovieID),
                    new SqlParameter("@ScreeningDate", screening.ScreeningDate),
                    new SqlParameter("@ScreeningTime", screening.ScreeningTime),
                    new SqlParameter("@Room", screening.Room)
                };

                int rowsAffected = _dbConnector.ExecuteNonQuery(ScreeningQueries.InsertScreening, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm suất chiếu: " + ex.Message);
            }
        }

        #endregion

        #region Read

        public DataTable GetAllScreenings()
        {
            try
            {
                return _dbConnector.ExecuteQuery(ScreeningQueries.GetAllScreenings);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách suất chiếu: " + ex.Message);
            }
        }

        public ScreeningDTO GetScreeningById(int id)
        {
            try
            {
                var parameters = new[] { new SqlParameter("@ScreeningID", id) };
                DataTable data = _dbConnector.ExecuteQuery(ScreeningQueries.GetScreeningById, parameters);

                if (data != null && data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    return new ScreeningDTO
                    {
                        ScreeningID = Convert.ToInt32(row["ScreeningID"]),
                        MovieID = Convert.ToInt32(row["MovieID"]),
                        MovieTitle = row["MovieTitle"].ToString(),
                        ScreeningDate = Convert.ToDateTime(row["ScreeningDate"]),
                        ScreeningTime = (TimeSpan)row["ScreeningTime"],
                        Room = row["Room"].ToString()
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy suất chiếu theo ID: " + ex.Message);
            }
        }

        public DataTable GetAllMovies()
        {
            try
            {
                return _dbConnector.ExecuteQuery(ScreeningQueries.GetAllMovies);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách phim: " + ex.Message);
            }
        }

        #endregion

        #region Update

        public bool UpdateScreening(ScreeningDTO screening)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@ScreeningID", screening.ScreeningID),
                    new SqlParameter("@MovieID", screening.MovieID),
                    new SqlParameter("@ScreeningDate", screening.ScreeningDate),
                    new SqlParameter("@ScreeningTime", screening.ScreeningTime),
                    new SqlParameter("@Room", screening.Room)
                };

                int rowsAffected = _dbConnector.ExecuteNonQuery(ScreeningQueries.UpdateScreening, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật suất chiếu: " + ex.Message);
            }
        }

        #endregion

        #region Delete

        public bool DeleteScreening(int screeningID)
        {
            try
            {
                var parameter = new SqlParameter("@ScreeningID", screeningID);
                int rowsAffected = _dbConnector.ExecuteNonQuery(ScreeningQueries.DeleteScreening, parameter);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa suất chiếu: " + ex.Message);
            }
        }

        public bool DeleteOldScreenings(DateTime currentDate)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@Today", currentDate)
                };

                string query = "DELETE FROM Screenings WHERE ScreeningDate < @Today";
                int rowsAffected = _dbConnector.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa các suất chiếu cũ: " + ex.Message);
            }
        }

        #endregion
    }
}