using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            stroki str = new stroki("new");
           Console.WriteLine("Введите строку");
           str.palindrom(Console.ReadLine());
           Console.WriteLine("Введите строку");
            str.zaglaf(Console.ReadLine());
            Console.WriteLine("Введите строку");
            str.changle(Console.ReadLine());
             Console.WriteLine("Введите строку из цифр");
             str.chifru(Console.ReadLine());
            Console.WriteLine("Введите строку");
            str.sortslova(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
