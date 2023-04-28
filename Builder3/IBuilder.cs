namespace Builder3;

public interface IBuilder
{
    void greetAtMorning();
    void greetAtAfternoon();
    void greetAtEvening();
    void greetAtNight();
    Product GetGreeting();
}