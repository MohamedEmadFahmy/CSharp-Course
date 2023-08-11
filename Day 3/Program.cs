namespace Day_3
{

    // struct temp
    // {

    // }

    class Program
    {
        public static void MainV1()
        {

            // int x = 50;
            // long y = long.MaxValue;


            // // you can use checked block to check overflow while casting 
            // checked
            // {
            //     x = (int)y;  // CLR will throw an exception
            // }

            // System.Console.WriteLine($"X = {x}");
            // System.Console.WriteLine($"Y = {y}");




            // Boxing and unboxing
            // int x = 5;
            // System.Console.WriteLine(x.GetType());

            // object o = new object();

            // o = x;

            // System.Console.WriteLine(o.GetType());

            // int y = (int)o;

            // System.Console.WriteLine(y);


            // Nullable types:

            // int x = null; // doesnt work

            // int x = 50;

            // int? y;  // Nullable int y;

            // y = 5000;
            // y = null;


            // // y = x; // safe (widening casting)


            // // x = (int)y;   // unsafe

            // // Protective Programming:

            // x = y.GetValueOrDefault(0);

            // // OR

            // x = y ?? 0;


            // System.Console.WriteLine(x);


            // default keyword gives the default value for an "empty" variable

            // double d = default;

            // int[] array = default;    // null


            // for (int i = 0; array != null && i < array.Length; i++)
            // {
            //     System.Console.WriteLine($"{i}: {array[i]}");
            // }


            // another method:

            // for (int i = 0; i < array?.Length; i++)
            // {
            //     System.Console.WriteLine($"{i}: {array[i]}");
            // }

            // System.Console.WriteLine("done");


            // Employee e = default;

            // System.Console.WriteLine(e.Dept.Name); // Unsafe

            // System.Console.WriteLine(e?.Dept?.Name ?? "Not available"); // Safe

            // int[] array = { 1, 2, 3, 4, 5 };
            // int[] array = null;


            // int r = array.Length; // unsafe

            // int? r2 = array?.Length;  // safe

            // int r3 = array?.Length ?? 0;  // safe


            // System.Console.WriteLine(r);
            // System.Console.WriteLine(r2);
            // System.Console.WriteLine(r3);




            // Implicit typed local variable:
            // zay fe python / js keda
            // cant be initialized with null

            // var v = 15.3;

            // System.Console.WriteLine(v.GetType().Name);









        }
    }

    // class Dept
    // {
    //     public String Name;
    // }
    // class Employee
    // {
    //     public Dept Dept;
    // }

}
