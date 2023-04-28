using System.Threading.Channels;

namespace ObserverBlog;

public class Program
{
    public static void Main(string[] args)
    {
        Channel TomJerry = new Channel();
        Channel MickyMouse = new Channel();

        Subscriber sub1 = new Subscriber("Abhishek");
        Subscriber sub2 = new Subscriber("Ashish");
        Subscriber sub3 = new Subscriber("Ram");

        sub1.subscribeChannel(TomJerry);
        sub2.subscribeChannel(TomJerry);
        sub3.subscribeChannel(TomJerry);

        sub3.subscribeChannel(MickyMouse);
        MickyMouse.register(sub3);

        TomJerry.register(sub1);
        TomJerry.register(sub3);
        TomJerry.register(sub2);
        TomJerry.unRegister(sub3);

        TomJerry.videoDetail("Hello, Everyone");

        MickyMouse.videoDetail("Hello From MickyMouse");
    }
}