public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public interface ISleepable
{
    void Sleep();
}

public class HumanWorker : IWorkable, IEatable, ISleepable
{
    public void Work() { /*...*/ }
    public void Eat() { /*...*/ }
    public void Sleep() { /*...*/ }
}

public class RobotWorker : IWorkable
{
    public void Work() { /*...*/ }
}
