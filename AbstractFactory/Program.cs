using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory = new();
            abstractFactory.GetFactory("Dog");
        }
    }
}
