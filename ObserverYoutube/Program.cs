using System.Threading.Channels;

namespace ObserverYoutube;

public class Program
{
    public static void Main(string[] args)
    {
        var channel1 = new ChannelOne("Tom & Jerry");
        var channel2 = new ChannelTwo("Micky Mouse");

        IObserver user1 = new User("Abhishek");
        IObserver user2 = new User("Ashish");
        IObserver user3 = new User("Sita");

        channel1.RegisterObserver(user1);
        channel2.RegisterObserver(user2);
        channel1.RegisterObserver(user3);

        channel1.UploadVideo("Hello, from Tom and Jerry");
        channel2.UploadVideo("Hello, from Micky Mouse");
    }
}