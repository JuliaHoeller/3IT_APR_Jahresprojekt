using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt.Exceptions
{
    internal class InvalidIDException : Exception
    {
        public InvalidIDException() { }

        public InvalidIDException(string message) : base(message) { }
    }
}
