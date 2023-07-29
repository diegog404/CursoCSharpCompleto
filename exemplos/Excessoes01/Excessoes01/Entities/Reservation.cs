using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excessoes01.Entities.Exceptions;

namespace Excessoes01.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Checkout date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //faz a diferença entre um instante e outro que pega uma duração de timespan
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            //retorna a duração em dias convertido de timespan para int
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                throw new DomainException("Error in reservation: Reservation dates must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Checkout date must be after check-in date");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }
    }
}
