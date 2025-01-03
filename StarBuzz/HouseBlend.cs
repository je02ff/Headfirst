namespace StarBuzz;

public class HouseBlend: IBeverage
{
    public string Description { get; init; } = "House Blend Coffee";
    public double Cost()
    {
        return 0.89;
    }
}