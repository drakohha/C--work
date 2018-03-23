using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class korzina
    {
        int kol_tov;
        int sum_prise;

        public void AddTovars(int kol_tovar,int prise_tovar)
        {
            this.kol_tov += kol_tovar;
            this.sum_prise += prise_tovar*kol_tovar;
        }

        public int GetKol_tov()
        {
            return this.kol_tov;
        }
        public int GetSum_prise()
        {
            return this.sum_prise;
        }

        public korzina()
        {

        }

        public korzina(int kol,int prise)
        {
            this.kol_tov = kol;
            this.sum_prise = prise;

        }

    }
}
