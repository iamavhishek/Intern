namespace AbstractFactoryVehicle;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Vehicle Type: ");
        var VehicleType = Console.ReadLine();
        IVehicle vehiclee;

        switch (VehicleType.ToLower())
        {
            case "truck":
                vehiclee = new TruckFactory();
                break;
            case "car":
                vehiclee = new CarFactory();
                break;
            default:
                return;
        }

        var v1 = vehiclee.CreateVehicle();
        Console.WriteLine(v1.seat());
        Console.WriteLine(v1.wheels());
    }
}