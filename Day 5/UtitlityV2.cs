using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{

    // Container to only static members
    // No objects can be created from this class
    // we can define the whole class as static
    // no inheritance
    public static class UtilityV2
    {
        public static double pi;


        static UtilityV2()
        {
            System.Console.WriteLine("static constructor");
            pi = 3.14;
        }

        public static double CmtoInch(double cm)
        {
            return cm / 2.54;
        }

        public static double InchtoCm(double inch)
        {
            return inch * 2.54;
        }
        public static double CircleArea(double r)
        {
            return pi * r * r;
        }
    }
}