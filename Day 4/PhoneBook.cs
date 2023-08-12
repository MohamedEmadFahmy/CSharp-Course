using System;

namespace Day_4
{
    public struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public int Size
        {
            get
            {
                return size;
            }
        }

        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }


        public void SetEntry(int index, string name, long number)
        {
            if (index >= 0 && index < size)
            {
                names[index] = name;
                numbers[index] = number;
            }
        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < names?.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }
            return -1;
        }


        // Indexer:

        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names?.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names?.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                    }
                }
            }
        }



        // You can also use with more than one parameter
        public long this[int index, string name]
        {
            set
            {
                if (index >= 0 && index < size)
                {
                    names[index] = name;
                    numbers[index] = value;
                }
            }
        }


    }
}
