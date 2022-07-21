using System;

namespace Flow
{
    class Loops
    {
        public void Iterate()
        {
            int num = 15;
            int[] nums = new int[] {3, 14, 16, 92, 8};
            string str = "The quick brown fox jumps over the lazy dog";

            // The basic for loop.
            for(int i=0; i < num; i++) {
                Console.WriteLine("i is currently {0}", i);
            }

            // The foreach-in loop can be used to iterate over sequences
            foreach (int i in nums) {
                Console.WriteLine(i);
            }
            // count number of O's in str
            var count = 0;
            foreach (char c in str) {
                if (char.ToLower(c) == 'o') // for string we call method off variable ie str.ToLower()
                {
                    count ++;
                }
            }
            Console.WriteLine("Counted {0} o characters", count);

            // basic while loop which executes while the gate condition is true
            string inputStr = "";
            while (inputStr != "exit") {
                inputStr = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputStr);
            }

            // the do-while loop always executes at least one time at runtime before making a check.
            do {
                inputStr = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputStr);
            } while(inputStr != "stop");

            // using break and continue
            int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};
            foreach (int val in values) {
                // The continue statement skips the rest of the loop entirely and jumps to the next iteration (if there is one)
                if(val >= 20 && val <= 29) {
                    continue; // this skips the below code to the next value, thats why 23 wont be printed
                }

                // print the value
                Console.WriteLine($"val is currently {val}");

                // The break statement stops the loop and exits
                if(val >=40) {
                    break; // integers after 41 wont be printed
                }               
            }
        }
    }
}
