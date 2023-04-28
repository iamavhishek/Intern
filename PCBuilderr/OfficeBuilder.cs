namespace PCBuilderr;

public class OfficeBuilder : ISystem
{
    public IGaming gamingPC(string brand)
    {
        return null;
    }

    public IOffice officePC(string brand)
    {
        if (brand == "acer") return new Acer();
        else if (brand == "hp") return new Hp();
        else
            return null;
    }
}