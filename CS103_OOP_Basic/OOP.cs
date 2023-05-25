/*
 * Tinh ke thua trong c#
 */

//Cat c = new Cat("Abc");
//c.ShowLegs();

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal initialized!");
    }
    public Animal(string abc)
    {
        Console.WriteLine("Animal initialized 2");
    }
    public int Legs { set; get; }
    public float Weight { set; get; }
    protected void ShowLegs()
    {
        Console.WriteLine("Chan");
    }
}



class Cat : Animal
{
    public string Food;
    public Cat(string s) : base(s)
    { 
        this.Legs = 4;
        this.Weight = 10f;
        this.Food = "Mouse";
        Console.WriteLine(s);

    }
    public new void ShowLegs()
    {
        base.ShowLegs();
        Console.WriteLine($"Loai meo co so chan la {Legs}");
    }
}


//________________________________________________

class A
{

}

class B : A 
{

}

class C : B
{

}

class Program
{
    static void Main(String[] args)
    {
        A a;
        B b;
        C c;

        b = new B();
        c = new C();
        a = b;
        //c = b;

    } 
}

