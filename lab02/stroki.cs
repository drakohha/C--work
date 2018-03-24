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
            this.st = "";

            string[] stt;
            stt = s.Split();
            kol_slov = stt.Count();
            int k = 0;
            for (int i = 0; i < kol_slov; i++)
            {
                k = stt[i].Length - 1;
                for (int j = 0; j < stt[i].Length; j++)
                {
                    if (stt[i][j] == stt[i][k - j]) {
                        flag_2 = 1;
                    }
                    else { flag_2 = 0;
                        break;

                    }
                }
                if (flag_2 == 1)
                {
                    this.Kol_palindrom++;
                    flag_2 = 0;
                }
            }




            Console.WriteLine("количество палиндромов = {0} ", this.Kol_palindrom);
            Console.WriteLine("количество полиндромов в процентах= {0} % ", 100 / kol_slov * this.Kol_palindrom);


        }

        public void zaglaf(string s)
        {
            this.st = "";
            int koll = 0;
            string[] stt;
            string stt_hod = "";
            stt = s.Split();
            koll = stt.Count();
            for (int i = 0; i < koll; i++)
            {
                if (stt[i].Length % 2 != 0)
                {
                    stt_hod = Convert.ToString(stt[i][0]);
                    stt_hod = stt_hod.ToUpper();
                    st += stt_hod;
                    for (int j = 1; j < stt[i].Length; j++)
                    {
                        st += stt[i][j];
                    }
                    st += ' ';
                }
            }



            Console.WriteLine("Слова с заглавной буквы с нечет кол елементов ={0} \n ", st);


        }


        public void changle(string s)
        {
            st = "";
            string[] stri;
            stri = s.Split();
            for (int i = stri.Count() - 1; i >= 0; i--)
            {
                st += stri[i] + " ";
            }


            Console.WriteLine("Строка задом наперед \n {0}", st);


        }

        public void chifru(string s)
        {
            st = "";
            string[] stri;
            int k;
            stri = s.Split();
            int[] kol_value = new int[stri.Count()];
            for (int i = 0; i < stri.Count(); i++)
            {
                for (int j = 0; j < stri[i].Length; j++)
                {
                    kol_value[i] += Convert.ToInt32(stri[i][j]);
                }
            }
            int flag = 0;
            while (true)
            {
                flag++;
                for (int i = 0; i < stri.Count() - 1; i++)
                {
                    if (kol_value[i] > kol_value[i + 1])
                    {
                        k = kol_value[i];
                        kol_value[i] = kol_value[i + 1];
                        kol_value[i + 1] = k;
                        st = stri[i];
                        stri[i] = stri[i + 1];
                        stri[i + 1] = st;
                    }
                }
                if (flag >= 10)
                {
                    break;
                }

            }

            st = "";
            foreach (string a in stri)
            {
                st += a;
                st += ' ';
            }
            Console.WriteLine(st);


        }


        public void sortslova(string s)
        {
            string[] str = s.Split();
            int[] kol_slov_posled = new int[str.Count()];
            int co = 0;
            for(int i = 0; i < str.Count(); i++)
            {
                for(int j = 0; j < str[i].Length-1; j++)
                {
                    if (str[i][j] < str[i][j + 1])
                    {
                        co++;
                    }
                    else
                    {
                        if (kol_slov_posled[i] < co)
                        {
                            kol_slov_posled[i] = co;
                        }
                        
                        co = 0;
                    }
                }
                
            }

            int flag = 0;
            int k = 0;
            while (true)
            {
                flag++;
                for (int i = 0; i < str.Count() - 1; i++)
                {
                    if (kol_slov_posled[i] > kol_slov_posled[i + 1])
                    {
                        k = kol_slov_posled[i];
                        kol_slov_posled[i] = kol_slov_posled[i + 1];
                        kol_slov_posled[i + 1] = k;
                        st = str[i];
                        str[i] = str[i + 1];
                        str[i + 1] = st;
                    }
                }
                if (flag >= 10)
                {
                    break;
                }

            }

            st = "";
            foreach (string a in str)
            {
                st += a;
                st += ' ';
            }
            Console.WriteLine(st);


        }

    }
}