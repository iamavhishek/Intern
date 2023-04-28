namespace Decorator;

public class Mozzarella : ToppingDecorator
{
    public Mozzarella(IPizza newPizza) : base(newPizza)
    {
        Console.WriteLine("Adding Dough");
        Console.WriteLine("Addding Mozzarella");
    }

    public override string getDescription()
    {
        return tempPizza.getDescription() + ", Mozzarella";
    }

    public override double getCost()
    {
        return tempPizza.getCost() + 1;
    }
}