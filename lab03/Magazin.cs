using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Magazin
    {
        string magaz_name;
        string magaz_adris;

        public Magazin()
        {
                
        }

        public Magazin(string _magaz_name)
        {
            this.magaz_name = _magaz_name;
        }

        public Magazin(string _magaz_name,string _magaz_adris)
        {
            this.magaz_name = _magaz_name;
            this.magaz_adris = _magaz_adris;
        }

        public string GetName()
        {
            return magaz_name;
        }
        public string GetAdr()
        {
            return this.magaz_adris;
        }

        public void SetName(string s)
        {
            this.magaz_name = s;
        }
        public void SetAdr(string s)
        {
            this.magaz_adris = s;
        }


    }
}
