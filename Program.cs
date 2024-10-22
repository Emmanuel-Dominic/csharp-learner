using System;
using HelloWorld;
using DataTypes;
using Operators;
using Flow;
using StringFormat;
using Strings;
using Functions;
using Classes.Defining;
using Classes.Inheritance;

namespace csharp_learner
{
    class Program
    {
        /// XML Comment used to help provide documentation, with the below syntax
        /// for more visit: https://docs.microsoft.com/en-us/dotnet/csharp/codedoc
        /// <summary>
        /// This is the main application function
        /// </summary>
        /// <param name="args">An array of string arguments from the command line</param>
        /// <returns>
        /// No return value
        /// </returns>
        static void Main(string[] args)
        {
            /*
                (This is a multi-line comment) this program with various declarations
                of objects for the various piece of code from different files.
            */

            // (single-line comment) The helloworld - object
            Greeting greet = new Greeting();
            greet.GreetUser();
            // (single-line comment) The different datatypes/variables - object
            Data data = new Data();
            data.Declare();
            // (single-line comment) The use of operators - object
            Logic logic = new Logic();
            logic.Run();
            // (single-line comment) The condition statement - object
            Conditions condition = new Conditions();
            condition.Checker();
            // (single-line comment) The loop statement - object
            Loops loop = new Loops();
            loop.Iterate();
            // (single-line comment) The exception handling - object
            Exceptions exceptions = new Exceptions();
            exceptions.Catch();
            // (single-line comment) The string formating statements - object
            Builder builder = new Builder();
            builder.Renovate();
            // (single-line comment) The function basics - object
            Basics basics = new Basics();
            basics.Run();
            // (single-line comment) The reference and out parameter function - object
            RefAndParam refAndParam = new RefAndParam();
            refAndParam.Run();

            // create new object instances using the "new" operator
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825, true);
            Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464, true);
            // call amethod on the obect
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
            // try to set one of the properties, this will result in an error
            // b1._name = "Aldous Huxley"; // 'Book._name' is inaccessible due to its protection level
            b1._published = false;
            Console.WriteLine(b1.GetDescription());
            
            // Every class in c# inherits from Object, which means that every class inherits the ToString() method
            int x = 1000;
            Console.WriteLine(x.ToString());

            // If you don't override the method, the default behavior just prints the name of the class and the namespace
            object a = new object();
            Console.WriteLine(a.ToString());

            Animal animal = new Animal("Jam", "Eating...");
            Console.WriteLine(animal.Action);
            Console.WriteLine(animal);
            Console.WriteLine(animal.Name);
            animal.Name = "Sober";
            animal.Eat();
            Console.WriteLine(animal.Description());
            Console.WriteLine(animal.ToString());

            Dog myDog = new Dog("Fido", "Barking...", "Woof!");
            myDog.Name = "Figo";
            myDog.Eat(); // Inherited from Animal
            myDog.Bark(); // Specific to Dog
            Console.WriteLine(myDog.Description());
            Console.WriteLine(myDog.ToString());
            Console.WriteLine(myDog.ToString('B'));
            Console.WriteLine(myDog.ToString('F'));

            Multiple multiple = new Multiple();
            multiple.Run();
        }
    }
}
