using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //метод 2
            int[] array = { 25, 3, 5, 17, -9, 16, -23, -8, 12 };
            Array.Sort(array);
            foreach (int elem in array)
            {
                Console.WriteLine($"{elem}");
            }
            Console.WriteLine();
            Array.Reverse(array);
            foreach (int elem in array)
            {
                Console.WriteLine($"{elem}");
            }
            Console.ReadKey();
        }
    }
}
