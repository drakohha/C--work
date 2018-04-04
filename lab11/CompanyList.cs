using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class CompanyList<T> : Interface1<T>
        where T : IComparable
    {
        List<T> l = new List<T>();

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public CompanyList()
        {
            //List<T> nlis = new List<T>();
            
        }
       
        

        public IEnumerator<string> GetEnumerator()
        {
            yield return l.ToString();
        }

        public IEnumerable<string> GetAllInfo()
        {
            for (int i = 0; i < l.Count; i++)
                yield return l[i].ToString();

        }

        public void AddNewElement(T elem)
        {
            
            l.Add(elem);
        }

        public IEnumerable<string> GetDataBetween(DateTime startData, DateTime endData)
        {
            for(int i = 0; i < l.Count; i++)
            {
               // if(l[i].>startData && l[i].datTime < endData)
                {
                    yield return l[i].ToString();
                }
            }
        }

        public T GetInfo()
        {
            
           foreach(var i in l)
            {
                Console.WriteLine(i);
            }
            return l[0];
        }
    }
}
