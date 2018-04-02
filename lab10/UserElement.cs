using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class UserElement:IComparable
    {
        public string department { get; set; }
        public string fio { get; set; }
        public string phone { get; set; }


        public UserElement(string _dep,string _fio,string _phone)
        {
            this.department = _dep;
            this.fio = _fio;
            this.phone = _phone;
        }

        public int CompareTo(object obj)
        {
            return phone.CompareTo(((UserElement)obj).phone);
        }
    }
}
