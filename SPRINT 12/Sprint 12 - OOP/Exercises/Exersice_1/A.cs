using System;

namespace Exersice_1
{
    class A
    {
        string Standaard()
        {
            return "A: Dit is een methode met standaard zichtbaarheid en toegang";
        }

        public string Public()
        {
            return "A: Dit is een publieke methode";
        }

        protected string Protected()
        {
            return "A: Dit is een beschermde methode";
        }

        internal string Internal()
        {
            return "A: Dit is een interne methode";
        }

        private string Private()
        {
            return "A: Dit is een privé methode";
        }

        public void Test()
        {
            Console.WriteLine(Standaard());
            Console.WriteLine(Public());
            Console.WriteLine(Protected());
            Console.WriteLine(Internal());
            Console.WriteLine(Private());
        }
        
        public void TestB()
        {
            B b = new B();
            Console.WriteLine(b.Standaard());
            Console.WriteLine(b.Public());
            Console.WriteLine(b.Protected());
            Console.WriteLine(b.Internal());
            Console.WriteLine(b.Private());
        }
    }
}