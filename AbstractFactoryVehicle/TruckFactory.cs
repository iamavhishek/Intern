namespace AbstractFactoryVehicle;

public class TruckFactory : IVehicle
{
    public ISpec CreateVehicle()
    {
        return new Truck();
    }
}