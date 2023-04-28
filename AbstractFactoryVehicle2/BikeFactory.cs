namespace AbstractFactoryVehicle2;

public class BikeFactory : IVechicle
{
    public IBike getBike(string choice)
    {
        if (choice == null) return null;

        if (choice == "PULSAR")
            return new Pulsar();
        else if (choice == "CBR") return new CBR();

        return null;
    }

    public ICar getCar(string choice)
    {
        return null;
    }
}