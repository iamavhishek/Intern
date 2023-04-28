namespace AbstractFactoryPC2;

public class Asus : IGaming
{
    public void Ram()
    {
        Console.WriteLine("It has 64GB of RAM");
    }

    public void Storage()
    {
        Console.WriteLine("It has 4TB of SSD");
    }

    public void Joystick()
    {
        Console.WriteLine("Joystick is Present");
    }
}