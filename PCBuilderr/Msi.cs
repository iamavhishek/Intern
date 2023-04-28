namespace PCBuilderr;

public class Msi : IGaming
{
    public void Ram()
    {
        Console.WriteLine("32GB RAM is installed");
    }

    public void Storage()
    {
        Console.WriteLine("2TB SSD is installed");
    }

    public void Joystick()
    {
        Console.WriteLine("There is no Joystick");
    }
}