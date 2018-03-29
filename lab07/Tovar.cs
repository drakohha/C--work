using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    class Tovar :Avto, IAuto
    {
        string AutoType;
        int AutoPrise;
        int kol;
        public Tovar(string _type, int _prise, int _kol)
        {
            this.AutoType = _type;
            this.AutoPrise = _prise;
            this.kol = _kol;
        }
        public Tovar()
        {

        }

        public string AutoInfo
        {
            get
            {
                return this.AutoType + this.AutoPrise + this.kol;
            }

            set
            {
                string[] ss = value.Split();
                this.AutoType = ss[0];
                this.AutoPrise = Convert.ToInt32(ss[1]);
                this.kol = Convert.ToInt32(ss[2]);
            }
        }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChangePrise(int prise)
        {
            this.AutoPrise = prise;
        }
        public string GetAutoType()
        {
            return this.AutoType;
        }
        public int GetAutoPrise()
        {
            return this.AutoPrise;
        }

        public string GetDescription()
        {
            Console.WriteLine("У нас есть!");
            return this.AutoType + ' ' + this.AutoPrise;
        }

        public string UserStatus()
        {
           return Convert.ToString(this.kol);
        }

        public override void Display()
        {
            Console.WriteLine("Новенькое авто!"); ;
        }

        public virtual void Velcom()
        {
            Console.WriteLine("Новенький товарчик!!");
        }
    }
}
