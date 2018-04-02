using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
     
            DateTime start = new DateTime();
            DateTime stop = new DateTime();


            work wk = new work();

            start = DateTime.Now;
            wk.Add(); //добавляем одновременно в разные колекции
            stop = DateTime.Now;

            Console.WriteLine(stop-start);

            wk.ShowInfo(); //получение всех елементов колекции


            wk.Add_2("Менежмент", "abcdef", "165309");
            start = DateTime.Now;
            wk.FindFio("abcdef");
            stop = DateTime.Now;
            Console.WriteLine(stop - start);


            wk.sort();

            wk.ShowInfo();

            Console.WriteLine();





            Console.ReadLine();

        }
    }
}
