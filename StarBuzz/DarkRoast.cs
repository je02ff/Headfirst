namespace StarBuzz;

public class DarkRoast: IBeverage
{
    public string Description { get; init; } = "Dark Roast Coffee";
    public double Cost()
    {
        return 0.68;
    }
}