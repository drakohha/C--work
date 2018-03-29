using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    class User:IAcaunt
    {
        string name;
        Servise sv;
        public User()
        {
            sv = new Servise();
        }

        public string UserName { get { return this.name; } set { this.name = value; } }

        public void ByTovar(Tovar tv)
        {

        }
        public void FindTovar(string type)
        {

        }

        public string UserStatus()
        {
            return "status";
        }
    }
}
