using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Программа, которая удваивает в первой введенной строки все символы, принадлежащие второй введенной строке.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 стоку:");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Введите 2 стоку:");
            string secondLine = Console.ReadLine();

            string result = GetResultString(firstLine, secondLine);
            Console.WriteLine("Результирующая строка: {0}", result);
            Console.ReadKey();
        }

        /// <summary>
        /// Получение результирующей строки
        /// </summary>
        /// <param name="firstLine">первая строка</param>
        /// <param name="secondLine">вторая строка</param>
        /// <returns></returns>
        private static string GetResultString(string firstLine, string secondLine)
        {
            StringBuilder result = new StringBuilder();
            foreach (var symbol in firstLine)
            {
                foreach (var secondsymbol in secondLine)
                {
                    if (secondsymbol == symbol)
                    {
                        result.Append(symbol);
                        break;
                    }
                }
                result.Append(symbol);
            }
            return result.ToString();
        }
    }
}
