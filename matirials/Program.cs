using System;
using itstep.overloading;


namespace EntryPointOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 8;
            y = y + x;
            int z;
            if (x > y)
            {
                z = x + y;
            }
            UserU u1 = new UserU() { age = 20, fio = "Иванов" };
            UserU u2 = new UserU() { age = 18, fio = "Петров" };
            UserU u3;
            u3 = u1 + u2;
            u3 = u1 + 8;
            u3 += 6;
            u3 += u1;

            z = u3;


        }
    }
}
