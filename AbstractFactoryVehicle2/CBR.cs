namespace AbstractFactoryVehicle2;

public class CBR : IBike
{
    public void wheels()
    {
        Console.WriteLine("Bike has 3 wheels");
    }

    public void seater()
    {
        Console.WriteLine("Bike has 3 seats");
    }
}