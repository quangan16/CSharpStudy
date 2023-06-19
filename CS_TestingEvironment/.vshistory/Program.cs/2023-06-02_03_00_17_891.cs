// See https://aka.ms/new-console-template for more information
using System.Threading;

static void PrintFirst()
{
    Thread.Sleep(5000); 
    Console.WriteLine("first");
}
static void PrintSecond()
{
    Console.WriteLine("second");
}

PrintFirst();
PrintSecond();
