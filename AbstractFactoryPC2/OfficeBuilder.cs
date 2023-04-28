namespace AbstractFactoryPC2;

public class OfficeBuilder : ISystem
{
    public IOffice officePC(string brand)
    {
        if (brand == null)
            return null;
        else if (brand == "acer")
            return new Acer();
        else if (brand == "hp") return new Hp();
        return null;
    }

    public IGaming gamingPC(string brand)
    {
        return null;
    }
}