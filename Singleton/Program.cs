namespace Singleton;

public sealed class Singleton
{
    private Singleton()
    {
    }

    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            Console.WriteLine("New Instance Created");
            _instance = new Singleton();
            return _instance;
        }
        else
        {
            Console.WriteLine("Instance was already created");
            return _instance;
        }
    }
}

public class Program
{
    public static void Main()
    {
        var S1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();
    }
}