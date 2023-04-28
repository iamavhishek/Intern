namespace PCBuilderr;

public class Acer : IOffice
{
    public void Ram()
    {
        Console.WriteLine("8GB RAM is installed");
    }

    public void Storage()
    {
        Console.WriteLine("512GB SSD is installed");
    }

    public void Printer()
    {
        Console.WriteLine("There is no printer");
    }
}