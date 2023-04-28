namespace Decorator;

public class TomatoSauce : ToppingDecorator
{
    public TomatoSauce(IPizza newPizza) : base(newPizza)
    {
        Console.WriteLine("Adding Sauce");
    }

    public override string getDescription()
    {
        return tempPizza.getDescription() + ", Tomato Sauce";
    }

    public override double getCost()
    {
        return tempPizza.getCost() + 1.5;
    }
}