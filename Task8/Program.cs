using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /// <summary>
    /// Проведите сравнительный анализ скорости работы классов String и StringBuilder для операции сложения строк:
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            

            Stopwatch watch = new Stopwatch();
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            watch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            watch.Stop();
            Console.WriteLine("Время в тактах таймера, затраченное при 100 сложениях строк string:{0}", watch.ElapsedTicks);
            watch.Reset();

            watch.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            watch.Stop();
            Console.WriteLine("Время в тактах таймера, затраченное при 100 сложениях строк StringBuilder:{0}", watch.ElapsedTicks);

            Console.ReadKey();

        }
    }
}
