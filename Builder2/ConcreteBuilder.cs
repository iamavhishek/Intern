namespace Builder2;

public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPart1()
    {
        _product.BuildMobile = "Mobile is being build";
    }

    public void BuildPart2()
    {
        _product.BuildMonitor = "Monitor is being build";
    }

    public void BuildPart3()
    {
        _product.BuildCpu = "CPU is being build";
    }

    public Product GetProduct()
    {
        return _product;
    }
}