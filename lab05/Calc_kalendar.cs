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



        public static int operator - (Calc_kalendar k1, Calc_kalendar k2)
        {
            int rezult = 0;
            int rez_ye = 0;
            int rez_mon = 0;
            int rez_dey = 0;



            rez_ye = (k1.year - k2.year);
            if (rez_ye < 0)
            {
               rez_ye= rez_ye * (-1);
            }
            rezult = rezult + rez_ye * 356;

            rez_mon = (k1.month - k2.month);
            if (rez_mon < 0)
            {
                rez_mon = rez_mon * (-1);
            }
            else if (rez_mon == 0)
            {
                rez_mon = 0;
            }
            rezult += rez_mon * 31;

            rez_dey = k1.dday - k2.dday;
            if (rez_dey < 0)
            {
                rez_dey = rez_dey * (-1);
            }
            rezult += rez_dey;
            

            return rezult; 
        }


        public static bool operator !=(Calc_kalendar k1, Calc_kalendar k2)
        {
            bool rez = false;
            if (k1.dday != k2.dday || k1.month != k2.month || k1.year != k2.year)
            {
                rez = true;
            }
            else
            {
                rez = false;
            }
            return rez;
        }

        public static bool operator==(Calc_kalendar k1, Calc_kalendar k2)
        {
            bool rez=false;
            if(k1.dday==k2.dday && k1.month==k2.month && k1.year == k2.year)
            {
                rez = true;
            }
            else
            {
                rez = false;
            }
            return rez;
        }

        /*
        public static Calc_kalendar operator +(Calc_kalendar k1, int data)
        {
            int d = 0;
            d = k1.dday + data;
            int m = 0;
            if (d > 31)
            {
                k1.month+= d / 31;
                k1.dday = d % 31;

                if (k1.month > 12)
                {
                    m = k1.month % 12;
                    k1.year += m;
                    k1.month = k1.month % 12;
                }

            }
            else
            {
                k1.dday = d;
            }


            return k1;
        }
        */

        public static Calc_kalendar operator +(Calc_kalendar k1, int data)
        {
            try
            {
                MyExc ex = new MyExc();
                while (true)
                {
                    if (data>0 && data < 31)
                    {
                        k1.dday += data;
                        if (k1.dday > 31)
                        {
                            k1.month++;
                            k1.dday = k1.dday - 31;
                        }
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Error enter!");
                        break;
                    }
                }
            }
            catch (MyExc ex)
            {
                if (data <= 0 || data > 31)
                {
                    Console.WriteLine(ex.Message);
                    data=Convert.ToInt32(Console.ReadLine()); 
                }


            }
            return k1;
        }
        public static Calc_kalendar operator +(Calc_kalendar k1, string s)
        {

            try
            {
                int data = 0;
                data = Convert.ToInt32(s);
                MyExc ex = new MyExc();
                while (true)
                {
                    if(data<1 && data > 4)
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                    else
                    {
                        k1.dday += data * 7;
                        if (k1.dday > 31)
                        {
                            k1.month++;
                            k1.dday = k1.dday - 31;
                        }
                        break;
                    }
                }


            }
            catch (MyExc ex)
            {
                int data = 0;
                data = Convert.ToInt32(s);
                if (data <= 0 || data > 4)
                {
                    Console.WriteLine(ex.Message);
                    data = Convert.ToInt32(Console.ReadLine());
                }
            }
            return k1;
        }


        public static Calc_kalendar operator ++(Calc_kalendar k1)
        {
            k1.dday++;
            if (k1.dday > 31)
            {
                k1.dday -= 31;
                k1.month++;
                if (k1.month > 12)
                {
                    k1.month -= 12;
                    k1.year++;
                }
            }
            return k1;
        }

        public static Calc_kalendar operator --(Calc_kalendar k1)
        {
            k1.dday--;
            if (k1.dday <= 0)
            {
                k1.dday = 31;
                k1.month--;
                if (k1.month <= 0)
                {
                    k1.month = 12;
                    k1.year--;
                }
            }
            return k1;
        }

        public  DateTime Transeform (Calc_kalendar k1)
        {
            DateTime t1=new DateTime();
            t1.AddDays(k1.dday);
            t1.AddMonths(k1.month);
            t1.AddYears(k1.year);




            return t1;
        }


    }
}
