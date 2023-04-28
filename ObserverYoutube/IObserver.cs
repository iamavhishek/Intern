namespace ObserverYoutube;

public interface IObserver
{
    void Update(string channelName, string videoTitle);
}