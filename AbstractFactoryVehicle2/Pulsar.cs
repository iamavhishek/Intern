namespace AbstractFactoryVehicle2;

public class Pulsar : IBike
{
    public void wheels()
    {
        Console.WriteLine("Bike has 2 wheels");
    }

    public void seater()
    {
        Console.WriteLine("Bike has 2 seats");
    }
}