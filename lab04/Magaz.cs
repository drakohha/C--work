using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Magaz
    {
        public Magaz()
        {

        }
        public Magaz(string name)
        {
            
        }
        string _name;
        public void SetNameM(string name)
        {
            this._name = name;
        }
        public string GetNameM()
        {
            return _name;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine(GetNameM());
        }
    }
}
