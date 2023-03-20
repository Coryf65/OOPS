// we have rentals and vehicles
public interface IRental
{
    int RentalId { get; set; }
    string CurrentRental { get; set; }
    decimal PricePerDay { get; set; }
}