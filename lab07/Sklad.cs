using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    class Sklad:Tovar
    {
        int kol_auto;

        public Sklad(string _type, int _prise, int _kol) : base(_type, _prise, _kol)
        {
            this.kol_auto = _kol;
        }

        public void AddAuto(int kol)
        {
            this.kol_auto += kol;
        }
        public void SellAuto(int kol)
        {
            this.kol_auto -= kol;
        }

        public string UserStatus()
        {
            Console.WriteLine("Количество имеющихся авто : ");
            return Convert.ToString(kol_auto);
        }


    }
}
