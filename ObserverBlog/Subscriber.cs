using System.Threading.Channels;

namespace ObserverBlog;

public class Subscriber
{
    public string name;
    private Channel channel = new Channel();

    public Subscriber(string _name)
    {
        name = _name;
    }

    public void update()
    {
        Console.WriteLine($"Hey {name}, Video Uploaded");
    }

    public void subscribeChannel(Channel ch)
    {
        channel = ch;
    }
}