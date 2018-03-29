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
            try
            {
                this.kol_auto -= kol;
                if (this.kol_auto < 0)
                {
                    throw new MyExc() ;
                }
            }
            catch (MyExc)
            {
                Console.WriteLine("ERROR! not inaf tovar in sklad");
                this.kol_auto += kol;
            }
            
        }

        public string UserStatus()
        {
            Console.WriteLine("Количество имеющихся авто : ");
            return Convert.ToString(kol_auto);
        }

        public Sklad()
        {

        }

        public override void Velcom()
        {
            Console.WriteLine("это наш склад!!");
        }

    }
}
