// See https://aka.ms/new-console-template for more information
using System.Threading;

static async void PrintFirst()
{
    
    await Task.Run( () =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First");
    }
    );
    
}
static async void PrintSecond()
{
    await Task.Run(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Second");
    }
   );
    
}

PrintFirst();
PrintSecond();
