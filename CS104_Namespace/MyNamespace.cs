using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class Class1
    {
        public static void Hello()
        {
            WriteLine("Hello, World!");
        }
    }
    namespace ABC
    {
        internal class Class1
        {
            public static void Hello()
            {
                WriteLine("Hello, World 2!");
            }
        }
    }
   
}
