namespace AbstractFactoryPC;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your PC Type: ");
        var PCType = Console.ReadLine();

        IPCFactory factory;
        switch (PCType.ToLower())
        {
            case "gaming":
                factory = new GamingPCFactory();
                break;
            case "office":
                factory = new OfficePCFactory();
                break;
            default:
                return;
        }

        var pc1 = factory.CreatePC();
        Console.WriteLine(pc1.Ram);
        Console.WriteLine(pc1.Storage);
    }
}