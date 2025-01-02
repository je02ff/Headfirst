using Duck.Interface.Implementation;

namespace Duck.Objects;

public class MallardDuck: Duck
{
    public MallardDuck()
    {
        QuackBehavior = new NormalQuack();
        FlyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Mallard Duck");
    }
}