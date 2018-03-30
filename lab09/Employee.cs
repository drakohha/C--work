using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    class Employee
    {
        string fio;
        string position;



        public Employee(string _fio,string _position)
        {
            this.fio = _fio;
            this.position = _position;
        }

        public bool check(int sum)
        {
            Console.WriteLine("Менеджер {0} сотрудник отдела {1} принял решение : ",this.fio,this.position);
            int flag = 0;
            Random rnd = new Random();
            flag=rnd.Next(-1, 1);
            if (flag == 0)
                 return false;
            else
                 return true;
            
            
        }



        public void GetMessege(int sum)
        {
            Console.WriteLine("Сумма {0} снята со счета!",sum);
        }

        public void GetMessege_2()
        {
            Console.WriteLine("Недостаточно денег на счете!");
        }

    }
}
