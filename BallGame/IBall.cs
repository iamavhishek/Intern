namespace BallGame;

public interface IBall
{
    void register(IObserver player);
    void unRegister(IObserver player);
    void notify();
}