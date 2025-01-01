namespace Duck.Interface.Implementation;

public class MuteQuack: IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}