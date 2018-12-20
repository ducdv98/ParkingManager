using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.DTO
{
    public class CustomerDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string IDCard { get; set; }
        public string Block { get; set; }
        public int VehicleType { get; set; }
        public int AreaID { get; set; }
        public string LicensePlate { get; set; }
        public string TicketID { get; set; }
        public bool Status { get; set; }
        public bool IsParking { get; set; }
        public PriceDto Fee { get; set; } 
    }
}
