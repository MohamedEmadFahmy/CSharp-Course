using System.ComponentModel;
using Common;

namespace Day_3
{

    enum Grades
    {
        A,
        B,
        C,
        D,
        F
    }


    public class Class2
    {
        public static void Main()
        {

            // Allocation of 8 uninitialized bytes in stack
            Point p = new Point(3, 4);

            System.Console.WriteLine(p);

            Point p2 = new Point(10);

            System.Console.WriteLine(p2);

            Point p3 = new Point();

            System.Console.WriteLine(p3);

            Grades myGrades = Grades.A;

        }
    }
}