namespace Duck.Interface.Implementation;

public class NormalQuack: IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}