using System;
using System.Collections.Generic;

namespace task2
{
    class MyDictionary
    {
        List<KeyValuePair<string, int>> dictionary;
        int numOfMostOftenWords;
        int charInLongestWord;
        public MyDictionary()
        {
            dictionary = new List<KeyValuePair<string, int>>();
        }

        public void SetDictionaryFromList(List<string> words)
        {
            words.Sort(new Comparison<string>((x, y)
                => x.Length > y.Length ? -1 : x.Length == y.Length ? string.Compare(y, x) : 1));

            int indexOfCurrentWord = 0;
            int numOfSameWords = 0;
            string previousWord = words[0];

            words.Add("tail_word"); //cycle below cant add last word in dictionary without this
            foreach (string word in words)
            {
                if (words[indexOfCurrentWord].Equals(previousWord))
                {
                    numOfSameWords++;
                }
                else
                {
                    dictionary.Add(new KeyValuePair<string, int>(previousWord, numOfSameWords));
                    previousWord = words[indexOfCurrentWord];
                    numOfSameWords = 1;
                }
                indexOfCurrentWord++;
            }

            charInLongestWord = dictionary[0].Key.Length;

            dictionary.Sort(new Comparison<KeyValuePair<string, int>>((x, y)
                => x.Value > y.Value ? -1 : x.Value == y.Value ? 0 : 1));

            numOfMostOftenWords = dictionary[0].Value;
        }

        public void FormatDictionary()
        {
            var formatedDictionary = new List<KeyValuePair<string, int>>();
            foreach (var pair in dictionary)
            {
                int newNumOfDots;
                string formatedWord = pair.Key;

                for (int i = pair.Key.Length; i < charInLongestWord; i++)
                    formatedWord = String.Concat("_", formatedWord);

                newNumOfDots = (int)Math.Round(10 * (double)pair.Value / (double)numOfMostOftenWords);

                formatedDictionary.Add(new KeyValuePair<string, int>(formatedWord, newNumOfDots));
            }
            dictionary = formatedDictionary;
        }
        public void PrintDictionary()
        {
            foreach (var word in dictionary)
            {
                Console.Write($"{word.Key} ");
                for (int i = 0; i < word.Value; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
