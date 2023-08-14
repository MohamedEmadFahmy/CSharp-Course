using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{
    public struct Employee
    {
        int id;
        string name;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }


        // Automatic property: Compiler will generate a PRIVATE arrribute and encapsulate it within this public property
        public decimal Salary
        {
            get;
            set;
        }


        public readonly decimal TaxRate
        {
            get;
        }




        public override string ToString()
        {
            return $"Name: {name} ID: {id}";
        }










    }
}