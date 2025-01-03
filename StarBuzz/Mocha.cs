namespace StarBuzz;

public class Mocha: ICondimentDecorator
{
    private IBeverage _beverage;

    public string Description
    {
        get => _beverage.Description + ", Mocha";
    }   

    public string Size { get; }

    public double Cost()
    {
        return _beverage.Cost() + (_beverage.Size == "Small" ? 0.25 : 0.50);
    }

    public Mocha(IBeverage beverage)
    {
        _beverage = beverage;
    }
}