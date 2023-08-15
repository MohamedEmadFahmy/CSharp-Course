using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{
    // to see how to create a class that allows for only 1 instance of the object to be created
    public class GCard
    {
        static GCard? singleObj;

        public int Data
        {
            get;
            protected set;
        }

        GCard(int data)
        {
            this.Data = data;
        }


        public static GCard CreateCard()
        {
            if (singleObj == null)
                singleObj = new GCard(1000);

            return singleObj;
        }




        public void DoSomeGraphics()
        {
            System.Console.WriteLine("Processing");
        }
    }
}