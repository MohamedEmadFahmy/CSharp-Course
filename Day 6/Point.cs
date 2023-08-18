using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Day_6
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }


        // public override bool Equals(object? obj)
        // {
        //     // Point right = (Point)obj; // unsafe casting between reference types


        //     // (is) keyword returns false if casting fails


        //     // if (obj is Point)
        //     // {
        //     //     Point right = (Point)obj;
        //     //     return this.x == right.x && this.y == right.y;
        //     // }

        //     // this can be simplified to:
        //     // if (obj is Point right)
        //     // {
        //     //     return this.x == right.x && this.y == right.y;
        //     // }



        //     // Point right = obj as Point;   // as returns null if casting fails, no exceptions thrown

        //     // if (right == null)
        //     // {
        //     //     return false;
        //     // }


        //     // if (this.GetType() != obj.GetType())
        //     // {
        //     //     return false;
        //     // }

        //     // if (object.ReferenceEquals(this, right))
        //     // {
        //     //     return true;
        //     // }


        //     // return this.x == right.x && this.y == right.y;




        //     // return false;




        // }



        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}