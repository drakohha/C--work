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

            Calc_kalendar A = new Calc_kalendar(12, 02, 2006);
            A.exc();
            A.ToConsole();


            Console.ReadLine();
        }
    }
}
