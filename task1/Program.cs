using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int divider = Convert.ToInt32(Console.ReadLine());
            HashTable table = new HashTable(divider);

            string[] input = Console.ReadLine().Split(' ');
            int[] values = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                values[i] = int.Parse(input[i]);
                table.Insert(values[i]);
            }
            table.PrintAllValues();
        }
    }
}
