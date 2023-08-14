using System;

namespace Day_4
{
    class Employee : IComparable
    {
        public int id;
        string name;
        decimal salary;


        // Properties: 

        public decimal Salary
        {
            get
            {
                return salary;
            }

            internal set
            {
                salary = value;
            }
        }


        public string GetName()
        {
            return name;
        }

        internal void SetName(string _name)
        {
            name = _name;
        }

        public override string ToString()
        {
            return $"{id} {name} {salary}";
        }

        public int CompareTo(object? obj)
        {
            // Employee right = (Employee)obj;


            // // if (salary >= right.salary)
            // // {
            // //     return 1;
            // // }
            // // return -1;


            // return salary.CompareTo(right.salary);
            return 1;
        }


        public Employee(int _id, string _name, decimal _salary)
        {
            id = _id;
            name = _name;
            salary = _salary;
        }


    }
}
