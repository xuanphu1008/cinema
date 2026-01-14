using BusinessLogic.DTOs;
using DataAccessLayer.SqlQueries;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;

namespace BusinessLogic.Services
{
    public class MovieService
    {
        private readonly DbConnector _dbConnector;

        public MovieService()
        {
            _dbConnector = new DbConnector();
        }

        public bool AddMovie(MovieDTO movieDTO)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@Title", movieDTO.Title),
                    new SqlParameter("@Genre", movieDTO.Genre),
                    new SqlParameter("@Rated", movieDTO.Rated ?? (object)DBNull.Value),
                    new SqlParameter("@Status", movieDTO.Status ?? (object)DBNull.Value),
                    new SqlParameter("@Director", movieDTO.Director ?? (object)DBNull.Value),
                    new SqlParameter("@Country", movieDTO.Country ?? (object)DBNull.Value),
                    new SqlParameter("@RunningTime", movieDTO.RunningTime ?? (object)DBNull.Value),
                    new SqlParameter("@Description", movieDTO.Description ?? (object)DBNull.Value),
                    new SqlParameter("@ImageUrl", movieDTO.ImageUrl ?? (object)DBNull.Value)
                };

                int affectedRows = _dbConnector.ExecuteNonQuery(MovieQueries.AddMovie, parameters);

                // Trả về true nếu thêm thành công ít nhất 1 dòng
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm phim: " + ex.Message);
            }
        }

        public bool UpdateMovie(MovieDTO movieDTO)
        {
            try
            {
                // Khởi tạo các tham số SQL từ đối tượng MovieDTO
                var parameters = new[]
                {
                    new SqlParameter("@Title", movieDTO.Title),
                    new SqlParameter("@Genre", movieDTO.Genre),
                    new SqlParameter("@Rated", movieDTO.Rated ?? (object)DBNull.Value),
                    new SqlParameter("@Status", movieDTO.Status ?? (object)DBNull.Value),
                    new SqlParameter("@Director", movieDTO.Director ?? (object)DBNull.Value),
                    new SqlParameter("@Country", movieDTO.Country ?? (object)DBNull.Value),
                    new SqlParameter("@RunningTime", movieDTO.RunningTime ?? (object)DBNull.Value),
                    new SqlParameter("@Description", movieDTO.Description ?? (object)DBNull.Value),
                    new SqlParameter("@ImageUrl", movieDTO.ImageUrl ?? (object)DBNull.Value), // Cập nhật ảnh
                    new SqlParameter("@MovieId", movieDTO.Movie_ID)  // Id của phim cần cập nhật
                };

                // Thực thi câu lệnh SQL UPDATE
                int affectedRows = _dbConnector.ExecuteNonQuery(MovieQueries.UpdateMovie, parameters);

                // Trả về true nếu ít nhất 1 dòng được cập nhật
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa phim: " + ex.Message);
            }
        }

        public DataTable GetAllMovies()
        {
            return _dbConnector.ExecuteQuery(MovieQueries.GetAllMovies);
        }

        public DataTable SearchMovies(string title)
        {
            SqlParameter[] parameters = { new SqlParameter("@Title", "%" + title + "%") };
            return _dbConnector.ExecuteQuery(MovieQueries.SearchMovies, parameters);
        }

        public bool DeleteMovie(string movieId)
        {
            try
            {
                var parameter = new SqlParameter("@MovieId", movieId);
                int affectedRows = _dbConnector.ExecuteNonQuery(
                    "DELETE FROM movies WHERE movie_id = @MovieId",
                    parameter);

                return affectedRows > 0; // Trả về true nếu xóa thành công
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa phim: " + ex.Message);
            }
        }

    }
}
