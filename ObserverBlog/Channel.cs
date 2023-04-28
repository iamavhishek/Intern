namespace ObserverBlog;

public class Channel
{
    private List<Subscriber> subs = new List<Subscriber>();
    private string title;

    public void register(Subscriber sub)
    {
        subs.Add(sub);
    }

    public void unRegister(Subscriber sub)
    {
        subs.Remove(sub);
    }

    public void notifyAll()
    {
        foreach (Subscriber user in subs)
        {
            user.update();
        }
    }

    public void videoDetail(string _title)
    {
        title = _title;
        notifyAll();
    }
}