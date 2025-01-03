namespace StarBuzz;

public interface IBeverage
{
    String Description { get; }
    String Size { get; }

    public double Cost();
}