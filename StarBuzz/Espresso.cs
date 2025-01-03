namespace StarBuzz;

public class Espresso(string size) : IBeverage
{
    public string Description { get; init; } = "Espresso";
    public string Size { get; } = size;

    public double Cost()
    {
        return Size == "Small" ? 1.00 : 2.00;
    }
}