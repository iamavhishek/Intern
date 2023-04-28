namespace AbstractFactoryVehicle;

public interface IVehicle
{
    ISpec CreateVehicle();
}