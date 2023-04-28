namespace BallGame;

public class Program
{
    public static void Main(string[] args)
    {
        IBall ball = new Ball();
        ball.register(new Player());
        ball.notify();
    }
}