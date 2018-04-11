using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace lab13
{
    
    [Serializable]
    public class ListOfPerson
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
                
                    string[] ss = value.Split();
                   // this.kol_elem++;
                    this.AddElementPoIndexy(indx, ss[0], ss[1], ss[2]);
                
                
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
                    s= link.GetValueFio(_fio);
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


        public string AddElementPoIndexy(int _index,string _fio, string _departament, string _phone)
        {
            this.link = this.start;
            this.stop.next= new Person(_fio, _departament, _phone);
            this.kol_elem++;
            this.stop.next.index = kol_elem;
            this.stop = this.stop.next;

            for (int i = 0; i < kol_elem; i++)
            {
                if (link.index == _index)
                {
                    this.stop.next = this.link.next;
                    this.link = this.stop;
                    this.stop.next = null;


                    break;
                }
                else
                {
                    this.link = this.link.next;
                }
            }
            
            return _fio + _departament + _phone;
        }


        public string  this[string _fio,string _phone]
        {
            get
            {
                string s;
                this.link = this.start;
                for (int i = 0; i < kol_elem; i++)
                {
                   
                   s = link.GetValueToKey(_fio, _phone);
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


    }
}
