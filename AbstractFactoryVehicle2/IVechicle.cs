namespace AbstractFactoryVehicle2;

public interface IVechicle
{
    public IBike getBike(string choice);
    public ICar getCar(string Choice);
}