using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class RevenueDTO
    {
        public int ProductId {  get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string MovieName { get; set; }
        public string TotalRevenue {  get; set; }
        public int TotalTickets {  get; set; }
        public DateTime RevenueDate {  get; set; }
    }
}
