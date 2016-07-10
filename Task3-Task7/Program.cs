using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 Задание
            string result;
            Console.WriteLine("Введите текст, содержащий дату в формате dd-mm-yyyy: ");
            string text = Console.ReadLine();
            if (Checker.IsIncludeDate(text))
                Console.WriteLine("В тексте: \"{0}\" содержится дата.", text);
            else
                Console.WriteLine("В тексте: \"{0}\" НЕ содержится дата.", text);
            Console.WriteLine();

            //4 Задание
            Console.WriteLine("Введите HTML текст: ");
            text = Console.ReadLine();
            result = Replacer.ReplaceTags(text);
            Console.WriteLine("Результат замены: {0}", result);
            Console.WriteLine();

            //5 Задание
            Console.WriteLine("(Определяем есть ли email в тексте) Введите строку: ");
            text = Console.ReadLine();
            //test = "ivan@mail.ru, Петр: p_ivanov@mail.rol.ru u-yt568--@email.ru u-yt568@email.ru  ---dhghf@mail.ru.ru";
            List<string> results;
            Console.WriteLine("Найденные адреса электронной почты:");
            if (Checker.IsIncludeEmails(text, out results))
                foreach(var item in results)
                    Console.WriteLine(item);
            Console.WriteLine();

            //6 Задание
            Console.WriteLine("(Опредляем нотацию ввода)Введите число: ");
            text = Console.ReadLine();
            double number;
            if (Double.TryParse(text, out number))
                Console.WriteLine("Это число в обычной нотации");
            else if (Checker.IsScientificNumber(text))
                Console.WriteLine("Это число в научной нотации");
            else
                Console.WriteLine("Это не число");
            Console.WriteLine();

            //7 Задание
            int timeCount;
            Console.WriteLine("(Определяем есть ли время в тексте) Введите текст: ");
            text = Console.ReadLine();
            Checker.IsIncludeTimes(text, out timeCount);
            Console.WriteLine("Время в тексте присутствует {0} раз.", timeCount);
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
