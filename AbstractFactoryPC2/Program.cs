using AbstractFactoryPC2;

public class Program
{
    public static void Main()
    {
        var sys1 = PcProducer.Make("gaming");
        var g1 = sys1.gamingPC("msi");
        g1.Joystick();
        g1.Ram();
        g1.Storage();
    }
}