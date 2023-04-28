namespace Builder3;

public class Program
{
    public static void Main()
    {
        IBuilder build = new ConcBuilder();
        Director.Greet(build);

        Product pd1 = build.GetGreeting();
        Console.Write(pd1.SayGoodAfternoon);
    }
}