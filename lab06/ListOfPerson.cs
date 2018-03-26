using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class ListOfPerson
    {


        public Person start=null;
        public Person stop = null;
        public int kol_elem = 0;
        public ListOfPerson()
        {
            
        }
         
        public void AddElement(string _fio, string _departament, string _phone)
        {
            if (this.start == null)
            {
                this.start = new Person( _fio, _departament,  _phone);

                this.kol_elem++;
                this.stop = start;
            }
            else
            {

                this.stop.next = new Person( _fio,  _departament,  _phone);

                this.kol_elem++;

                this.stop = stop.next;


            }

        }


        public string this[int indx]
        {
            get
            {
                Person ob=this.start;
                if (ob == null)
                {
                    Console.WriteLine("не существует");
                }
                else
                {
                    return ob.GetValue();
                }
                return null;
                
            }
            set { }
        }



        public void ShowInfo()
        {
            ListOfPerson ll = new ListOfPerson();
            for(int i = 0; i < kol_elem; i++)
            {
                Console.WriteLine(ll[i]);
            }
            
        }



    }
}
