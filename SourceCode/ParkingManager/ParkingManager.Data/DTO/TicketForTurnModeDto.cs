using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.DTO
{
    public class TicketForTurnModeDto
    {
        public string ID { get; set; }
        public string LicensePlate { get; set; }
        public DateTime Time { get; set; }
        public int AreaID { get; set; }
        public int VehicleType { get; set; }
        public PriceDto Fee { get; set; }
        public bool Status { get; set; }

    }
}
