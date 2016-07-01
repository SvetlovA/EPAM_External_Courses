using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для обработки:");
            List<string> _words = Create(Console.ReadLine());
            Output(Matches(_words));

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Create list of words
        /// </summary>
        /// <param name="InputString"> Input string</param>
        /// <returns> List of words</returns>
        static List<string> Create(string InputString)
        {
            string pattern = @"\w+";
            List<string> result = new List<string>();
            foreach (Match item in Regex.Matches(InputString, pattern))
            {
                result.Add(item.Value.ToLower());   
            }
            return result;
        }

        /// <summary>
        /// Matches of words
        /// </summary>
        /// <param name="words"> Input list of words</param>
        /// <returns> Dictionary of unique words</returns>
        static Dictionary<string, int> Matches(List<string> words)
        {
            List<string> helplist = new List<string>();
            helplist.AddRange(words);
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                for (int i = 0; i < helplist.Count; i++)
                {
                    if (word == helplist[i])
                    {
                        int res;
                        if (count.TryGetValue(word, out res))
                        {
                            count[word]++;
                        }
                        else
                        {
                            count.Add(word, 1);
                        }
                        helplist.Remove(helplist[i]);
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Output dictionry
        /// </summary>
        /// <param name="InputDictionary"> Input dictionary</param>
        static void Output(Dictionary<string, int> InputDictionary)
        {
            foreach (var pair in InputDictionary)
            {
                Console.WriteLine("Слово \"{0}\" встречается {1} раз", pair.Key, pair.Value);
            }
        }
    }
}
