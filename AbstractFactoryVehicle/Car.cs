namespace AbstractFactoryVehicle;

public class Car : ISpec
{
    public string wheels()
    {
        return "Wheels: 4";
    }

    public string seat()
    {
        return "Seat: 6";
    }
}