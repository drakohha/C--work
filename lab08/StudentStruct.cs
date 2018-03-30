using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    struct StudentStruct
    {
        string fio;
        string grup;
        int ysp;

       


        public StudentStruct(string _fio,string _grup,int _ysp)
        {
            this.fio = _fio;
            this.grup = _grup;
            this.ysp = _ysp;
        }



        public bool exist(StudentStruct[] ss, int indx)
        {
            if (ss[indx].fio != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(StudentStruct[] ss, StudentStruct st)
        {
            for (int i = 0; i < ss.Count(); i++)
            {
                if (ss[i].exist(ss, i) == false)
                {
                    ss[i] = st;
                    break;
                }
            }

        }


        public int Find(StudentStruct[] ss, string key)
        {
            int index = -1;

            for (int i = 0; i < ss.Count(); i++)
            {
                if (ss[i].fio == key)
                {
                    return i;
                }
            }

            return index;
        }

        public string Viev(StudentStruct[] ss,int index)
        {
            return ss[index].fio +' '+ ss[index].grup +' '+ss[index].ysp;
        }


    }
}
