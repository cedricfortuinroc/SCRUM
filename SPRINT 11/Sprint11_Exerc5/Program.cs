using System;

namespace Sprint11_Exerc5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Make the array
            int[] array = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= array.Length - 2; j++) {
                for (int i = 0; i <= array.Length - 2; i++) {
                    if (array[i] > array[i + 1]) {
                        temp= array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            
            // Print the sorted array
            Console.WriteLine("Sorted arrayay:");
            foreach (int p in array)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}