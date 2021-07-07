using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {

        private static string ShuffleString(string source, int count)
        {
            int countResultAnswer = 0;
            Console.WriteLine($"Исходная строка: {source}");
            StringBuilder sourceCopy = new StringBuilder();
            sourceCopy.Append(source);
            StringBuilder sbOdd = new StringBuilder();
            StringBuilder sbEven = new StringBuilder();
            string result = null; 
            int resultCount = 0;
            for (int i = count; i > 0; i--)
            {
                int k = 0;
                sbEven.Clear(); sbOdd.Clear();
                foreach (var s in sourceCopy.ToString())
                {
                    k++;
                    if (k % 2 == 0)
                        sbEven.Append(s);
                    else sbOdd.Append(s);
                }
                sourceCopy.Clear();
                sourceCopy.Append(sbOdd.ToString() + sbEven.ToString());
                resultCount++;
                //Console.WriteLine($"Строка после {resultCount}-й итерации: {sourceCopy}");
                if (sourceCopy.ToString() == source.ToString())
                {
                    //i = count % resultCount;
                    i = 0;
                    result = sbOdd.ToString() + sbEven.ToString();
                    Console.WriteLine($"\nСтрока вернулась в исходное состояние, запись в result. Пройдено итераций: {resultCount}\n");
                    countResultAnswer = resultCount;
                }

            }
            Console.WriteLine($"Строки совпали на {countResultAnswer}-й итерации\n");
            Console.WriteLine($"Строка-результат: { result}\n");
            return result.ToString();
        }

        static void Main(string[] args)
        {
            var t = Enumerable.Range(1, 1000).ToArray();
            StringBuilder source = new StringBuilder();
            foreach (var c in t)
            {
                source.Append(c);
            }
            string s = ShuffleString(source.ToString(), int.MaxValue);
            //Console.WriteLine(resultCount);

        }

        
    }
}



