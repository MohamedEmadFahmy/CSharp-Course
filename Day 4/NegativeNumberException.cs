using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_4
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("Number is negative")
        {

        }
    }
}