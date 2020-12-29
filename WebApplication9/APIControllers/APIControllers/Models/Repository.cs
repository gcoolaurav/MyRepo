using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIControllers.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Reservation> items;

        public Repository()
        {
            items = new Dictionary<int, Reservation>();
            new List<Reservation> {
                new Reservation {Id=1, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=2, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=3, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=4, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=5, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=6, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=7, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=8, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=9, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=10, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=11, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=12, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=13, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=14, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=15, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=16, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=17, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=18, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=19, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=20, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=21, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=22, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=23, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=24, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=25, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=26, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=27, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=28, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=29, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=30, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=31, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=32, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=33, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=34, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=35, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=36, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=37, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=38, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=39, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=40, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=41, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=42, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=43, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=44, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=45, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=46, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=47, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=48, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=49, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=50, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=51, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=52, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=53, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=54, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=55, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=56, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=57, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=58, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=59, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=60, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=61, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=62, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=63, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=64, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=65, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=66, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=67, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=68, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=69, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=70, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=71, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=72, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=73, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=74, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=75, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=76, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=77, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=78, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=79, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=80, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=81, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=82, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=83, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=84, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=85, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=86, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=87, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=88, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=89, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=90, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=91, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=92, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=93, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=94, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=95, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=96, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=97, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=98, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
                new Reservation {Id=99, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
                new Reservation {Id=100, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" }
                }.ForEach(r => AddReservation(r));
        }

        public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<Reservation> Reservations => items.Values;

        public Reservation AddReservation(Reservation reservation)
        {
            if (reservation.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.Id = key;
            }
            items[reservation.Id] = reservation;
            return reservation;
        }

        public void DeleteReservation(int id) => items.Remove(id);

        public Reservation UpdateReservation(Reservation reservation) => AddReservation(reservation);
    }
}
