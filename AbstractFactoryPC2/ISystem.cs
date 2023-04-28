namespace AbstractFactoryPC2;

public interface ISystem
{
    IGaming gamingPC(string brand);
    IOffice officePC(string brand);
}