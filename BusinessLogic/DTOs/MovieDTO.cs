using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class MovieDTO
    {
        [DisplayName("ID")]
        public int Movie_ID { get; set; }
        [DisplayName("Tên phim")]
        public string Title { get; set; }

        [DisplayName("Thể loại")]
        public string Genre { get; set; }

        [DisplayName("Độ tuổi")]
        public string Rated { get; set; }

        [DisplayName("Quốc gia")]
        public string Country { get; set; }

        [DisplayName("Trạng thái")]
        public string Status { get; set; }

        [DisplayName("Đạo diễn")]
        public string Director { get; set; }

        [DisplayName("Thời lượng")]
        public string RunningTime { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
