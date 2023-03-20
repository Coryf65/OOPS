// Rental agency in florida
using OODemo;

public class RentalCar
{
    public int RentalId { get; set; }
    public string CurrentRental { get; set; }
    public decimal PricePerDay { get; set; }
    public int NumberOfPassengers { get; set; }
    public CarType CarType { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Turn Key in the ignition");
        Console.WriteLine("Trun key to on");
    }

    public void StopEngine()
    {
        Console.WriteLine("Turn key to off");
    }
}