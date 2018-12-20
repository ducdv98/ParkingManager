using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.DTO
{
    public class AreaDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxVolume { get; set; }
        public int Available { get; set; }
        public bool IsTurnMode { get; set; }
    }
}
