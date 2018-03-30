using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee em = new Employee("Леха","Кассир");
            Account ak = new Account();

            ak.ev += em.GetMessege;
            ak.ev_2 += em.GetMessege_2;
            ak.ev_3 += em.check;
            ak.AddSum(500);
            ak.Withdraw(251);
            ak.Withdraw(100);

            ak.Withdraw(1000);

            Console.ReadLine(  );

        }
    }
}
