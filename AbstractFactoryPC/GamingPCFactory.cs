namespace AbstractFactoryPC;

public class GamingPCFactory : IPCFactory
{
    public ISpec CreatePC()
    {
        return new GamingPC();
    }
}