using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class tovar01:sklad
    {
        string name;
        int prise;

        public  void SetName(string nam)
        {
            this.name = nam;
        }
        public  string GetName()
        {
            return name;
        }
        public void SetPrise(int x)
        {
            this.prise = x;
        }
        public int GetPrise()
        {
            return prise;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(GetName());
            Console.WriteLine(GetPrise());
        }

        public tovar01(string qwerty):base(qwerty)
        {
            base.SetNameM(qwerty);
        }
    }
}
