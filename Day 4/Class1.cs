namespace Day_4
{

    // enum Grade
    // {
    //     A, B, C, D, F
    // }


    // enum Country : byte //this specifies the data type of the id
    // {
    //     Egypt = 105, Oman = 201, USA = 221, Germany = 235, France
    // }


    // [Flags]
    // enum Permissions : byte
    // {
    //     Read = 8, Write = 4, Execute = 2, Delete = 1, RootUser = 15
    // }



    public class Class1
    {
        public static void Main()
        {

            // Grade myGrade = Grade.A;

            // myGrade = (Grade)2;

            // System.Console.WriteLine(myGrade);

            // Country c = Country.Egypt;

            // System.Console.WriteLine(c);


            // Permissions permissions = Permissions.Read;

            // // System.Console.WriteLine(permissions);

            // permissions ^= Permissions.Write;

            // // System.Console.WriteLine(permissions);

            // permissions ^= Permissions.Read;

            // // System.Console.WriteLine(permissions);

            // permissions = (Permissions)15;
            // // permissions ^= Permissions.RootUser;

            // System.Console.WriteLine(permissions);

            // if ((permissions & Permissions.Read) == Permissions.Read)
            // {
            //     System.Console.WriteLine("Can Read");
            // }
            // else
            // {
            //     System.Console.WriteLine("Can't Read");
            // }


            // Employee e = new Employee();

            // e.id = 10;

            // e.SetName("moski");



            // // use properties for the salary field:

            // e.Salary = 1000;


            // System.Console.WriteLine(e);
            // System.Console.WriteLine(e.Salary);


            PhoneBook book = new PhoneBook(8);

            book.SetEntry(0, "a", 123);
            book.SetEntry(1, "b", 456);
            book.SetEntry(2, "c", 789);

            // System.Console.WriteLine(book.GetNumber("b"));


            // Indexer:

            System.Console.WriteLine(book["a"]);

            

        }
    }
}



