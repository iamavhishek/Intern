using Decorator;

public class Program
{
    public static void Main(string[] args)
    {
        IPizza basicPizza = new Mozzarella(new TomatoSauce(new PlainPizza()));
        Console.WriteLine($"Ingredients used: {basicPizza.getDescription()}");
        Console.WriteLine($"Price: ${basicPizza.getCost()}");
    }
}