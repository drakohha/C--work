using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Magaz m1 = new Magaz();
            Magaz m2 = new Magaz("first");

            kassa st = new kassa("second");

            
            st.SetName("tovat odin");
            // Console.WriteLine(st.GetName());
            //Console.WriteLine(st.GetNameM());
            st.SetPrise(100);
            st.Set_kol_tov(500);
            st.summ();

            st.ShowInfo();
            */
            int flag = 0;
            kassa st = new kassa("fisrt");
            while (true)
            {
                Console.WriteLine("\n Выбирете действие: 1- вывод всей инфо  2-изменить значения 0-выход \n");
                flag= Convert.ToInt32( Console.ReadLine());

                if (flag == 0)
                {
                    break;
                }
                else if (flag == 1)
                {
                    st.ShowInfo();   
                }
                else if (flag == 2)
                {
                    st.SetName("tovat odin");
                    st.SetPrise(100);
                    st.Set_kol_tov(500);
                    st.summ();
                }
            }


            Console.ReadLine();





        }
    }
}
