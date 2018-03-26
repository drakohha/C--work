using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class Person
    {
        string fio;
        string departament;
        string phone;
        public int index=0;

        public Person(string _fio, string _departament,string _phone)
        {
            this.fio = _fio;
            this.departament = _departament;
            this.phone = _phone;
           
        }

        public string this[string _fio, string _departament, string _phone]
        {
            get
            {
                return this.fio + this.departament + this.phone;
            }
            set
            {
                this.fio = _fio;
                this.departament = _departament;
                this.phone = _phone;
            }
        }

       

        public string this[int _index]
        {
            get
            {
                if (this.index == _index)
                {
                    return this.fio +' '+ this.departament +' '+ this.phone;
                }
                return "null";
            }
            set
            {
                
            }
        }

        public string GetValue()
        {
            return this.fio + ' ' + this.departament + ' ' + this.phone;
        }


        public Person next = null;
    }
}
