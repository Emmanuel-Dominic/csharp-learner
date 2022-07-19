using System;

namespace Operators
{
    class Logic
    {
        public void Run()
        {
            // Declare some variables to exercies the operators
            int x=10, y=5;
            string a="abcd", b="efgh";
            // Basic math operators are +, -, /, *
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);

            // Increment/Decrement operators | shorthand
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // Operators can be shorthand: a = a + b
            a += b;
            Console.WriteLine(a);

            // Logical operators &&, ||
            Console.WriteLine(x > y && y >= 5); // x is greater then y but y isn't greater or equal to 5 because line 18 y=4
            Console.WriteLine(x > y || y >= 5); // x is greater then y

            // null-coalescing operators | string str = null;
            // the ?? operator uses left operand if not null, or right one if it is
            string str = null;
            Console.WriteLine(str ?? "Unknown string");

            // the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (varaible is null) {
            //     variable = somevalue
            // }
            str ??= "New string";
            Console.WriteLine(str);
        }
    }
}
