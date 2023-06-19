using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt.Exceptions
{
    internal class InvalidMissingEndException : Exception
    {
        public InvalidMissingEndException() { }

        public InvalidMissingEndException(string message) : base(message) { }
    }
}
