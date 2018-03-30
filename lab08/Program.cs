using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentStruct[] st = new StudentStruct[10000];
            StudentClass[] ss = new StudentClass[10000];

            Random rnd = new Random();
            
           
           
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 10000; i++)
            {
                StudentStruct sst= new StudentStruct("abc", Convert.ToString(rnd.Next()), 8);
                st[i].Add(st, sst);
            }
            sw.Stop();
            Console.WriteLine( sw.ElapsedMilliseconds );


            StudentStruct sst_2 = new StudentStruct("ggf", Convert.ToString(rnd.Next()), 8);
            st[6742] = sst_2;



            sw.Reset();
            sw.Start();
            for (int i = 0; i < 10000; i++)
            {
                StudentClass sss= new StudentClass("abc", Convert.ToString(rnd.Next()), 8);
                sss.Add(ss,sss);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);


            StudentClass sss_2 = new StudentClass("qqw", Convert.ToString(rnd.Next()), 8);

            ss[6742] = sss_2;

            sw.Reset();
            sw.Start();
            int index = 0;
            index = st[0].Find(st, "ggf");
            Console.WriteLine(st[index].Viev(st,index));
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);


            sw.Reset();
            sw.Start();
            index = 0;
            index = ss[0].Find(ss, "qqw");
            Console.WriteLine(ss[index].Viev(ss, index));
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);




            Console.ReadLine();


        }
    }
}
