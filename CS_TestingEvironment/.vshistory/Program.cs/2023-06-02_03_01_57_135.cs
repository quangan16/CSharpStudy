﻿// See https://aka.ms/new-console-template for more information
using System.Threading;

static void PrintFirst()
{
    Thread.Sleep(2000);
    Console.WriteLine("first");
}
static async void PrintSecond()
{
    Thread.Sleep(2000);
    Console.WriteLine("second");
}

PrintFirst();
PrintSecond();
