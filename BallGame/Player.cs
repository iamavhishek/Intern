namespace BallGame;

public class Player : IObserver
{
    private int observerGuess;

    public bool update(int ballState)
    {
        return guess(ballState);
    }

    private bool check(int ballState, int observerGuess)
    {
        if (ballState == this.observerGuess)
        {
            Console.WriteLine("It's a match");
            return false;
        }

        return true;
    }

    private bool guess(int ballState)
    {
        observerGuess = new Random().Next(1, 5);
        Console.WriteLine($"Observer Guess: The ball is with player {observerGuess}");
        return check(ballState, observerGuess);
    }
}