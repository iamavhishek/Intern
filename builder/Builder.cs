namespace builder;

public class Builder
{
    private string os;
    private int battery;
    private int ram;
    private string brand;

    public Builder SetBrand(string _brand)
    {
        brand = _brand;
        return this;
    }

    public Builder SetOs(string _os)
    {
        os = _os;
        return this;
    }

    public Builder SetRam(int _ram)
    {
        ram = _ram;
        return this;
    }

    public Builder SetBattery(int _battery)
    {
        battery = _battery;
        return this;
    }

    public Phone GetPhone()
    {
        return new Phone(os, brand, battery, ram);
    }
}