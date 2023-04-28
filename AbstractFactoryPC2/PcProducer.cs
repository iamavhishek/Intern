namespace AbstractFactoryPC2;

public class PcProducer
{
    public static ISystem Make(string choice)
    {
        if (choice == null)
            return null;
        else if (choice == "gaming")
            return new GamingBuilder();
        else if (choice == "office")
            return new OfficeBuilder();
        else
            return null;
    }
}