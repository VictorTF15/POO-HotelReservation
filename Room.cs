using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    internal class Room
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; } = true;
        public Room(int number, string type, double price)
        {
            Number = number;
            Type = type;
            Price = price;
        }
        public string Reservation()
        {
            if (Available)
            {
                Available = false;
                return $"Habitación {Number} reservada.";
            }
            else
            {
                return $"Habitación {Number} no disponible.";
            }
        }
        public string Realse()
        {
            Available = true;
            return $"Habitación {Number} liberada.";
        }

    }
}
