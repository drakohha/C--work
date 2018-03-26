using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    class Calc_kalendar
    {
        private int dday;

        public int Day
        {
            get { return dday; }
            set { dday = value; }
        }
        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Calc_kalendar(int a_day, int a_month, int a_year)
        {
            dday = a_day;
            month = a_month;
            year = a_year;
        }
        public void ToConsole()
        {
            Console.WriteLine("{0}.{1}.{2}", dday, month, year);
        }
        public void ReadFromConsole()
        {
            Console.Write("Vedite den: ");
            dday = Int32.Parse(Console.ReadLine());
            Console.Write("Vedite mesiac: ");
            month = Int32.Parse(Console.ReadLine());
            Console.Write("Vedite god: ");
            year = Int32.Parse(Console.ReadLine());
        }

        public void exc()
        {
            try
            {
                MyExc ex = new MyExc();
                ReadFromConsole();
                while (true)
                {
                    if (dday <= 0 || dday > 31)
                    {
                        Console.WriteLine("ERROR! Poprobuyte yeshche raz vvesti den: ");
                    }
                    else break;
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("ERROR! Poprobuyte yeshche raz vvesti month: ");
                    }
                    else break;

                }

            }
            catch (MyExc ex)
            {
                if (dday <= 0 || dday > 31)
                {
                    Console.WriteLine(ex.Message);
                    ReadFromConsole();
                }
                if (month<= 0 || month > 12)
                {
                    Console.WriteLine(ex.Message);
                    ReadFromConsole();
                }

            }
        }


    }
}
