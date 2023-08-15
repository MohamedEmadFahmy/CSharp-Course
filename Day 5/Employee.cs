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
        private int v1;
        private string v2;
        private int v3;

        public Employee(int v1, string v2, int v3) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

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