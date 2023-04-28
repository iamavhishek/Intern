namespace BallGame;

public class Ball : IBall
{
    private List<IObserver> _observers = new List<IObserver>();
    private int state = 0;

    public void register(IObserver player)
    {
        _observers.Add(player);
    }

    public void unRegister(IObserver player)
    {
        _observers.Remove(player);
    }

    private int ballState()
    {
        Random rd = new Random();
        Thread.Sleep(2000);

        state = rd.Next(1, 5);
        Console.WriteLine($"\nBall is with player {state}");
        Thread.Sleep(1000);
        return state;
    }

    public void notify()
    {
        bool flag = true;
        do
        {
            int ballstate = ballState();
            // foreach (var observer in _observers)
            // {
            //     flag = observer.update(ballstate);
            // }
            flag = _observers[0].update(ballstate);
        } while (flag);

        Console.WriteLine("Game Over");
    }
}