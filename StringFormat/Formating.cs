using System;

namespace StringFormat
{
    class Formating
    {
        public void Excute()
        {
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};

            // Length of a string
            Console.WriteLine(str1.Length);

            // Access individual characters
            Console.WriteLine(str1[14]);

            //Iterate over a string like any other sequence of values
            foreach (char ch in str1) {
                Console.Write(ch);
                if (ch == 'b') {
                    Console.WriteLine();
                    break;
                }
            }

            // String concatenation
            outstr = String.Concat(strs);
            Console.WriteLine(outstr);

            // Joining strings together with Join
            outstr = String.Join('.', strs);
            Console.WriteLine(outstr);

            // String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            int result = String.Compare(str2, "This is a string");
            Console.WriteLine(result);

            // Eqquals just returns a regular boolean
            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            // String searching
            Console.WriteLine(str1.IndexOf('e'));
            Console.WriteLine(str1.IndexOf("fox"));

            Console.WriteLine(str1.LastIndexOf('e'));
            Console.WriteLine(str1.LastIndexOf("the"));

            outstr = str1.Replace("fox", "cat");
            Console.WriteLine(outstr);
            Console.WriteLine(outstr.IndexOf("fox"));

            int[] quarters = {1, 2, 3, 4};
            int[] sales = {100000, 150000, 200000, 225000};
            double[] intIMixPct = {.386, .413, .421, .457};
            string str4 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic formatting information
            Console.WriteLine("{0}", str4);

            // Specifying Numerical formatting, General format is {index[,alignment]:[format]}
            // Common types are N (Number), G (General), F (Fixed-point), E (Exponential), D (Decimail),
            // P (Percent), X (Hexadecimal), C (Currency in local format)
            Console.WriteLine("{0:D} {0:N} {0:F} {0:G}", val1);
            Console.WriteLine("{0:E} {0:N} {0:F} {0:G}", val2);

            // Add a number after the format to specify precision
            Console.WriteLine("{0:D6} {0:N2} {0:F1} {0:G3}", val1);

            //Formatting with alignment and spacing
            Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", quarters[0], quarters[1], quarters[2], quarters[3]);
            Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", sales[0], sales[1], sales[2], sales[3]);
            Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}", intIMixPct[0], intIMixPct[1], intIMixPct[2], intIMixPct[3]);

            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // Output information using formatting
            Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and cost ${4}", year, make, model, miles, price);
            
            // Using string interpolation
            Console.WriteLine($"This car is a {year} {make} {model}, with {{{miles}}} miles and cost ${price:C2}");

            // With inline expressions
            Console.WriteLine($"This car is a {year} {make} {model}, with {miles * 1.6:F2} km and cost ${price:C2}");
        }
    }
}
