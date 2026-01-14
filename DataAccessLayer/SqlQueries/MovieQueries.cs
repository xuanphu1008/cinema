using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SqlQueries
{
    public class MovieQueries
    {
        public const string AddMovie = @"
            INSERT INTO Movies 
            (title, genre, rated, director, country, runningTime, description, status, imageUrl) 
            VALUES 
            (@Title, @Genre, @Rated, @Director, @Country, @RunningTime, @Description, @Status, @ImageUrl)";

        public const string CheckMovieExists = "SELECT COUNT(*) FROM Movies WHERE movie_id = @MovieId";

        public const string GetAllMovies = @"
            SELECT movie_id, title, genre, rated, director, country, runningTime, status, description
            FROM Movies";

        public const string SearchMovies = @"SELECT movie_id, title, genre, rated, director, country, runningTime, status                                              
                                            FROM Movies 
                                            WHERE Title LIKE @Title";
        public const string DeleteMovie = "DELETE FROM Movies WHERE movie_id = @MovieId";

        public const string UpdateMovie = @"UPDATE Movies
                                            SET title = @Title,
                                                genre = @Genre,
                                                rated = @Rated,
                                                director = @Director,
                                                country = @Country,
                                                runningTime = @RunningTime,
                                                description = @Description,
                                                status = @Status,
                                                imageUrl = @ImageUrl
                                            WHERE movie_id = @MovieId;";
    }
}
