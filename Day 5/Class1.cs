using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Day_5
{
    public class Class1
    {
        public static void Main()
        {

            // Employee e = new Employee();

            // e.ID = 1;
            // e.Name = "moski";
            // e.Salary = 3000;


            // Employee e2 = new Employee()
            // {
            //     ID = 2,
            //     Name = "emad",
            //     Salary = 5000
            // };


            // System.Console.WriteLine(e);
            // System.Console.WriteLine(e2);

            // Car c = new Car(1, "BMW", 80);
            // System.Console.WriteLine(c);

            Car c2 = new Car(12);
            System.Console.WriteLine(c2);


            // how to create a NEW object nos5a men object tany

            // 1) Copy Constructor:

            // Car c3 = new Car(c2);
            // System.Console.WriteLine(c3);



            // 2) Clone:

            Car c3 = (Car)c2.Clone();



            // System.Console.WriteLine(c2.GetHashCode());
            // System.Console.WriteLine(c3.GetHashCode());




        }
    }

}

