using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class work
    {
        static Random random = new Random();
        List<UserElement> li = new List<UserElement>();
        Dictionary<int, UserElement> di = new Dictionary<int, UserElement>();

        string a = $"{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}";
        string number = $"{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}";


        public void Add()  // рандомное добавление в каждую колекцию
        {
            for (int i = 0; i < 100; i++)
            {
                a = $"{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}{(char)random.Next(60, 100)}";
                number = $"{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}";
                UserElement ue = new UserElement("dep",a, number);
                li.Add(ue);
                di.Add(i, ue);
            }
        }


        public void FindFio(string _fio)
        {
            foreach(var i in li)
            {
                if (i.fio == _fio)
                {
                    Console.WriteLine(i.department +' '+ i.fio+ ' '+ i.phone);
                    break;
                }
            }
        }


        public void Add_2(string dep,string fio,string num) //одиночное добавление в каждую колекцию
        {
            UserElement ue = new UserElement(dep, fio, num);
            li.Add(ue);
            di.Add(101, ue);
        }


        public void ShowInfo()
        {
            foreach(var i in li)
            {
                Console.WriteLine(  i.department +' ' +i.fio +' ' +i.phone ); 
            }

        }

        public void sort()
        {
            li.Sort();
            
        }




    }
}
