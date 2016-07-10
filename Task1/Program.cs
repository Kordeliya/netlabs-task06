using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текстовую строку:");
            string text = Console.ReadLine();
            double result = GetAverageLengthWord(text);
            Console.WriteLine("Средняя длина слова в строке: {0:0.0} символов", result );
            Console.ReadKey();
        }

        /// <summary>
        /// Получить среднюю длину слова в строке
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static double GetAverageLengthWord(string text)
        {
            string[] array = text.Split(".,; ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int sumSymbols = 0;
            foreach(var word in array)
                sumSymbols +=word.Length;
            if (array.Length == 0)
                return 0;
            return (double)sumSymbols / array.Length;
        }
    }
}
