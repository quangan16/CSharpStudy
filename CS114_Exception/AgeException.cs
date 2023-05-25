using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS114_Exception
{
    internal class AgeException : Exception
    {
        private int age;
        public AgeException(int _age) : base("Your age is not valid")
        {
            this.age = _age;
        }

        public void Detail()
        {
            Console.WriteLine($"Your age is {age} so it's not in the range of [10 to 65]");
        }
    }
}
