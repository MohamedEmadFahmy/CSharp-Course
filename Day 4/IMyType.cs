using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_4
{
    interface IMyType
    {
        void FunOne();

        decimal Salary
        {
            get;

            set;
        }
    }

    struct MyType : IMyType
    {
        public decimal Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void FunOne()
        {
            throw new NotImplementedException();
        }
    }
}