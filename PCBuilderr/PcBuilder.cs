namespace PCBuilderr;

public class PcBuilder
{
    public static ISystem Make(string sysType)
    {
        if (sysType == "gaming")
            return new GamingBuilder();
        else if (sysType == "office")
            return new OfficeBuilder();
        else
            return null;
    }
}