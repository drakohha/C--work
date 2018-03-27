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
        public Person link = null;
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
                //this.start.index = this.kol_elem;
                stop.index = kol_elem;
                this.stop = stop.next;


            }

        }


        public string this[int indx]
        {
            get
            {
                //Person ob=this.start;
                if (this.link == null)
                {
                    Console.WriteLine("не существует");
                }
                else
                {
                    return this.link.GetValue();
                }
                return null;
                
            }
            set
            {
                if (indx > kol_elem)
                {
                    this.kol_elem++;
                    stop.index = indx;
                    this.stop = stop.next;
                }
                else
                {
                   
                    this.kol_elem++;
                    stop.index = indx + 1;
                    this.stop = stop.next;
                }
            }
        }

        public string this[string _fio]
        {
            get
            {
                string s;
                this.link = this.start;
                for (int i = 0; i < kol_elem; i++)
                {
                    s= start.GetValueFio(_fio);
                    if (s != null)
                    {
                        return s;
                    }
                    else
                    this.link = this.link.next;

                }
                return "none";
            }
            set { }
        }


        public void ShowInfo(ListOfPerson ll)
        {
            this.link = this.start;
            for(int i = 0; i < kol_elem; i++)
            {
                Console.WriteLine(ll[i]);
                this.link = this.link.next;

            }
            
        }


        public string AddElementPoIndexy(string _fio, string _departament, string _phone)
        {
            this.stop.next = new Person(_fio, _departament, _phone);
            return _fio + _departament + _phone;
        }


    }
}
