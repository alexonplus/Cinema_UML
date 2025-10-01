using System;

namespace Cinema_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a cinema
            Cinema cinema = new Cinema("Grand Cinema", "Stockholm");

            // Create a hall with 10 seats
            Hall hall1 = new Hall(1, "IMAX", 10);
            cinema.AddHall(hall1);

            // Create a movie
            Movie movie = new Movie("Inception", 148, "Sci-Fi");

            // Create a show and add it to the hall
            Show show1 = new Show(DateTime.Now.AddHours(2), movie, 120m);
            hall1.AddShow(show1);

            // Display the number of free seats before buying a ticket
            Console.WriteLine("Free seats before: " + show1.GetFreeSeats());

            // Buy a ticket for seat number 5
            show1.BuyTicket(5);

            // Display the number of free seats after buying a ticket
            Console.WriteLine("Free seats after: " + show1.GetFreeSeats());

            // Display the list of available seats
            Console.WriteLine("Available seats:");
            foreach (var seat in hall1.GetAvailableSeats())
            {
                Console.Write(seat.SeatNumber + " ");
            }
            Console.WriteLine();

            // Attempt to buy a ticket for an already reserved seat
            show1.BuyTicket(5);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
