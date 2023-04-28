namespace ObserverYoutube;

interface IYouTubeChannel
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}