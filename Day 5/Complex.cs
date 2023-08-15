using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{


    // Operator Overloading
    public class Complex
    {
        public int Real
        {
            get;
            set;
        }
        public int Imaginary { get; set; }


        // Operator overloading:
        //  Must be static member methods
        //  cant overload [] or = 


        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) + (right?.Imaginary ?? 0)
            };
        }
        public static Complex operator +(Complex left, int right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + right,
                Imaginary = (left?.Imaginary ?? 0)
            };
        }

        public static Complex operator -(Complex c)
        {
            return new Complex
            {
                Real = -c.Real,
                Imaginary = -c.Imaginary
            };
        }




        //  Cater for both prefix and postfix notations
        public static Complex operator ++(Complex c)
        {
            return new Complex
            {
                Real = c.Real + 1,
                Imaginary = c.Imaginary + 1
            };
        }


        //  comparison operators come in pairs so we have to define > AND <
        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imaginary > right.Imaginary;
            return left.Real > right.Real;

        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imaginary < right.Imaginary;
            return left.Real < right.Real;

        }



        // override casting operators:


        public static implicit operator int(Complex c)
        {
            return c?.Real ?? 0;

        }

        public static explicit operator string(Complex c)
        {
            return c?.ToString() ?? "NA";

        }









        public override string ToString()
        {
            return $"{Real} + {Imaginary}j";
        }

    }
}