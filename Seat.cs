using System;

namespace Cinema_UML
{
    public class Seat
    {
        public int SeatNumber { get; private set; }
        private bool isReserved;

        public Seat(int seatNumber)
        {
            SeatNumber = seatNumber;
            isReserved = false;
        }

        public bool IsReserved()
        {
            return isReserved;
        }

        public void Reserve()
        {
            if (!isReserved) isReserved = true;
        }

        public void Unreserve()
        {
            if (isReserved) isReserved = false;
        }
    }
}



