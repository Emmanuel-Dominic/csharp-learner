using System;

namespace Functions
{
    class RefAndParam
    {
        // Ordinary value arguments cannot be modified by the function because they are a copy of the original value
        public static void TestFunc1(int arg1) {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }

        // Arguments that are passed by reference can be modified by the function or reflected back to the caller.
        public static void TestFunc2(ref int arg1) {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }

        // The "out" keyword means that the parameter returns a value and isnt used to supply data to the function.
        static void PlusTimes(int arg1, int arg2, out int sum, out int product) {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }

        public void Run()
        {
            int val1 = 10;
            int val2 = 20;

            // Function dont normally modify value arguments
            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            // Using the "ref" keyword, arguments can be passed by reference which allows the function to modify them
            TestFunc2(ref val1);
            Console.WriteLine($"ref: {val1}");

            // The "out" keyword can be used to indicate that an argument is intended to return a value and isnt an input
            int a, b;
            PlusTimes(val1, val2, out a, out b);
            Console.WriteLine($"out: {a} {b}");
        }
    }
}
