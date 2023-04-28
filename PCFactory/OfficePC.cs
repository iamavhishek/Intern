namespace PCFactory;

public class OfficePC : ISpecs
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