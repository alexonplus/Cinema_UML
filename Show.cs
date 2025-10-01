using System;

namespace Cinema_UML
{
    public class Show
    {
        public DateTime Date { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public decimal Price { get; set; }

        public Show(DateTime date, Movie movie, decimal price)
        {
            Date = date;
            Movie = movie;
            Price = price;
        }

        // Метод для получения количества свободных мест
        public int GetFreeSeats()
        {
            if (Hall == null) return 0;

            int free = 0;
            foreach (var seat in Hall.GetSeats())
            {
                if (!seat.IsReserved())
                    free++;
            }
            return free;
        }

        // Метод покупки билета по номеру места
        public bool BuyTicket(int seatNumber)
        {
            if (Hall == null)
            {
                Console.WriteLine("Show is not assigned to a hall.");
                return false;
            }

            foreach (var seat in Hall.GetSeats())
            {
                if (seat.SeatNumber == seatNumber)
                {
                    if (!seat.IsReserved())
                    {
                        seat.Reserve();
                        Console.WriteLine($"Seat {seatNumber} reserved for {Movie.Title}.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Seat already reserved.");
                        return false;
                    }
                }
            }

            Console.WriteLine("Seat not found.");
            return false;
        }
    }
}

