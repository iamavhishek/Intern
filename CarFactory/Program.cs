namespace CarFactory;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the vehicle type: ");
        var Vtype = Console.ReadLine();

        var p1 = Product.getInfo(Vtype);
        Console.WriteLine(p1.wheels());
        Console.WriteLine(p1.seat());
    }
}