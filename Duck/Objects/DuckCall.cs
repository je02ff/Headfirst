using Duck.Interface;
using Duck.Interface.Implementation;

namespace Duck.Objects;

public class DuckCall
{
    public IQuackBehavior QuackBehavior {get; set;} = new NormalQuack();

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }
}