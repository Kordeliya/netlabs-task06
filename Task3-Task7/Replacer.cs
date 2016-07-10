using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Task7
{
    public static class Replacer
    {
        /// <summary>
        /// Заменяет теги на _
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReplaceTags(string text)
        {
            int openTagText = text.IndexOf("<");
            int closeTag = 0;
            while (openTagText != -1)
            {
                closeTag = text.IndexOf(">");
                int count = closeTag - openTagText + 1;
                text = text.Remove(openTagText, count);
                text = text.Insert(openTagText, "_");

                openTagText = text.IndexOf("<");
            }
            return text;
        }
    }
}
