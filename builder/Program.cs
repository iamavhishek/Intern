namespace builder;

public class Program
{
    public static void Main(string[] args)
    {
        Phone phone = new Builder().SetBattery(4000).SetBrand("Samsung").SetOs("Windows").SetRam(5).GetPhone();
        Console.WriteLine(phone.ToString());
    }
}