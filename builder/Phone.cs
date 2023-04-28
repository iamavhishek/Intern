namespace builder;

public class Phone
{
    private string os;
    private int battery;
    private int ram;
    private string brand;

    public Phone(string _os, string _brand, int _battery, int _ram)
    {
        os = _os;
        brand = _brand;
        battery = _battery;
        ram = _ram;
    }

    public override string ToString()
    {
        return $"Phone: [Brand: {brand},OS: {os},Battery: {battery},RAM: {ram}]";
    }
}