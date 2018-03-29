using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    class Admin:IAcaunt
    {
        string name;
        Sklad sk;

        public Admin(Sklad _sk)
        {
            sk = _sk;
        }
        public string UserName { get { return this.name; } set { this.name = value; } }

        public void AddTovar(Tovar tv)
        {

        }
        public void DellTovar(Tovar tv)
        {

        }
        public void FormatTovar(Tovar tv)
        {

        }

        public string UserStatus()
        {
            return "new tatus";
        }
    }
}
