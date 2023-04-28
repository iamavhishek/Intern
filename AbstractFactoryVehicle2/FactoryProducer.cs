namespace AbstractFactoryVehicle2;

public class FactoryProducer
{
    public static IVechicle getVehicleType(string vehicleType)
    {
        if (vehicleType == null) return null;

        if (vehicleType == "BIKE")
            return new BikeFactory();
        else if (vehicleType == "CAR") return new CarFactory();
        return null;
    }
}