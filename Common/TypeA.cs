namespace Common
{

    // There are access modifiers for structs too:

    // Default is internal : only in project

    // Public is anywhere 
    public struct TypeA
    {

        // Defualt access level -> Private 
        int x;

        // Accessible inside assembly file
        internal int y;

        // Accessible anywhere 
        public int z;




        public void Print()
        {
            System.Console.WriteLine($"{x} {y} {z}");
        }



    }
}
