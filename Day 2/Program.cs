
using System.Data;
namespace Day_2
{
    class Program
    {
        public static void Main()
        {
            // #region Value Type
            // int x;
            // x = 3;
            // int y = x;
            // x++;
            // // System.Console.WriteLine(x);
            // // System.Console.WriteLine(y);
            // #endregion

            // #region Reference Type

            // object o1 = new object();
            // System.Console.WriteLine(o1.GetHashCode());

            // object o2 = new object();

            // System.Console.WriteLine(o2.GetHashCode());

            // o2 = o1;

            // System.Console.WriteLine(o2.GetHashCode());
            // #endregion

            // #region speed testing
            // int j = 0;

            // for (long i = 0; i <= 1_000_000_000; i++)
            // {
            //     if (j == 1_000_000)
            //     {
            //         System.Console.WriteLine(i);
            //         j = 0;
            //     }
            //     j++;
            // }                
            // #endregion

            // float var = 15.3f;

            // System.Console.WriteLine(var);


            // int x, y;


            // System.Console.WriteLine("Enter x: ");
            // x = int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Enter y: ");
            // y = Convert.ToInt32(Console.ReadLine());

            // string message = String.Format("The result of {0} + {1} is {2}", x, y, x + y);

            // System.Console.WriteLine(message);

            //Called automatically
            // System.Console.WriteLine("The result of {0} + {1} is {2}", x, y, x + y);


            //  we can do this better

            // Currency
            // System.Console.WriteLine($"The sum of {x} and {y} is {x + y:C}");


            // Hexadecimal
            // System.Console.WriteLine($"The sum of {x} and {y} is {x + y:X}");

            // to print a variable that takes up a fixed amount of space
            // System.Console.WriteLine($"The sucm of {x,5} and {y,5} is {x + y,5}");


            // int x = 1;

            // if (x == 1)
            //     System.Console.WriteLine("Jan");
            // else if (x == 2)
            //     System.Console.WriteLine("Feb");
            // else if (x == 3)
            //     System.Console.WriteLine("March");
            // else if (x == 1)
            //     System.Console.WriteLine("Second Jan");
            // else
            //     System.Console.WriteLine("Not in Q1");


            // string x = "A";

            // switch (x)
            // {
            //     case "A":
            //         System.Console.WriteLine("true");
            //         break;
            //     default:
            //         System.Console.WriteLine("false");
            //         break;

            // }


            // You can add brackets fel tayer to define a block scope

            int x = 3;

            {
                x = 3;
            }

            x = 5;


        }
    }
}