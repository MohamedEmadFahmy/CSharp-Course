using System;

namespace Day_4
{
    class Employee
    {
        public int id;
        string name;
        decimal salary;

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


    }
}
