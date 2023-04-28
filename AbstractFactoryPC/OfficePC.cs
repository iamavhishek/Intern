namespace AbstractFactoryPC;

public class OfficePC : ISpec
{
    public string Ram()
    {
        return "RAM: 8GB";
    }

    public string Storage()
    {
        return "Storage: 512GB SSD";
    }

    public bool RGB()
    {
        return false;
    }
}