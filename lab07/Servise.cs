using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    class Servise:Sklad

    {
        public Servise(string _type, int _prise, int _kol) : base(_type, _prise, _kol)
        {
        }

        public void Sell(Sklad sk,int kol)
        {
            sk.SellAuto(kol);
            Console.WriteLine("Вы приобрели новый авто!");
        }
        public void Velcom()
        {
            Console.WriteLine("Добро пожаловать в наш магазин");
        }


    }
}
