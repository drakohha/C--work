using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class kassa:tovar01
    {
        int sum_tovarov;

        public void SetSum(int x)
        {
            this.sum_tovarov = x;
        }
        public int GetSum()
        {
            return sum_tovarov;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(GetSum());
        }

        public kassa(string s):base(s)
        {
            base.SetNameM(s);
        }

        public void summ()
        {
            sum_tovarov = base.Get_kol_tov() * base.GetPrise();
        }
    }
}
