namespace PCFactory;

public class Produce
{
    public static ISpecs showSpec(string type)
    {
        switch (type.ToLower())
        {
            case "gaming":
                return new GamingPC();
            case "office":
                return new OfficePC();
            default:
                return null;
        }
    }
}