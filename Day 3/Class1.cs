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


            StackTrace sTrace = new StackTrace();

            StackFrame[] sFrames = sTrace.GetFrames();

            for (int i = 0; i < sFrames.Length; i++)
            {
                System.Console.WriteLine(sFrames[i].GetMethod().Name);
            }

        }

        public static void PrintLine()
        {
            FunOne();
            for (int i = 0; i < 5; i++)
            {
                System.Console.Write("#");
            }
            System.Console.WriteLine("");
        }

        public static void Main()
        {
            int x;
            System.Console.WriteLine("Enter new value: ");

            PrintLine();

            x = int.Parse(Console.ReadLine());

            System.Console.WriteLine(++x);

            PrintLine();

            System.Console.WriteLine(++x);



        }
    }
}