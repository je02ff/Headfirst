namespace StarBuzz;

public class Mocha: ICondimentDecorator
{
    private IBeverage _beverage;

    public string Description
    {
        get => _beverage.Description + ", Mocha";
        init { }
}

    public double Cost()
    {
        return _beverage.Cost() + 0.25;
    }

    public Mocha(IBeverage beverage)
    {
        _beverage = beverage;
    }
}