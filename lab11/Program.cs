using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
       
        static void Main(string[] args)
        {



            
       
            CompanyList<UserElement<int>> li = new CompanyList<UserElement<int>>();
            CompanyList<EquipmentElement<int>> li2 = new CompanyList<EquipmentElement<int>>();
            UserElement<int> elem = new UserElement<int>("qwerty", "torg", "15224523");
            EquipmentElement<int> e_elem = new EquipmentElement<int>("fedor", "5566");

            Interface1<UserElement<int>> it;
          
            Interface1<EquipmentElement<int>> it2;

            it = li;
            it2 = li2;

            it.AddElem(elem);
            it2.AddElem(e_elem);
            li.AddElement(elem);
            li2.AddElement(e_elem);
            li.AddElement(elem);
            li.AddElement(elem);

            foreach (var i in li)
            {
                Console.WriteLine(li.GetEnumerator());
                
            }
            
            foreach(var i in li2)
            {
                Console.WriteLine(li2.GetDataBetween(DateTime.Now, DateTime.Now));
            }





            Console.ReadLine();

        }
    }
}
