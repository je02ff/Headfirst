namespace StarBuzz;

internal class StarBuzzCoffee
{
    public static void Main(string[] args)
    {
        IBeverage beverage = new Espresso("Small");
        Console.WriteLine(beverage.Cost());
        
        beverage = new Mocha(beverage);
        
        Console.WriteLine(beverage.Cost());
        
        beverage = new Mocha(beverage);
        
        Console.WriteLine(beverage.Cost());
        
        beverage = new Whip(beverage);
        Console.WriteLine(beverage.Description + " final cost " + beverage.Cost());
    }
}