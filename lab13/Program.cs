using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.Xml.Linq;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            UserElement ls = new UserElement();

            //XDocument xDoc = XDocument.Load("XMLlist.xml");

            //xDoc.Descendants();
            //Console.WriteLine(xDoc.Descendants());


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLlist.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("id");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
                    if (childnode.Name == "fio")
                    {
                        Console.WriteLine("fio: {0}", childnode.InnerText);
                    }
                    // если узел age
                    if (childnode.Name == "phone")
                    {
                        Console.WriteLine("phone: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
            Console.Read();


        }
    }
}
