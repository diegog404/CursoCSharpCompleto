using Excessoes01.Entities;

Console.Write("Room number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Check-in date (dd/MM/YYYY): ");
DateTime checkin = DateTime.Parse(Console.ReadLine());

Console.Write("Check-out date (dd/MM/YYYY): ");
DateTime checkout = DateTime.Parse(Console.ReadLine());

if(checkout <= checkin)
{
    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");

}
else
{
    Reservation reservation = new Reservation(number, checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);
    Console.WriteLine();

    Console.WriteLine("Enter the data to update the reservation:");

    Console.Write("Check-in date (dd/MM/YYYY): ");
    checkin = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/YYYY): ");
    checkout = DateTime.Parse(Console.ReadLine());

    DateTime now = DateTime.Now;

    if(checkin < now || checkout < now)
    {
        Console.WriteLine("Error in reservation: Reservation dates must be future");
    }
    else if(checkout <= checkin)
    {
        Console.WriteLine("Error in reservation: Checkout date must be after check-in date");
    }
    else
    {
        reservation.UpdateDates(checkin, checkout);
        Console.WriteLine("Reservation: " + reservation);
    }
}



