using System;

namespace Practice
{
    internal class Program
    {

        static void DelayForXSecs(float seconds, string msg)
        {

            Random random = new Random();

            for (int i = 1; i <= seconds; i++)
            {
                int consoleColorAmount = Enum.GetValues(typeof(ConsoleColor)).Length;
                int randomIndex = random.Next(0, consoleColorAmount);

                ConsoleColor randomColor = (ConsoleColor)randomIndex;
                Console.ForegroundColor = randomColor;
                Console.WriteLine($"{msg, 1} {i}");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
           
           

           
            DelayForXSecs(5, "Hello");
            Console.WriteLine("Hello, World!");
        }
    }
}