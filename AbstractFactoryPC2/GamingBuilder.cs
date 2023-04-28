namespace AbstractFactoryPC2;

public class GamingBuilder : ISystem
{
    public IOffice officePC(string brand)
    {
        return null;
    }

    public IGaming gamingPC(string brand)
    {
        if (brand == null)
            return null;
        else if (brand == "asus")
            return new Asus();
        else if (brand == "msi") return new Msi();
        return null;
    }
}