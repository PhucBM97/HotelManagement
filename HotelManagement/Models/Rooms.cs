using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Rooms
    {
        public string RoomID { get; set; }
        public int? RoomNumber { get; set; }
        public string RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public double? PricePerNight { get; set; }
        public bool Availability { get; set; }
    }
}
