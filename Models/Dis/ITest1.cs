namespace WebApiStudent.Models.Dis;

public interface ITest1
{
    public Guid Hello();
    
}
public class Test1:ITest1
{ 
    private readonly Guid _id;
    public Test1()
    {
        _id = Guid.NewGuid();
    }
    public Guid Hello()=> _id;
}


public interface ITest2
{
    public Guid Hello();

}
public class Test2 : ITest2
{
    private readonly Guid _id;
    public Test2()
    {
        _id = Guid.NewGuid();
    }
    public Guid Hello() => _id;
}


public interface ITest3
{
    public Guid Hello();

}
public class Test3 : ITest3
{
    private readonly Guid _id;
    public Test3()
    {
        _id = Guid.NewGuid();
    }
    public Guid Hello() => _id;
}
