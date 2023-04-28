namespace AbstractFactoryVehicle;

public class CarFactory : IVehicle
{
    public ISpec CreateVehicle()
    {
        return new Car();
    }
}