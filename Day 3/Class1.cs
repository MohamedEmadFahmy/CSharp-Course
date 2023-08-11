using System.Diagnostics;

namespace Day_3
{
    public class Class1
    {
        public static void FunOne()
        {
            FunTwo();
        }

        public static void FunTwo()
        {
            // System.Console.WriteLine("Fun Two");


            // StackTrace sTrace = new StackTrace();

            // StackFrame[] sFrames = sTrace.GetFrames();

            // for (int i = 0; i < sFrames.Length; i++)
            // {
            //     System.Console.WriteLine(sFrames[i].GetMethod().Name);
            // }

        }

        public static void PrintLine(int n = 5, string pattern = "x")
        {
            FunOne();
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(pattern);
            }
            System.Console.WriteLine("");
        }

        public static void Main()
        {
            // int x;
            // System.Console.WriteLine("Enter new value: ");

            // PrintLine(3, "-_-");

            // // x = int.Parse(Console.ReadLine());

            // // System.Console.WriteLine(++x);

            // PrintLine(5, "#");

            // // System.Console.WriteLine(++x);


            // // You can also reverse the order of passed parameters using this syntax:

            // PrintLine(pattern: "| ", n: 4);

            // PrintLine(pattern: "& "); // n is 5 by default


            int a = 7;
            int b = 3;

            Swap(a, b);

            System.Console.WriteLine($"A: {a}");
            System.Console.WriteLine($"B: {b}");

            // Doesnt do anything as the a and b are passed by value so they arent actually reversed




        }
        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
    }
}