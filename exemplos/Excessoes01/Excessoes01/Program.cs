using Excessoes01.Entities;
using Excessoes01.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Check-in date (dd/MM/YYYY): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/YYYY): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);
    Console.WriteLine();


    Console.WriteLine("Enter the data to update the reservation:");

    Console.Write("Check-in date (dd/MM/YYYY): ");
    checkin = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/YYYY): ");
    checkout = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}




