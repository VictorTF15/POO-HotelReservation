using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    internal class Reservation
    {
        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public Reservation(Customer customer, Room room, DateTime stardate, DateTime enddate)
        {
            Customer = customer;
            Room = room;
            StarDate = stardate;
            EndDate = enddate;
        }
        public string Confirm()
        {
            if (Room.Available)
            {
                Room.Reservation();
                return $"Reserva confirmada para {Customer.Name}. Habitación \n { Room.Number} \n del { StarDate.ToShortDateString()} \n al { EndDate.ToShortDateString()}.";
            }
            else
            {
                return $"⚠ No se pudo confirmar la reserva. Habitación {Room.Number} ocupada.";
            }
        }
    }
}
