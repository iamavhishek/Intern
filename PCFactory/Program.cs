namespace PCFactory;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your PC Type: ");
        var PCType = Console.ReadLine();

        var pc1 = Produce.showSpec(PCType);
        Console.WriteLine(pc1.Ram());
        Console.WriteLine(pc1.Storage());
    }
}