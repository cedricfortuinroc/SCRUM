using System;

namespace Exersice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class A testen");
            A a = new A();
            a.Test();
            
            Console.WriteLine("Class B testen vanuit A");
            a.TestB();
        }
    }
}
