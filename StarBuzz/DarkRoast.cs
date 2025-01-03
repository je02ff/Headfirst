namespace StarBuzz;

public class DarkRoast(string size) : IBeverage
{
    public string Description { get; init; } = "Dark Roast Coffee";
    public string Size { get; } = size;

    public double Cost()
    {
        return Size == "Small" ? 1.00 : 2.00;
    }
}