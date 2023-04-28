namespace AbstractFactoryPC;

public class OfficePCFactory : IPCFactory
{
    public ISpec CreatePC()
    {
        return new OfficePC();
    }
}