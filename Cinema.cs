using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;

namespace Cinema_UML
{
    public class Cinema
    {
        // Cinema name
        public string Name { get; set; }

        // Cinema location
        public string Location { get; set; }

        // List of halls in the cinema
        public List<Hall> Halls { get; set; }

        // Constructor
        public Cinema(string name, string location)
        {
            Name = name;
            Location = location;
            Halls = new List<Hall>();
        }

        // Method to get all halls
        public List<Hall> GetHalls()
        {
            return Halls;
        }

        // Method to add a hall to the cinema
        public void AddHall(Hall hall)
        {
            if (hall != null)
            {
                Halls.Add(hall);
                Console.WriteLine($"Hall {hall.HallNumber} added to cinema {Name}.");
            }
        }
    }
}
