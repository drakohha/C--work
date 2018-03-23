using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Magazin mag = new Magazin("Novii", "bilding 16");
            sklad sk = new sklad(0);
            korzina kr = new korzina();
            while (true)
            {
                Console.WriteLine("Работа магазина : \n 1- добавить новый магазин \n 2-добавить товар \n 3- изменить количесто или цены \n 4-положить товар в корзину\n 0-выход");
                flag = Convert.ToInt32(Console.ReadLine());
                if (flag == 0)
                {
                    break;
                }
                else if (flag == 1)
                {
                    Magazin mg = new Magazin("ToVaRU", "instreet 15");
                }
                else if (flag == 2)
                {
                    Tovar tv_1 = new Tovar("moloko", 15, 1600);
                    sk.Addtovar(15);

                }
                else if (flag == 3)
                {
                    Tovar tv_2 = new Tovar("sholokad", 20, 2000);
                    sk.Addtovar(20);
                    tv_2.AddTovar("sholokad",55,2566);
                    sk.Addtovar(55);
                    Console.WriteLine(tv_2.GetKolTovar()) ;
                }
                else if (flag == 4)
                {
                    kr.AddTovars(15, 2666);
                    sk.Delltovar(15);
                    Console.WriteLine( kr.GetSum_prise() ); 
                }
            }
        }
    }
}
