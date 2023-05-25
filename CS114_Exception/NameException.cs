using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    internal class NameEmptyException : Exception
    {
        public NameEmptyException() : base("Name must not be null!!!hehe")
        {
            
        }
    }
}
