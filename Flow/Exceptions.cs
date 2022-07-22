using System;

namespace Flow
{
    class Exceptions
    {
        public void Catch()
        {
            int x = 100;
            int y = 0;
            int result;

            // try-catch expressions make error checking easier
            try{
                if (x > 1000) {
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
                }
                result = x/y; // System.DivideByZeroException: Attempted to divide by zero
                Console.WriteLine($"The result is: {result}");
            }catch(DivideByZeroException e){
                Console.WriteLine("Can't divide by zero!");
                Console.WriteLine(e.Message);
            }catch(ArgumentOutOfRangeException e){
                Console.WriteLine("Sorry, 1000 is the limit!");
                Console.WriteLine(e.Message);               
            }catch {
                Console.WriteLine("Something else!");                
            }finally{
                Console.WriteLine("This code is always going to run!");
            }
        }
    }
}
