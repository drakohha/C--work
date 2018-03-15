using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Mass ms = new Mass();
            while (true)
            {

                Console.WriteLine("Введите числа  для массива А= \n");
                ms.SetValueA();
                Console.WriteLine("Генерируються числоа для массива В! \n");
                ms.SetValueB();
                Console.WriteLine("Вывод на экран массив А=\n");
                ms.PrintA();
                Console.WriteLine("\n Вывод на экран массив B=\n");
                ms.PrintB();

                Console.WriteLine("\n Закончить - 0 повторить - 1\n");
                flag = Convert.ToInt32( Console.ReadLine());
                if (flag == 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

          

          


           
        }
    }
}
