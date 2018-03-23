using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Tovar
    {
        public const int max_kol_tov = 100;   //использования конст
        int tek_kol_tov;   //инкапсуляция
        readonly string name_tovar;  //использование readonly
        int prise_tovar;

        public Tovar(string _name_tovar,int kol_tov,int prise_tovar)
        {
            this.name_tovar = _name_tovar;
            this.tek_kol_tov = kol_tov;
            this.prise_tovar = prise_tovar;
        }

        public void AddTovar(string _name_tovar,int kol_tov,int _prise_tovar)
        {
            if (this.name_tovar == _name_tovar)
            {
                this.tek_kol_tov += kol_tov;
            }
            else
            {
                new Tovar(_name_tovar, kol_tov, _prise_tovar);
                //this.name_tovar = _name_tovar;
                //this.tek_kol_tov = kol_tov;
                //this.prise_tovar = _prise_tovar;
            }
        }

        public void AddTovar(int kol_tov,int _prise) // перегрузка методов
        {
            this.tek_kol_tov += kol_tov;
            this.prise_tovar = _prise;
        }

        public string GetNameTovar()
        {
            return this.name_tovar;
        }
        public int GetKolTovar()
        {
            return this.tek_kol_tov;
        }
        public int GetPriseTovar()
        {
            return this.prise_tovar;
        }


    }
}
