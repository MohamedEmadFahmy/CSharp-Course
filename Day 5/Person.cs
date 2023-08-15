using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{
    public class Person
    {
        public string Fname
        {
            get;
            set;
        }
        public string Lname
        {
            get;
            set;
        }


        public static explicit operator Person(Employee e)
        {
            System.Console.WriteLine(e.Name);
            var names = e.Name.Split(" ");

            return new Person()
            {
                Fname = names[0],
                Lname = names[1]
            };
        }

        public override string ToString()
        {
            return $"{Fname} {Lname}";
        }
    }
}