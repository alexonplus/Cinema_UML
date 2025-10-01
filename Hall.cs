using System;
using System.Collections.Generic;

namespace Cinema_UML
{
    public class Hall
    {
        private List<Seat> seats;
        private List<Show> shows;

        public int HallNumber { get; private set; }
        public string TypeHall { get; private set; }

        public Hall(int hallNumber, string typeHall, int seatCount)
        {
            HallNumber = hallNumber;
            TypeHall = typeHall;

            seats = new List<Seat>();
            shows = new List<Show>();

            for (int i = 1; i <= seatCount; i++)
            {
                seats.Add(new Seat(i));
            }
        }

        // Явные методы (вместо =>), чтобы точно работать на любых версиях C#
        public List<Seat> GetSeats()
        {
            return seats;
        }

        public List<Show> GetShows()
        {
            return shows;
        }

        public List<Seat> GetAvailableSeats()
        {
            List<Seat> free = new List<Seat>();
            foreach (var s in seats)
            {
                if (!s.IsReserved()) free.Add(s);
            }
            return free;
        }

        // Добавляем шоу и, если нужно, "привязываем" его к этому залу
        public void AddShow(Show show)
        {
            if (show == null) throw new ArgumentNullException("show");

            if (show.Hall == null)
            {
                // назначаем зал шоу
                show.Hall = this;
            }
            else if (show.Hall != this)
            {
                throw new InvalidOperationException("Show already assigned to another hall.");
            }

            shows.Add(show);
        }
    }
}

