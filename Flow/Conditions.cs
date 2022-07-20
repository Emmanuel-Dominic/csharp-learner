using System;

namespace Flow
{
    class Conditions
    {
        public void Checker()
        {
            // if-else statement
            int num = 10;
            if (num == 10) {
                Console.WriteLine("num is equal to 10! - (if-else)");
            }else if (num > 10 && num < 20) {
                Console.WriteLine("num is between 10 and 20! - (if-else)");
            }else{
                Console.WriteLine("num is something else! - (if-else)");
            }

            // using ternary operator ?:
            Console.WriteLine(num < 10 ? "num is smaller than 10" : "num is larger than 10");

            // using switch statement
            switch(num) {
                case 10:
                    Console.WriteLine("num is equal to 10! - (switch-case)");
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("num is between 10 and 15! - (switch-case)");
                    break;
                default:
                    Console.WriteLine("num is something else! - (switch-case)");
                    break;
            }
        }
    }
}
