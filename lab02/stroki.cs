using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class stroki
    {
        string st;
        int Kol_palindrom;
        int proc_palindrom;
        string st_2;
        int st_kol_2;
        int flag_2 = 0;
        int kol_slov = 0;


        public stroki(string s)
        {
            this.st = s;
        }

        public void Add(string s)
        {
            this.st = s;
        }

        public void palindrom(string s)
        {
            kol_slov = 0;
            flag_2 = 0;
            st_kol_2 = 0;
            st_2 = "";
            this.st = s;
            foreach(char i in st)
            {
                if(i!=' ' && i!='\0')
                {
                    st_2 += i;
                    st_kol_2++;
                }
                else
                {
                    kol_slov++;
                    for(int j = 0; j < st_kol_2/2; j++)
                    {
                        if (st_2[0 + j] == st_2[st_kol_2 - 1] - j)
                        {
                            flag_2 = 1;
                        }
                        else
                        {
                            flag_2 = 0;
                            break;
                        }

                    }
                    if (flag_2 == 1)
                    {
                        Kol_palindrom++;
                        st_2 = "";
                        st_kol_2 = 0;
                        flag_2 = 0;
                    }
                    else
                    {
                        st_2 = "";
                        st_kol_2 = 0;
                        flag_2 = 0;
                    }
                }
            }

            this.proc_palindrom = kol_slov / 100 * this.Kol_palindrom;

            Console.WriteLine(this.Kol_palindrom);
            Console.WriteLine(this.proc_palindrom);


        }

        public void zaglaf(string s)
        {
            this.st = "";
            int koll = 0;
            string stt="";
            string stt_hod = "";
            foreach(char a in s)
            {
                if(a!=' ' && a!='\0')
                {
                    koll++;
                    stt += a;
                }
                else
                {
                    if (koll % 2 != 0)
                    {
                        stt_hod += stt[0];
                        stt_hod=stt_hod.ToUpper();
                        st += stt_hod;
                        for(int g = 1; g < koll; g++)
                        {
                            st += stt[g];
                        }
                        st += ' ';
                        
                       

                    }
                    koll = 0;
                    stt_hod = "";
                    stt = "";
                    
                }
            }

            Console.WriteLine(st);


        }


        public void changle(string s)
        {
            st = "";
            string[] stri;
            stri= s.Split();
            for (int i = stri.Count()-1; i >= 0; i--)
            {
                st += stri[i]+" ";
            }


            Console.WriteLine(st);


        }

        public void chifru(string s)
        {
            st = "";
            string[] stri;
            stri = s.Split();
            int[] istr;
            
        }

    }
}
