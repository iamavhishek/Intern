namespace PCBuilderr;

public class Hp : IOffice
{
    public void Ram()
    {
        Console.WriteLine("4GB RAM is installed");
    }

    public void Storage()
    {
        Console.WriteLine("128GB SSD is installed");
    }

    public void Printer()
    {
        Console.WriteLine("There is printer");
    }
}