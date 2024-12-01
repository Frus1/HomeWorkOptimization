using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOptimization
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
            Dictionary<string, int> wordCounts = WordFrequency(text);

            foreach (var item in wordCounts)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        static Dictionary<string, int> WordFrequency(string text)
        {
            string[] words = text.Split(new[] { ' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
            //Изменён Split, чтобы очистить текст не только от пробелов, но и от точек и запятых.
            //Использован StringSplitOptions.RemoveEmptyEntries, чтобы пустые строки не добавлялись в массив words.

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string cleanedWord = word.Trim().ToLower();

                if (result.ContainsKey(cleanedWord))
                {
                    result[cleanedWord]++;
                }
                else
                {
                    result[cleanedWord] = 1;
                }
            }
            //Заменён цикл for на foreach, так как необходимо только перебрать массив.

            /*
             Dictionary<string, int> sortedResult = new Dictionary<string, int>();
             foreach (var item in result)
             {
                 sortedResult.Add(item.Key, item.Value);
             }
             В исходном коде создаётся sortedResult, который дублирует result. Это не эффективно.
            */

            return result;
        }
    }
}
