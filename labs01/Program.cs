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

                Console.WriteLine("\nЗадание номер 1\n");

                Console.WriteLine("Введите числа  для массива А= \n");
                ms.SetValueA();
                Console.WriteLine("Генерируються числа для массива В! \n");
                ms.SetValueB();
                Console.WriteLine("Вывод на экран массив А=\n");
                ms.PrintA();
                Console.WriteLine("\n Вывод на экран массив B=\n");
                ms.PrintB();


                Console.WriteLine("\nЗадание номер 2\n");

                Console.WriteLine("\nПоиск минимального элемента массива А и В=\n");
                int min = ms.FindMin(ms.GetmassA());
                Console.WriteLine("\n минимального элемент массива А = \n");
                Console.WriteLine(min);

                double min_2 = ms.FindMin_2(ms.GetmassB());
                Console.WriteLine("\n минимального элемент массива B = \n");
                Console.WriteLine(min_2);

                Console.WriteLine("\nПоиск максимального элемента массива А и В=\n");
                int max= ms.FindMax(ms.GetmassA());
                Console.WriteLine("\nмаксимальный элемент массива А = \n");
                Console.WriteLine(max);

                double max_2 = ms.FindMax_3(ms.GetmassB());
                Console.WriteLine("\nмаксимальный элемент массива B = \n");
                Console.WriteLine(max_2);

                Console.WriteLine("\nПоиск общей суммы элементов в массивах А и В=\n");

                int sum = ms.Summ(ms.GetmassA());
                double sum_2 = ms.Summ_2(ms.GetmassB());
                Console.WriteLine("\nобщея суммa элементов в массиве А=\n");
                Console.WriteLine(sum);
                Console.WriteLine("\nобщея суммa элементов в массиве B=\n");
                Console.WriteLine(sum_2);

                Console.WriteLine("\nПоиск общего произведения элементов в массивах А и В=\n");
                int pr = 0;
                double pr_2 = 0.0;

                pr = ms.proiz(ms.GetmassA());
                pr_2 = ms.proiz_2(ms.GetmassB());
                Console.WriteLine("\nобщее произведение элементов в массиве А=\n");
                Console.WriteLine(pr);
                Console.WriteLine("\nобщее произведение элементов в массиве B=\n");
                Console.WriteLine(pr_2);


                Console.WriteLine("\nПоиск  суммы четных элементов  массива А =\n");
                ms.Sum_chet_A(ms.GetmassA());
                Console.WriteLine("\nПоиск  суммы нечетных элементов в столбцах массива В =\n");
                ms.Sum_neChet_B(ms.GetmassB());
                Console.WriteLine("\nЗадание номер 3\n");
                Console.WriteLine("Введите числа  для массива M= \n");
                ms.SetValueM();
                Console.WriteLine("Введите числа  для массива N= \n");
                ms.SetValueN();
                Console.WriteLine("Генерируються  массив MN! \n");
                ms.SetValueMN();
                Console.WriteLine("Вывод на экран массив MN=\n");
                ms.PrintMN();

                Console.WriteLine("\nЗадание номер 4\n");

                Console.WriteLine("\n Генерация массива 5х5 с случайными числами \n");
                ms.SetValueTT();
                ms.PrintTT();
                Console.WriteLine("\nПоиск общей суммы элементов между мин и мах елементами =\n");
                min = ms.FindIndexMin(ms.GetmassTT());
                max = ms.FindIndexMax(ms.GetmassTT());
                int summ_3 = ms.summ_3(min , max , ms.GetmassTT());
                Console.WriteLine(summ_3);



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
