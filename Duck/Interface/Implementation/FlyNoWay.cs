namespace Duck.Interface.Implementation;

public class FlyNoWay: IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I cannot fly!");
    }
}