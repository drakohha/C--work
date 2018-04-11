using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    class UserElement
    {
        public string department;
        public string fio;
        public DateTime DateBegin;
        public string phone;

        public List<UserElement> li= new List<UserElement>();

        public void Addelem(string dep,string fio,string phone)
        {
            UserElement u= new UserElement();
            u.DateBegin = DateTime.Now;
            u.department = dep;
            u.fio = fio;
            u.phone = phone;
            li.Add(u);
        }

        public UserElement()
        {

        }

        public void GetAll()
        {
            foreach(var i in li)
            {
                Console.WriteLine(i.fio+' '+i.department +' ' + i.phone + ' ' + i.DateBegin);


            }
        }



    }
}
