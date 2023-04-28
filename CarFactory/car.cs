namespace CarFactory;

public class car : IVehicle
{
    public string seat()
    {
        return "4 Seater";
    }

    public string wheels()
    {
        return "Car has 4 wheels";
    }
}