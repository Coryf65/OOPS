namespace OODemo;

internal class RentalSailboat : RentalVehicle
{
    public override void StartEngine()
    {
        throw new Exception("No engine to start!");
    }

    public override void StopEngine()
    {
        throw new Exception("No engine to stop!");
    }
}