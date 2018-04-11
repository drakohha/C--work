using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class CompanyList<T> : Interface1<T>
        where T : IComparable
    {

        public T[] list=new T[100] ;
        public int kol_elem = 0;

        
        


        public int CompareTo(object obj)
        {
            
            throw new NotImplementedException();
        }

        public CompanyList()
        {
           

        }

        public void AddElement(T elem)
        {
            if (kol_elem==0)
            {
                
                this.list[kol_elem] = elem;

                kol_elem++;
                
              
            }
            else
            {
                this.list[kol_elem] = elem;
                kol_elem++;
               
                


            }

        }

        


       

        public IEnumerator<T> GetEnumerator()
        {
            
            foreach(var i in list)
            {
               yield return i;
            }
            
        }
 
        public IEnumerable<T> GetDataBetween(DateTime startData, DateTime endData)
        {
            int per = 0;
            int per_2 = 0;
            foreach(var i in list)
            {
                per= i.CompareTo(startData);
                per_2 = i.CompareTo(endData);
                if(per>=0 && per_2 <=0)
                    yield return i;
            }

        }

        public void GetInfo()
        {
            foreach(var i in list)
            {
                
            }
          
            
        }
        public  void AddElem(T elem)
        {
            if (this.kol_elem == 0)
            {
                this.list[kol_elem] = elem;

                this.kol_elem++;


            }
            else
            {
                this.list[kol_elem] = elem;
                this.kol_elem++;




            }
        }

        



    }
}
