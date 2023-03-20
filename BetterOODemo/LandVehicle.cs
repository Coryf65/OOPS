// we have rentals and vehicles

namespace BetterOODemo;

public class LandVehicle
{
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