using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Day_5
{
    public class Class2
    {
        public static void Main()
        {

            // Utility u1 = new Utility(10, 20);
            // Utility u2 = new Utility(15, 40);

            // System.Console.WriteLine(Utility.InchtoCm(10));

            // System.Console.WriteLine(Utility.CircleArea(10));



            // GCard card = GCard.CreateCard();
            // GCard card2 = GCard.CreateCard();

            // System.Console.WriteLine(card.GetHashCode());
            // System.Console.WriteLine(card2.GetHashCode());



            // GCardV2 card = GCardV2.SingleToneObj;
            // GCardV2 card2 = GCardV2.SingleToneObj;

            // System.Console.WriteLine(card.GetHashCode());
            // System.Console.WriteLine(card2.GetHashCode());



            // Operator overloading

            Complex c1 = new Complex() { Real = 10, Imaginary = 15 };

            Complex c2 = new Complex() { Real = 30, Imaginary = 6 };



            Complex c3 = c1 + c2;

            Complex c4 = c1 + 7;


            // unary - operator
            c1 = -c2;



            c3 = ++c1;
            c4 = c2++;

            int x = c1;

            string text = (string)c3;


            // System.Console.WriteLine(c1);
            // System.Console.WriteLine(c2);
            // System.Console.WriteLine(c3);
            // System.Console.WriteLine(c4);

            // System.Console.WriteLine("-------------");
            // System.Console.WriteLine(x);
            // System.Console.WriteLine(text);


            Employee e = new Employee()
            {
                ID = 101,
                Name = "talal ahmed",
                Salary = 10_000
            };

            Person p = (Person)e;

            System.Console.WriteLine(p);











        }
    }
}