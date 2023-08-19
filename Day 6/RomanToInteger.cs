using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_6
{
    public class RomanToInteger
    {
        public static void Main()
        {
            // String s = "III";
            // String s = "III";
            String s = "IV";
            System.Console.WriteLine(RomanToInt(s));


        }
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> Pairs = new Dictionary<char, int>();

            Pairs.Add('I', 1);
            Pairs.Add('V', 5);
            Pairs.Add('X', 10);
            Pairs.Add('L', 50);
            Pairs.Add('C', 100);
            Pairs.Add('D', 500);
            Pairs.Add('M', 1000);

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && Pairs[s[i]] < Pairs[s[i + 1]])
                {
                    result -= Pairs[s[i]];
                }
                else
                {
                    result += Pairs[s[i]];
                }
            }

            return result;
        }
    }
}