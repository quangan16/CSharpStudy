// See https://aka.ms/new-console-template for more information
using System.Threading;


PrintFirstAsync();
PrintSecondAsync();
Console.ReadLine();
static async Task<bool> PrintFirstAsync()
{
    bool finished = false;
    await Task.Run(() =>
    {

        Thread.Sleep(2000);
        Console.WriteLine("First");
    });
}

static async Task PrintSecondAsync()
{
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second");
    });
}


    

