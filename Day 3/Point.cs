namespace Day_3
{
    struct Point
    {
        int x;
        int y;


        public Point(int _x, int _y)
        {
            // ANY userdefied constructor in struct

            x = _x;
            y = _y;
        }

        public Point(int n)
        {
            x = y = n;

        }

        public Point()
        {
            x = y = -1;
        }



        public override string ToString()
        {
            return $"({x}, {y})";
        }

    }

}

