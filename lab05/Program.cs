using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            int data = 0;
            Calc_kalendar A = new Calc_kalendar(12, 02, 2006);
            A.exc();
            A.ToConsole();
            Calc_kalendar B = new Calc_kalendar(24, 07, 2002);
            B.ToConsole();
             data=A - B;
            Console.WriteLine("Разница между двумя датами {0} дней",data);

            A = A + data;
            A = A + "2";

            A++;
            B--;
            DateTime t1;
            t1 = A.Transeform(A);
            Console.WriteLine(t1);

            Console.ReadLine();
        }
    }
}
