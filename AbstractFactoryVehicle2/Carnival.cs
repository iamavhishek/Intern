using System.Data;

namespace AbstractFactoryVehicle2;

public class Carnival : ICar
{
    public void wheels()
    {
        Console.WriteLine("Car has 4 wheels");
    }

    public void seater()
    {
        Console.WriteLine("Car has 5 seats");
    }
}