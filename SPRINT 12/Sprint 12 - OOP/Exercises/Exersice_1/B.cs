using System;

namespace Exersice_1
{
    class B
    {
        string Standaard()
        {
            return "B: Dit is een methode met standaard zichtbaarheid en toegang";
        }

        public string Public()
        {
            return "B: Dit is een publieke methode";
        }

        protected string Protected()
        {
            return "B: Dit is een beschermde methode";
        }

        internal string Internal()
        {
            return "B: Dit is een interne methode";
        }

        private string Private()
        {
            return "B: Dit is een privé methode";
        }

        public void Test()
        {
            Console.WriteLine(Standaard());
            Console.WriteLine(Public());
            Console.WriteLine(Protected());
            Console.WriteLine(Internal());
            Console.WriteLine(Private());
        }
    }
}