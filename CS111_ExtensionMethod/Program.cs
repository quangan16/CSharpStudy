using DC;

namespace CS111_ExtensionMethod;


static class StringManipulator
{
    public static void Print(this string msg, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(msg);
        Console.ResetColor();
    }
}

class Program
{
    

    static void Main(string[] args)
    {
        //string s = "Ann pro";
        //s.Print( ConsoleColor.Cyan);
        //s.Print( ConsoleColor.Green);

        //"Xin"?.Print(ConsoleColor.Magenta);
        //"Chao"?.Print(ConsoleColor.DarkBlue);

        double x = 5.89;
        //double res = x.Divide(1.3);
        //double res = x.Pow();
        double res = x.Sin();
        Console.WriteLine(res);
    }
}
