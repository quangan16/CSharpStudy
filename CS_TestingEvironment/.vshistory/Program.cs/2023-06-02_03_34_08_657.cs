// See https://aka.ms/new-console-template for more information
using System.Threading;

static void Main(string[] args)
{
    var result = await PrintFirstAsync();
    Console.WriteLine(result);
    PrintSecondAsync();
    Console.ReadLine();
}

static async Task<bool> PrintFirstAsync()
{
    bool finished = false;
    await Task.Run(() =>
    {

        Thread.Sleep(2000);
        Console.WriteLine("First");
        finished = true;
    });
    return finished;
}

static async Task PrintSecondAsync()
{
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second");
    });
}


    

