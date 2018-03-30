using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class StudentClass
    {
        string fio;
        string grup;
        int ysp;

       
        public StudentClass(string _fio, string _grup, int _ysp)
        {
            this.fio = _fio;
            this.grup = _grup;
            this.ysp = _ysp;
        }

        public bool exist(StudentClass[] ss,int indx)
        {
            if (ss[indx] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(StudentClass[] ss,StudentClass st)
        {
            int index = 0;
            while (true)
            {
                if (ss[index] == null)
                {
                    ss[index] = st;
                    break;
                }
                else
                {
                    index++;
                }

            }
            
            
        }

        public int Find(StudentClass[] ss,string key)
        {
            int index = -1;

            for(int i = 0; i < ss.Count(); i++)
            {
                if (ss[i].fio == key)
                {
                    return i;
                }
            }

            return index;
        }

        public string Viev(StudentClass[] ss, int index)
        {
            return ss[index].fio + ' ' + ss[index].grup + ' ' + ss[index].ysp;
        }

    }
}
