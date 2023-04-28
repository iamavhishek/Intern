namespace AbstractFactoryVehicle2;

public class CarFactory : IVechicle
{
    public ICar getCar(string choice)
    {
        if (choice == null) return null;

        if (choice == "CRETA")
            return new Creta();
        else if (choice == "Carnival") return new Carnival();

        return null;
    }

    public IBike getBike(string choice)
    {
        return null;
    }
}