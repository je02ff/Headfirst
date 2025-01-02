// See https://aka.ms/new-console-template for more information

using Duck.Interface;
using Duck.Objects;

namespace Duck;

internal class MiniDuckSimulator
{
    public static void Main(string[] args)
    {
        Objects.Duck mallard = new MallardDuck();
        mallard.PerformQuack();
        mallard.PerformFly();
        
        Objects.Duck model = new ModelDuck();
        model.PerformFly();
        model.FlyBehavior = new FlyRocketPowered();
        model.PerformFly();
        
        Objects.DuckCall call = new DuckCall();
        call.PerformQuack();

    }
}
