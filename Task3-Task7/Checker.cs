using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3_Task7
{
    /// <summary>
    /// Класс проверок
    /// </summary>
    public static class Checker
    {
        /// <summary>
        /// Проверяет включает ли в себя строка дату формата dd-mm-yyyy
        /// </summary>
        /// <param name="text">строка</param>
        /// <returns></returns>
        public static bool IsIncludeDate(string text)
        {
            string pattern = @"\b(\d{2}\-\d{2}\-\d{4})";
            Regex regex = new Regex(pattern);

            // Получаем совпадения в экземпляре класса Match
            Match match = regex.Match(text);
            if (match.Success)
            {
                foreach (var date in match.Groups)
                {
                    int day = 0;
                    int month = 0;
                    int year = 0;
                    string[] numbers = date.ToString().Split('-');

                    if (Int32.TryParse(numbers[0], out day) && Int32.TryParse(numbers[1], out month)
                        && Int32.TryParse(numbers[2], out year))
                    {
                        if (day <= 31 && month <= 12)
                            return true;
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// Проверяет включает ли в себя строка email
        /// </summary>
        /// <param name="text">строка</param>
        /// <param name="emails">возращаемый список emails</param>
        /// <returns></returns>
        public static bool IsIncludeEmails(string text, out List<string> emails)
        {
            emails = new List<string>();
            string pattern = @"([A-Za-z0-9]+)([A-Za-z0-9_\-\.])*[A-Za-z0-9]+@([A-Za-z0-9]+)([A-Za-z0-9_\-])*(\.([A-Za-z0-9]+)([A-Za-z0-9_\-])*[A-Za-z0-9]+)*\.[a-z]{2,6}";
            Regex regex = new Regex(pattern);

            string[] lines = text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach(var line in lines)
            {
                Match match = regex.Match(line);
                if (match.Success && match.Groups.Count> 0)
                {
                    emails.Add(match.Groups[0].ToString());
                }
            }
            if (emails.Count > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Проверяет является ли вещественное число написанным в научной нотации
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsScientificNumber(string text)
        {
            string pattern = @"([\-0-9])+([0-9])*(\.[0-9]*)[e*]*([0-9])*([0-9,])*[\-[\.0-9]*]*";
            Regex regex = new Regex(pattern);

            // Получаем совпадения в экземпляре класса Match
            Match match = regex.Match(text);
            if (match.Success)
                return true;
            return false;
        }

        /// <summary>
        /// Проверяет включает ли в себя время строка
        /// </summary>
        /// <param name="text">строка</param>
        /// <param name="number">возвращаемый параметр:количество времен в строке</param>
        /// <returns></returns>
        public static bool IsIncludeTimes(string text, out int number)
        {
            number = 0;
            string pattern = @"([0-9]{1,2}):([0-9]{2})";
            Regex regex = new Regex(pattern);

            string[] lines = text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                Match match = regex.Match(line);
                if (match.Success && match.Groups.Count > 0)
                {
                    int hour;
                    int minutes;
                    string[] numbers = match.Groups[0].ToString().Split(":".ToCharArray());
                    Int32.TryParse(numbers[0],out hour);
                    Int32.TryParse(numbers[1], out minutes);
                    if (hour < 24 && minutes < 60)
                        number++;
                }
            }
            if (number > 0)
                return true;

            return false;
        }
    }
}
