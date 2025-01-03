namespace StarBuzz;

public class Whip: ICondimentDecorator
{
    private IBeverage _beverage;
    
    public string Description
    {
        get => _beverage.Description + ", Whip";
        init { }
    }

    public Whip(IBeverage beverage)
    {
        _beverage = beverage;
    }
    public double Cost()
    {
        return _beverage.Cost() + .15;
    }
}