using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.Xml.Linq;

namespace lab14
{
    class UserElement
    {
        public string department;
        public string fio;
        public DateTime DateBegin;
        public string phone;

        public List<UserElement> li= new List<UserElement>();

        public void Addelem(string dep,string fio,string phone)
        {
            UserElement u= new UserElement();
            u.DateBegin = DateTime.Now;
            u.department = dep;
            u.fio = fio;
            u.phone = phone;
            li.Add(u);
        }

        public UserElement()
        {

        }

        public void GetAll()
        {
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

                    if (childnode.Name == "fio")
                    {
                        Console.WriteLine("fio: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "phone")
                    {
                        Console.WriteLine("phone: {0}", childnode.InnerText);
                    }
                    if (childnode.Name == "department")
                    {
                        Console.WriteLine("department: {0}", childnode.InnerText);
                    }
                    if (childnode.Name == "DateBegin")
                    {
                        Console.WriteLine("DateBegin: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
        }

        public void GetByDep()
        {
            XmlDocument xDoc = new XmlDocument();
            UserElement u = new UserElement();
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
                    if (attr != null )
                        Console.WriteLine(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                   if(childnode.Name == "fio")
                    {
                        u.fio = childnode.InnerText;
                    }
                    if (childnode.Name == "department" )
                    {
                        u.department= childnode.InnerText;
                    }
                    if (childnode.Name == "phone")
                    {
                       u.phone= childnode.InnerText;
                    }
                    if (childnode.Name == "DateBegin")
                    {
                       //u.DateBegin = childnode.InnerText;
                    }

                    
                    /*
                    if (childnode.Name == "department" && childnode.InnerText == "Админестратор")
                    {
                        Console.WriteLine("department: {0}", childnode.InnerText);
                    }
                    else
                    {
                        continue;
                    }
                    
                       if (childnode.Name == "fio" )
                    {
                        Console.WriteLine("fio: {0}", childnode.InnerText);
                    }

                    if (childnode.Name == "phone" )
                    {
                        Console.WriteLine("phone: {0}", childnode.InnerText);
                    }
                    
                    if (childnode.Name == "DateBegin" )
                    {
                        Console.WriteLine("DateBegin: {0}", childnode.InnerText);
                    }
                    
                    */
                }
                li.Add(u);

                foreach(var i in li)
                {
                    if (i.department == "Админестратор")
                    {
                        Console.WriteLine(i.fio + i.department +i.phone +i.DateBegin);
                    }

                }
                Console.WriteLine();
            }
        }


    }
}
