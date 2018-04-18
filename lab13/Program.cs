using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.Xml.Linq;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            UserElement ul = new UserElement();
            ul.GetAll();
            ul.GetByDep();
            Console.Read();


        }
    }
}
