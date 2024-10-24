using System;

namespace Functions
{
    class Basics
    {
        public void Run()
        {
            // Functions are used to group re-usable code together in a single unit that can be customized with parameters.

            // Functions have a return type, name, and optional parameters
            float MilesToKm(float miles) {
                float result = miles * 1.6f;
                return result;
            }
            // A function with no return value has a void type
            void PrintWithPrefix(string theStr) {
                Console.WriteLine($"::> {theStr}");
            }
            // call first function
            Console.WriteLine($"The result is {MilesToKm(8.0f)}");
            Console.WriteLine($"The result is {MilesToKm(52.0f)}");
            // Call second function
            PrintWithPrefix("Test string");
            PrintWithPrefix("Another test string");
            // Functions can provide default values for their parameters
            void PrintWithDefaultPrefix(string theStr, string prefix="") {
                Console.WriteLine($"{prefix} {theStr}");
            }
            // Test the default parameters
            PrintWithDefaultPrefix("Hello there!");
            PrintWithDefaultPrefix("Hello there!", "%");
            //Call with named params
            PrintWithDefaultPrefix(prefix: ">:", theStr: "Hello Dom");
        }
    }
}
