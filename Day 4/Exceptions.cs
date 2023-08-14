using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_4
{
    public class Exceptions
    {
        public static void Main()
        {
            // int x, y, z;

            // try
            // {
            //     x = int.Parse(Console.ReadLine());

            //     y = Convert.ToInt32(Console.ReadLine());

            //     z = x / y;

            //     if (y < 0)
            //     {
            //         throw new NegativeNumberException();
            //     }

            //     System.Console.WriteLine(z);

            //     System.Console.WriteLine("End of code");
            // }
            // catch (Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }

            // System.Console.WriteLine("after try catch");

            // System.Console.WriteLine(Convert.ToInt32(null)); // 0

            DoSomethingCodeProtected();

        }

        public static void DoSomethingCodeProtected()
        {
            // int x, y, z;

            // int.TryParse(System.Console.ReadLine(), out x);





        }
    }
}