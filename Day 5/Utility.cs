using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{
    public class Utility
    {
        public int x
        {
            get;
            set;
        }
        public int y
        {
            get;
            set;
        }


        // Static attributes allocate in heap before first usage till end of the program
        public static double pi;




        // Constructor isnt a good place to initialize static attributes

        public Utility(int x, int y)
        {
            this.x = x;
            this.y = y;
            System.Console.WriteLine("ctor");
        }


        // So we use the static constructor:
        // will be excuted only once per class lifetime
        // can tspecify return data type, acces modifier, or input parameters
        static Utility()
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