namespace Duck.Interface.Implementation;

public class Squeak: IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak!");
    }
}