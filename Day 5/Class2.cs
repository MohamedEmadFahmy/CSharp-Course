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



            GCardV2 card = GCardV2.SingleToneObj;
            GCardV2 card2 = GCardV2.SingleToneObj;

            System.Console.WriteLine(card.GetHashCode());
            System.Console.WriteLine(card2.GetHashCode());












        }
    }
}