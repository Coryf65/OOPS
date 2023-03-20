// Rental agency in florida
using OODemo;

public class RentalVehicle
{
    public int RentalId { get; set; }
    public string CurrentRental { get; set; }
    public decimal PricePerDay { get; set; }
    public int NumberOfPassengers { get; set; }


    public virtual void StartEngine()
    {
        Console.WriteLine("Turn Key in the ignition");
        Console.WriteLine("Trun key to on");
    }

    public virtual void StopEngine()
    {
        Console.WriteLine("Turn key to off");
    }
}