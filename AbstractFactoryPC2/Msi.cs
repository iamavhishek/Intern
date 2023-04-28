namespace AbstractFactoryPC2;

public class Msi : IGaming
{
    public void Ram()
    {
        Console.WriteLine("It has 32GB of RAM");
    }

    public void Storage()
    {
        Console.WriteLine("It has 2TB of SSD");
    }

    public void Joystick()
    {
        Console.WriteLine("Joystick is Missing");
    }
}