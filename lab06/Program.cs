using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfPerson ls = new ListOfPerson();

            ls.AddElement("Федор", "Торговля", "243-55-66");
            ls.AddElement("Михаил", "Производство", "243-66-77");
            ls.AddElement("Леха", "Менеджмент", "243-43-55");
            ls.AddElement("Лена", "Бухгалтерия", "243-77-88");

            ls.ShowInfo();
            

            Console.ReadLine();
        }
    }
}
