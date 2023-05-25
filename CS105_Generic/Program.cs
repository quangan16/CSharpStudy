namespace Generic_Example;
class Program
{
    static void Swap<T>(ref T x,ref T y)
    {
        T temp;
        temp = x;
        x = y;
        y = temp;
    }

   

    static void Main(string[] args)
    {
        //int a = 5;
        //int b = 20;

        //float c = 16;
        //float d = 100;

        ////Console.WriteLine($"a = {a}, b = {b}");
        ////Swap(ref a,ref b);
        ////Console.WriteLine($"a = {a}, b = {b}");


        //Console.WriteLine($"c = {c}, c = {d}");
        //Swap(ref c, ref d);
        //Console.WriteLine($"c = {c}, c = {d}");

        Product<int> phone1 = new Product<int>();
        phone1.SetID(123);
        phone1.printInfo();

        Product<string> phone2 = new Product<string>();
        phone2.SetID("321");
        phone2.printInfo();

        List<int>
    }


}

class Product<T>
{
    private T ID;
    public void SetID(T value)
    {
        this.ID = value;
    }

    public T GetID()
    {
        return this.ID;
    }
        public void printInfo()
    {
        Console.WriteLine($"Player's ID: {this.GetID()}");
    }
    

}
