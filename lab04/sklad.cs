using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class sklad : Magaz
    {
        int kol_tov;
        public void Set_kol_tov(int x)
        {
            this.kol_tov = x;
        }
        public  int  Get_kol_tov() 
            {
            return kol_tov;

            }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(Get_kol_tov());
        }

        public sklad(string s):base(s)
        {
            base.SetNameM(s);
        }
    }
}
