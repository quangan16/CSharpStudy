// See https://aka.ms/new-console-template for more information
using System.Threading;

public class Program
{
    public static void Main()
    {
        int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Value is " + array[2, 1]);
        Console.Read();

    }
}

public class Customer
{
    private string name;

    public Customer(string name)
    {
        this.name = name;
    }
}