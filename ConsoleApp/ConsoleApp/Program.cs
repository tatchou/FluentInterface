using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program");
            IFluentInterface fluent = new FluentImplementation();

            fluent.DoSomething()
                  .DoSomethingElse()
                  .ThisMethodIsNotFluent();


            Console.WriteLine("End of Program");
            Console.ReadLine();
        }
    }
}
