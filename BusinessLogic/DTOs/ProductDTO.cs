using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class ProductDTO
    {
        public int ID {  get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Sold {  get; set; }
        public DateTime ImportDate { get; set; }
        public decimal Price { get; set; }
        public string FormattedPrice { get; set; } // Thuộc tính mới để hiển thị giá đã định dạng
        public string Image { get; set; }
    }
}
