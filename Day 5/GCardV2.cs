using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{
    public class GCardV2
    {
        static GCardV2 singleObj;

        public int Data
        {
            get;
            protected set;
        }

        GCardV2(int data)
        {
            this.Data = data;
        }



        // BAD C# way of doing the same thing 

        // static GCardV2()
        // {
        //     singleObj = new GCardV2(100);
        // }

        // public static GCardV2 CreateCard()
        // {
        //     return singleObj;
        // }



        // THE BEST WAY:
        public static GCardV2 SingleToneObj
        {
            get;
        } = new GCardV2(1000);




        public void DoSomeGraphics()
        {
            System.Console.WriteLine("Processing");
        }
    }
}