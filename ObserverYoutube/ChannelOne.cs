namespace ObserverYoutube;

public class ChannelOne : IYouTubeChannel
{
    private List<IObserver> subs = new List<IObserver>();
    private string channelName;
    private string videoTitle;

    public ChannelOne(string name)
    {
        channelName = name;
    }

    public void RegisterObserver(IObserver observer)
    {
        subs.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        subs.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver sub in subs)
        {
            sub.Update(channelName, videoTitle);
        }
    }

    public void UploadVideo(string title)
    {
        videoTitle = title;
        Console.WriteLine($"New video {title} has been uploaded to {channelName}");
        NotifyObservers();
    }
}