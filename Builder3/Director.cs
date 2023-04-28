namespace Builder3;

public class Director
{
    public static void Greet(IBuilder greet)
    {
        greet.greetAtMorning();
        greet.greetAtAfternoon();
        greet.greetAtEvening();
        greet.greetAtNight();
    }
}