namespace CarFactory;

public class truck : IVehicle
{
    public string wheels()
    {
        return "Truck has 12 Wheels";
    }

    public string seat()
    {
        return "6 Seater";
    }
}