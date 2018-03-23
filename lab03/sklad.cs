using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
   
    class sklad
    {
        public const  int max_size= 1000;
        int tek_size;

        public sklad(int kol_tovar)
        {
            if(this.tek_size+kol_tovar <= max_size)
            {
                this.tek_size += kol_tovar;
            }
            else
            {
                this.tek_size = max_size;
            }
            
        }

        public int GetTekSize()
        {
            return this.tek_size;
        }
        public void Addtovar(int new_kol_tovar)
        {
            if (this.tek_size + new_kol_tovar <= max_size)
            {
                this.tek_size += new_kol_tovar;
            }
            else
            {
                this.tek_size = max_size;
            }
           
        }
        public void Delltovar(int kol)
        {
            if (tek_size >= kol)
            {
                this.tek_size -= kol;
            }
            else
            {
                Console.WriteLine("Exception value");
            }
        }

    }
}
