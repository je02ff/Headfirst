// See https://aka.ms/new-console-template for more information

namespace Duck;

internal class MiniDuckSimulator
{
    public static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.PerformQuack();
        mallard.PerformFly();
    }
}
