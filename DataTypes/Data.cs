using System;

namespace DataTypes
{
    class Data
    {
        public void Declare()
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // Declare an array of values
            int[] vals = new int[5];
            string[] strs = {"one", "two", "three"};

            // Declare values using formatting string
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i, f, d, b, c, str, x, z);

            // "null" mean "no value"
            object obj = null;
            Console.WriteLine(obj);

            // Implicit conversion between types
            long bigint;
            bigint = i;            

            // Explicit  conversions
            float int_to_float = (float) i;
            Console.WriteLine("{0}", int_to_float);
            int float_to_int = (int) f;
            Console.WriteLine("{0}", float_to_int);
        }
    }
}
