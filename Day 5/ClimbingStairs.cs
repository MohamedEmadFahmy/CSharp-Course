using System.Runtime.InteropServices;

namespace Day_5
{
    public class ClimbingStairs
    {
        // public static void Main()
        // {

        //     int n = 10;

        //     System.Console.WriteLine(ClimbStairs(n));
        // }

        // public static int ClimbStairs(int n)
        // {
        //     if (n <= 0)
        //     {
        //         return 0;
        //     }
        //     if (n == 1)
        //     {
        //         return 1;
        //     }
        //     if (n == 2)
        //     {
        //         return 2;
        //     }

        //     return ClimbStairs(n - 1) + ClimbStairs(n - 2);

        // }
        public static int ClimbStairs(int n)
        {
            int first = 0;

            int second = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = first;

                first = second;

                second += temp;
            }

            return second;

        }
    }

}

