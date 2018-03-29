using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentStruct[] st = new StudentStruct[100];
            StudentClass[] ss = new StudentClass[100];

            DateTime start = new DateTime();
            start = start.ToLocalTime();
            DateTime stop = new DateTime();
            DateTime rez= new DateTime();

            start = start.ToLocalTime();
            for (int i = 0; i < 100; i++)
            {
                st[i] = new StudentStruct("abc", "125", 8);
            }
            stop = stop.ToLocalTime();

            Console.WriteLine(stop.Millisecond-start.Millisecond);

            start = start.ToLocalTime();
            for (int i = 0; i < 100; i++)
            {
                ss[i] = new StudentClass("abc", "125", 8);
            }
            stop = stop.ToLocalTime();

            Console.WriteLine(stop.Millisecond - start.Millisecond);




            Console.ReadLine();


        }
    }
}
