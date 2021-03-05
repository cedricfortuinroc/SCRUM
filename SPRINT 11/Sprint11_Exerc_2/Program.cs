using System;

namespace Sprint11_Exerc_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int enno;
            
            Console.WriteLine("Fill in the max number of the calculation: ");
            // Receive the max number of the string
            enno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");

            // Run the calculation
            checkPrimeWithLength(enno);
        }

        private static void checkPrimeWithLength(int enno)
        {
            int num, i, ctr;

            for (num = 2; num <= enno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                {
                    Console.WriteLine($"{num}");
                }
            }
            Console.WriteLine("\n");
        }
    }
}