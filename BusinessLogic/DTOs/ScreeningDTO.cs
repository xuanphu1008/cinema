using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class ScreeningDTO
    {

        public int ScreeningID { get; set; }
        public int MovieID { get; set; }
        public DateTime ScreeningDate { get; set; }
        public TimeSpan ScreeningTime { get; set; }
        public string Room { get; set; }

        public string MovieTitle { get; set; }     // Tiêu đề phim
        public string Genre { get; set; }          // Thể loại
        public int RunningTime { get; set; }          // Thời lượng (phút)

    }
}