namespace Decorator;

public class PlainPizza : IPizza
{
    public string getDescription()
    {
        return "Thin Dough";
    }

    public double getCost()
    {
        return 4.00;
    }
}