using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class EquipmentElement<T> : IComparable
    {
        string name;
        string inv_number;
        T Next;
        DateTime datTime;


        public EquipmentElement(string _name,string _inv_num)
        {
            this.name = _name;
            this.inv_number = _inv_num;
            this.datTime = DateTime.Now;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public  DateTime Gettime()
        {
            return this.datTime;
        }

    }
}
