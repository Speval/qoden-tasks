using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    class Program
    {
        static void Main()
        {
            List<string> rowWords = Console.ReadLine().Split(' ').ToList();

            var dictionary = new MyDictionary();

            dictionary.SetDictionaryFromList(rowWords);
            dictionary.FormatDictionary();
            dictionary.PrintDictionary();
        }
    }
}
