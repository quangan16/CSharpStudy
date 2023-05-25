namespace CS113;
using Vector;


class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1.1f, 4.3f);
        Vector v2 = new Vector(2.3f, 6.7f);
        // Vector v3 = v1 + v2;
        Vector v3 = v1 * v2;
        v3 = v1 * 5f;
        v3.Print();
        v3[1] = 45.6;
        Console.WriteLine(v3[1]);


    }
}
