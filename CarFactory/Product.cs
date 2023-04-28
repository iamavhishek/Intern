namespace CarFactory;

public class Product
{
    public static IVehicle getInfo(string type)
    {
        switch (type)
        {
            case "truck":
                return new truck();
            case "car":
                return new car();
            default:
                return null;
        }
    }
}