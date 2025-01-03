namespace StarBuzz;

public class HouseBlend(string size): IBeverage
{
    public string Description { get; init; } = "House Blend Coffee";
    public string Size { get; } = size;
    public double Cost()
    {
        return 0.89;
    }
}