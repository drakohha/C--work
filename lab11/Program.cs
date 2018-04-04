using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        //delegate T MyDel<T>(T in_par1);
        static void Main(string[] args)
        {
            UserElement<string> r=new UserElement<string>("qweerty","torg","1560235");
            CompanyList<UserElement<string>> li = new CompanyList<UserElement<string>>();
            Interface1<UserElement<string>> it;

            it = li;


            li.AddNewElement(r);
           // li.GetEnumerator();
            foreach (var x in li.GetAllInfo())
            {
                Console.WriteLine(x);

            }
                Console.ReadLine();

        }
    }
}
