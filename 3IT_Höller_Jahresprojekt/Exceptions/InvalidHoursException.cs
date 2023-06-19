using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt.Exceptions
{
    internal class InvalidHoursException : Exception
    {
        public InvalidHoursException() { }

        public InvalidHoursException(string message) : base(message) { }
    }
}
