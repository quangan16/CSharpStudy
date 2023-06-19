// See https://aka.ms/new-console-template for more information
using System.Threading;

static async Task PrintFirstAsync()
{
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
        Thread.Sleep(1000);
        Console.WriteLine("Second");
    });
}

static async Task Main()
{
    await PrintFirstAsync();
    await PrintSecondAsync();
}
