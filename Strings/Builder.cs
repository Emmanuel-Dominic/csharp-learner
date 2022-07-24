using System;
using System.Text;
using System.Globalization;

namespace Strings
{
    class Builder
    {
        public void Renovate()
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "sheep"};
            
            // create a StringBuilder
            StringBuilder sb = new StringBuilder("Initial string.", 200);

            // print some basic stats about the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length};");

            // Add some strings to the builder using Append
            sb.Append("The quick brown fox ");
            sb.Append("jumped over the lazy dog ");

            // AppendLine can append a line ending
            sb.AppendLine();

            // AppendFormat can be used to append formated strings
            sb.AppendFormat("He did this {0} times.", jumpCount);
            sb.AppendLine();

            // AppendJoin can iterate over a set of values
            sb.Append("He also jumped over ");
            sb.AppendJoin(',', animals);

            // Modify the content using Replace
            sb.Replace("fox", "cat");

            // Insert content at any index
            sb.Insert(0, "This is the ");

            // Covert to a single string
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length};");
            Console.WriteLine(sb.ToString());

            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.000";

            // The Parse function
            int targetNum = 0;
            try
            {
                // Use parse to try a simple integer
                targetNum = int.Parse(numStr1);
                Console.WriteLine(targetNum);

                // Use Parse to try a floating point number, this only works if the decimal value is 0
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine(targetNum);

                // use Parse to try a number with thousands marker
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);
                
                // Use Parse to try a number with thousands marker AND decimal
                targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);
                
                // This works with other types too, like bool
                Console.WriteLine($"{bool.Parse("True")}");

                // Or floating point numbers
                Console.WriteLine($"{float.Parse("1.235"):F2}");
            }
            catch {
                Console.Write("Conversion failed");
            }

            // The TryParse function is similar but handles the exceptions for us
            bool succeeded = false;
            succeeded = Int32.TryParse(numStr1, out targetNum);
            if(succeeded) {
                Console.WriteLine($"{targetNum}");
            }
        }
    }
}
