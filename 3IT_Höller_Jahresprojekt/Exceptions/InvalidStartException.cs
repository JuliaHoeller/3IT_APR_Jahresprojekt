using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt.Exceptions
{
    internal class InvalidStartException : Exception
    {
        public InvalidStartException() { }

        public InvalidStartException(string message) : base(message) { }
    }
}
