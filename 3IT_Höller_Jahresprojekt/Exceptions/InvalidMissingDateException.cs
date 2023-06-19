using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt.Exceptions
{
    internal class InvalidMissingDateException : Exception
    {
        public InvalidMissingDateException() { }

        public InvalidMissingDateException(string message) : base(message) { }
    }
}
