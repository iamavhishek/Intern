namespace AbstractFactoryPC2;

public class Hp : IOffice
{
    public void Ram()
    {
        Console.WriteLine("It has 32GB of RAM");
    }

    public void Storage()
    {
        Console.WriteLine("It has 2TB of SSD");
    }

    public void Printer()
    {
        Console.WriteLine("Printer is Present");
    }
}