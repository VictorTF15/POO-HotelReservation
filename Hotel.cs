using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    internal class Hotel
    {
        public string Name { get; set; }
        private List<Room> RoomList = new List<Room>();
        private List<Reservation> ReservationList = new List<Reservation>();
        public Hotel(string name)
        {
            Name = name;
        }
        public void AddRoom(Room room)
        {
            RoomList.Add(room);
        }
        public string ShowAvailable()
        {
            StringBuilder availableRooms = new StringBuilder("\nHabitaciones disponibles:\n");
            bool hasAvailableRooms = false;

            foreach (var room in RoomList)
            {
                if (room.Available)
                {
                    availableRooms.AppendLine($"- Habitación {room.Number} ({room.Type}) - {room.Price}/noche");
                    hasAvailableRooms = true;
                }
            }

            return hasAvailableRooms ? availableRooms.ToString() : "No hay habitaciones disponibles.";
        }


        public string MakeReservation(Customer customer, int numberRoom, DateTime stardate, DateTime enddate)
        {
            Room room = RoomList.Find(h => h.Number == numberRoom);
            if (room != null)
            {
                Reservation newReservation = new Reservation(customer, room, stardate, enddate);
                newReservation.Confirm();
                ReservationList.Add(newReservation);
                return "Reserva realizada con éxito.";
            }
            else
            {
                return "Habitación no encontrada.";
            }
        }
    }
}
