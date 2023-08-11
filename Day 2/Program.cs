
using System.Data;
using System.Diagnostics;

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
            // {
            //     int x = 3;
            //     System.Console.WriteLine(x);
            // }

            // {
            //     int x = 5;
            //     System.Console.WriteLine(x);

            // }


            // Arrays:

            // int[] myArr; // 0 bytes have been allocated so far


            // myArr = new int[5];
            // int[] myArr = { 2, 3, 1, 5, 4 };

            // // System.Console.WriteLine(myArr.ToString());

            // System.Console.WriteLine(ToString(myArr));

            // Array.Sort(myArr);

            // System.Console.WriteLine(ToString(myArr));


            // int[,] marks = new int[3, 5];
            // int[,] marks = { { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };

            // for (int i = 0; i < marks.GetLength(0); i++)
            // {
            //     for (int j = 0; j < marks.GetLength(1); j++)
            //     {
            //         System.Console.Write(marks[i, j] + " ");
            //     }
            //     System.Console.WriteLine();
            // }

            int[] array = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            // System.Console.WriteLine(LongestDistance(array));

            // ReverseWords("this is a test");

            Stopwatch sw = new Stopwatch();

            sw.Start();

            CountOnes();

            sw.Stop();

            System.Console.WriteLine(sw.Elapsed);


        }

        public static string ToString(int[] array)
        {
            String result = "[";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
                if (i != array.Length - 1)
                {
                    result += ", ";
                }
            }
            result += "]";
            return result;
        }
        public static int LongestDistance(int[] array)
        {
            int max = -1;

            for (int i = 0; i < array.Length; i++)
            {
                int secondIndex = -1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        secondIndex = j;
                    }
                }
                if (secondIndex != -1 && secondIndex - i - 1 > max)
                {
                    max = secondIndex - i - 1;
                }
            }

            return max;
        }

        public static void ReverseWords(string text)
        {
            string[] wordArray = text.Split(" ");

            Array.Reverse(wordArray);

            string result = String.Join(" ", wordArray);

            System.Console.WriteLine(result);
        }

        public static void CountOnes()
        {
            int count = 0;

            for (int i = 1; i <= 20; i++)
            {
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    int digit = currentNumber % 10;
                    if (digit == 1)
                    {
                        count++;
                    }
                    currentNumber /= 10;
                }
            }
            System.Console.WriteLine(count);
        }
    }
}