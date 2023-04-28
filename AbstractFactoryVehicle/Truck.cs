namespace AbstractFactoryVehicle;

public class Truck : ISpec
{
    public string wheels()
    {
        return "Wheels: 12";
    }

    public string seat()
    {
        return "Seat: 10";
    }
}