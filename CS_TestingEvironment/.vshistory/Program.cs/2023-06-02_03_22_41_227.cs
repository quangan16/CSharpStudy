// See https://aka.ms/new-console-template for more information
using System.Threading;

static async Task PrintFirst()
{
    
     Task.Run( () =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First");
    }
    );
    
}
static async Task PrintSecond()
{
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second");
    }
   );
    
}


await PrintFirst();
 PrintSecond();
