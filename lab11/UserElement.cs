using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class UserElement<T> : IComparable
    {
        string fio;
        string department;
        string phone;
        DateTime datTime;
        public UserElement<T> Next;

        

        public UserElement(string _fio,string _dep,string _phone)
        {
            this.fio = _fio;
            this.department = _dep;
            this.phone = _phone;
            this.datTime = DateTime.Now;
            

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public DateTime Gettime()
        {
            return this.datTime;
        }


        public void Show()
        {
            Console.WriteLine(this.fio +' ' +this.department +' '+ this.phone +' '+ this.datTime);
        }




    }
}
