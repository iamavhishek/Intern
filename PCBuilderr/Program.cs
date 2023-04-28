namespace PCBuilderr;

public class Program
{
    public static void Main(string[] args)
    {
        ISystem pc1 = PcBuilder.Make("gaming");
        IGaming g1 = pc1.gamingPC("msi");
        g1.Storage();
        g1.Joystick();
        g1.Ram();
    }
}