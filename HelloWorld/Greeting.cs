using System;

namespace HelloWorld
{
    class Greeting
    {
        public void GreetUser()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string str = Console.ReadLine();
            Console.WriteLine("Hello " + str);
        }
    }
}
