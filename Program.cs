﻿using System;
using HelloWorld;
using DataTypes;
using Operators;
using Flow;

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
        }
    }
}
