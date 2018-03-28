using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    class Program
    {
        static void Main(string[] args)
        {

            IAuto it;
            Tovar tv = new Tovar("ферари",1500,7);
            //List<tv> li = new List<tv>;
            it = tv;
            Console.WriteLine(it.GetDescription());
            Sklad sk = new Sklad( "мерседес", 2000,9);
            it = sk;
            Console.WriteLine( it.GetDescription() ); 
            
            Console.WriteLine(it.UserStatus());

            Console.ReadLine();


        }
    }
}
