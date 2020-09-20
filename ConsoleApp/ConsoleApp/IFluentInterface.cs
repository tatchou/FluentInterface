using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public interface IFluentInterface
    {
        IFluentInterface DoSomething();
        IFluentInterface DoSomethingElse();
        void ThisMethodIsNotFluent();
    }

    public class FluentImplementation : IFluentInterface
    {
        public IFluentInterface DoSomething()
        {
            Console.WriteLine("Do Something");
            return this;
        }

        public IFluentInterface DoSomethingElse()
        {
            Console.WriteLine("Do Something else");
            return this;
        }

        public void ThisMethodIsNotFluent()
        {
            Console.WriteLine("Break fluent Pattern");
        }
    }
}
