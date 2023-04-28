namespace Builder3;

public class ConcBuilder : IBuilder
{
    private Product p1 = new Product();

    public void greetAtMorning()
    {
        p1.SayGoodMorning = "Good Morning";
    }

    public void greetAtAfternoon()
    {
        p1.SayGoodAfternoon = "Good Afternoon";
    }

    public void greetAtEvening()
    {
        p1.SayGoodEvening = "Good Evening";
    }

    public void greetAtNight()
    {
        p1.SayGoodNight = "Good Night";
    }

    public Product GetGreeting()
    {
        return p1;
    }
}