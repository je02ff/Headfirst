using Duck.Interface.Implementation;

namespace Duck.Objects;

public class ModelDuck: Duck
{
    public ModelDuck()
    {
        QuackBehavior = new NormalQuack();
        FlyBehavior = new FlyNoWay();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Model Duck");
    }
}