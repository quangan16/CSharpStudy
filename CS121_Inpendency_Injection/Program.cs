

namespace CS121_Inpendency_Injection;

//1. Without using dependency injection
class ClassA
{
    public void DoSomethingA()
    {
        ClassB instanceB = new ClassB();
        instanceB.DoSomethingB();
    }
}

//2. Using constructor dependency injection

class ClassD
{
    int id;
    ClassB instanceB;
    public ClassD() {
    }
    public ClassD(ClassB _instanceB)
    {
        instanceB = _instanceB;
        _instanceB.DoSomethingB();
        this.id = _instanceB.SetID();
        Console.WriteLine($"ClassD initialized with Id = {id}!!!");
    }
}

//3. Using setter 

class ClassE
{
    int id;
    ClassC instanceC;
}

//4. Using Interface

public interface IClass
{
    void TestingInterface();
    
}

public class ClassF: IClass
{
    public void TestingInterface() 
    {
        Console.WriteLine("This is classF");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //ClassA instanceA = new();
        //instanceA.DoSomethingA();
        ClassB instanceB = new();
        ClassD instanceD = new(instanceB);

        IClass instanceF = new();


    }
}
