namespace DataAccessLayer.SqlQueries
{
    public static class ScreeningQueries
    {
        public static string InsertScreening = @"
            INSERT INTO Screenings (MovieID, ScreeningDate, ScreeningTime, Room)
            VALUES (@MovieID, @ScreeningDate, @ScreeningTime, @Room)";

        public static string UpdateScreening = @"
            UPDATE Screenings SET 
                MovieID = @MovieID,
                ScreeningDate = @ScreeningDate,
                ScreeningTime = @ScreeningTime,
                Room = @Room
            WHERE ScreeningID = @ScreeningID";

        public static string DeleteScreening = "DELETE FROM Screenings WHERE ScreeningID = @ScreeningID";

        public static string GetAllScreenings = "SELECT \r\n    s.ScreeningID,\r\n    s.MovieID,\r\n    m.title AS Title,\r\n    m.genre AS Genre,\r\n    m.runningTime AS RunningTime,\r\n    s.ScreeningDate,\r\n    s.ScreeningTime,\r\n    s.Room\r\nFROM Screenings s\r\nJOIN Movies m ON s.MovieID = m.movie_id\r\n";

        public static string GetScreeningById = @"
            SELECT 
                s.ScreeningID, 
                s.MovieID, 
                m.title AS MovieTitle, 
                s.ScreeningDate, 
                s.ScreeningTime, 
                s.Room
            FROM Screenings s
            JOIN Movies m ON s.MovieID = m.movie_id
            WHERE s.ScreeningID = @ScreeningID
            ";


        public const string GetAllMovies = "SELECT movie_id, title FROM Movies";



    }
}