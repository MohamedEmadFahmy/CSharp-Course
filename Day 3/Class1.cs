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

        public static void MainV2()
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


            // int a = 7;
            // int b = 3;

            // Swap(a, b);

            // System.Console.WriteLine($"A: {a}");
            // System.Console.WriteLine($"B: {b}");

            // // Doesnt do anything as the a and b are passed by value so they arent actually reversed

            // System.Console.WriteLine();

            // SwapRef(ref a, ref b);
            // System.Console.WriteLine($"A: {a}");
            // System.Console.WriteLine($"B: {b}");



            // int[] array = new int[] { 1, 2, 3, 4, 5 };
            // System.Console.WriteLine(SumArray(array));
            // System.Console.WriteLine(array.GetHashCode());




            // By value: read only

            // By reference: read and write

            // By out: write first 


            int x = 3;
            int y = 8;


            // have to initialize if your passing by reference as it can be read aswell
            int sum;
            int multiply;

            SumMul(x, y, out sum, out multiply);

            System.Console.WriteLine(sum);
            System.Console.WriteLine(multiply);



            // We can ignore variables that are returned when using out:

            SumMul(10, 7, out _, out int Product);

            System.Console.WriteLine(Product);


        }

        // Value Type, Pass by value
        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }

        // Value Type, Pass by reference
        public static void SwapRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        // reference Type, Pass by value
        public static int SumArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array?.Length; i++)
            {
                sum += array[i];
            }

            System.Console.WriteLine(array?.GetHashCode());
            return sum;

        }

        public static void SumMul(int x, int y, out int sum, out int multiply)
        {
            sum = x + y;
            multiply = x * y;
        }
    }
}