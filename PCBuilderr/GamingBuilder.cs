namespace PCBuilderr;

public class GamingBuilder : ISystem
{
    public IOffice officePC(string brand)
    {
        return null;
    }

    public IGaming gamingPC(string brand)
    {
        if (brand == "msi") return new Msi();
        else if (brand == "asus") return new Asus();
        else
            return null;
    }
}