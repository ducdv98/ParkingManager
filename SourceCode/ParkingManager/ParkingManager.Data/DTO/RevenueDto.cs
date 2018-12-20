using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.DTO
{
    public class RevenueDto
    {
        public DateTime Date { get; set; }
        public decimal RevenueFromTurnMode { get; set; }
        public decimal RevenueFromTermMode { get; set; }
        public decimal TotalRevenue { get; set; }
        
    }
}
