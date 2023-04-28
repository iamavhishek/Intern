namespace ObserverYoutube;

public class User : IObserver
{
    private string userName;

    public User(string name)
    {
        userName = name;
    }

    public void Update(string channelName, string videoTitle)
    {
        Console.WriteLine(
            $"Hey '{userName}', you received received a notification: '{channelName}' uploaded a new video '{videoTitle}'");
    }
}