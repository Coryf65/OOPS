// we have rentals and vehicles

using BetterOODemo;

public class Truck : LandVehicle, IRental
{
    public TruckType Type { get; set; }
    public int RentalId { get; set; }
    public string CurrentRental { get; set; }
    public decimal PricePerDay { get; set; }
}