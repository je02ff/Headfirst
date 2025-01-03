namespace StarBuzz;

public class Espresso: IBeverage
{
    public string Description { get; init; } = "Espresso"; 
    
    public double Cost()
    {
        return 1.99;
    }
}