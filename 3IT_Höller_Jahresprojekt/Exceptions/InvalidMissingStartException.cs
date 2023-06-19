using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt.Exceptions
{
    internal class InvalidMissingStartException : Exception
    {
        public InvalidMissingStartException() { }

        public InvalidMissingStartException(string message) : base(message) { }
    }
}
