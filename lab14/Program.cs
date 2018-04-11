using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfPerson ls = new ListOfPerson();
            //Stream fstream = new FileStream("out.dat", FileMode.Create, FileAccess.Write, FileShare.None);
           // Stream fstream_2 = new FileStream("out.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            ls.AddElement("Федор", "Торговля", "243-55-66");
            ls.AddElement("Михаил", "Производство", "243-66-77");
            ls.AddElement("Леха", "Менеджмент", "243-43-55");
            ls.AddElement("Лена", "Бухгалтерия", "243-77-88");

            ls.ShowInfo(ls);

            string s = "qwer Торговля 243-10-01";
            ls[3] = s;
            ls.ShowInfo(ls);

            Console.WriteLine(ls["Лена"]);
            Console.WriteLine(ls["Лена", "243-77-88"]);
            Console.ReadLine();

            int ind = 0;
            while (true)
            {
                Console.WriteLine("ВЫберете действие : 1- серилизовать в бин файл 2- из бин файла /n 3-в xml файл  4- из xml файла /n 5- в json файл  6 - из json файла");

                ind = Convert.ToInt32(Console.ReadLine());

                if (ind == 0)
                {
                    break;
                }
                if (ind == 1)
                {
                    Stream fstream = new FileStream("out.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                    BinaryFormatter bi = new BinaryFormatter();
           
                     bi.Serialize(fstream, ls);
                    fstream.Close();
                }
                if(ind == 2)
                {
                    Stream fstream_2 = new FileStream("out.dat", FileMode.Open, FileAccess.Read, FileShare.None);
                    BinaryFormatter bi = new BinaryFormatter();
                    ls=(ListOfPerson)bi.Deserialize(fstream_2);
                    fstream_2.Close();
                }



                if (ind == 3)
                {
                    Stream fstream = new FileStream("out.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                    XmlSerializer xs = new XmlSerializer(typeof(ListOfPerson));
                     xs.Serialize(fstream, ls);
                    fstream.Close();

                }
                if(ind == 4)
                {
                    Stream fstream_2 = new FileStream("out.dat", FileMode.Open, FileAccess.Read, FileShare.None);
                    XmlSerializer xs = new XmlSerializer(typeof(ListOfPerson));
                     ls = (ListOfPerson)xs.Deserialize(fstream_2);
                    fstream_2.Close();
                }


                if (ind == 5)
                {
                    Stream fstream = new FileStream("out.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                    DataContractJsonSerializer ir = new DataContractJsonSerializer(typeof(ListOfPerson));
                    ir.WriteObject(fstream, ls);
                    fstream.Close();
                }

                if (ind == 6)
                {
                    Stream fstream_2 = new FileStream("out.dat", FileMode.Open, FileAccess.Read, FileShare.None);
                    DataContractJsonSerializer ir = new DataContractJsonSerializer(typeof(ListOfPerson));
                    ls = (ListOfPerson)ir.ReadObject(fstream_2);
                    fstream_2.Close();

                }
            }


            

            

            
           
            
            

            
           
            
            
           

           

        }

       
    }
}
