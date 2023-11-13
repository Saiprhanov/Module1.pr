
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module._1.dr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Home work 1

            Console.WriteLine("Введите ваше Ф.И.О.....");

            string name = Console.ReadLine();

            Console.WriteLine("Приветствую вас " + name);

            //Home work 2
            Random random = new Random();
            int[] arry = new int[10];
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                arry[i] = random.Next(1, 20);
                Console.WriteLine(" [" + arry[i] + "] ");
                max += arry[i];
            }
            Console.WriteLine("Сумма чисел = " + max);

        }
    }
}
