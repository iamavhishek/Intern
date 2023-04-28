using AbstractFactoryVehicle2;

public class Program
{
    public static void Main(string[] args)
    {
        var vechicleType = FactoryProducer.getVehicleType("BIKE");
        var bike = vechicleType.getBike("PULSAR");
        bike.seater();
    }
}