using System;

namespace Sprint11_Exerc_4
{
    internal class Program
    {
        static readonly Random Random = new Random();
        
        public static void Main(string[] args)
        {
            // Initialize vars
            int min = 10;
            int max = 100;
            int[] array1 = new int[min];
            int[] array2 = new int[min];
            int[] sumArray = new int[min];

            // Loop to fill the arrays            
            for (int i = 0; i < min; i++)
            {
                array1[i] = Random.Next(min, max);
                array2[i] = Random.Next(min, max);
                
                sumArray[i] = array1[i] + array2[i];
            }

            // Display arrays
            DisplayArray(array1);
            DisplayArray(array2);
            DisplayArray(sumArray);
        }
        
        private static void DisplayArray(int[] list)
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString() + "\t");
            }
            Console.WriteLine();
        }
    }
}