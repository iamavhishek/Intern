namespace AbstractFactoryPC;

public class GamingPC : ISpec
{
    public string Ram()
    {
        return "RAM: 32GB";
    }

    public string Storage()
    {
        return "Storage: 2TB SSD";
    }

    public bool RGB()
    {
        return true;
    }
}