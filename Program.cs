using System;
using HelloWorld;
using DataTypes;
using Operators;

namespace csharp_learner
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greet = new Greeting();
            greet.GreetUser();
            Data data = new Data();
            data.Declare();
            Logic logic = new Logic();
            logic.Run();
        }
    }
}
