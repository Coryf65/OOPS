// we have rentals and vehicles
namespace BetterOODemo;

public class Car : LandVehicle, IRental
{
    public CarType Type { get; set; }
    public int RentalId { get; set; }
    public string CurrentRental { get; set; }
    public decimal PricePerDay { get; set; }
}