using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(Path.Combine(Directory.GetCurrentDirectory(),"test.log"), FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.UTF8);


            try
            {
            string str;
            string[] st;
            DirectoryInfo dir1 = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (true)
            {
                Console.WriteLine("Работа с файломи, введите команду");

                str=Console.ReadLine();

                if (str == "ls")
                {

                    Console.WriteLine(dir1.FullName);
                    
                    foreach(var i in dir1.GetFiles())
                    {
                        Console.WriteLine(i);
                    }
                    foreach(var i in dir1.GetDirectories())
                    {
                        Console.WriteLine(i);
                    }

                    writer.Write(str + ' '+ DateTime.Now + "\n");


                }
                if (str == "exit")
                {
                    writer.Write(str + ' ' + DateTime.Now + "\n");
                    break;
                }

                if (str.Contains("cd")==true)
                {
                    try
                    {
                         st = str.Split();
                        if (st.Count() < 2)
                        {
                            throw new MyExc();
                        }
                         DirectoryInfo dir2 = new DirectoryInfo(st[1]);
                         
                         dir1 = dir2;

                    }
                    catch (MyExc)
                    {
                        Console.WriteLine("Eerror enter!");
                    }

                    writer.Write(str + ' ' + DateTime.Now + "\n");
                }

                if (str.Contains("mkdir") == true)
                {
                    try
                    {
                        st = str.Split();
                        if (st.Count() < 2)
                        {
                            throw new MyExc();
                        }
                        Directory.CreateDirectory(st[1]);



                    }
                    catch (MyExc)
                    {
                        Console.WriteLine("Error enter");
                    }
                    writer.Write(str + ' ' + DateTime.Now + "\n");
                }
                if (str.Contains("rmdir") == true)
                {
                    try
                    {
                        st = str.Split();
                        if (st.Count() < 2)
                        {
                            throw new MyExc();
                        }
                        Directory.Delete(st[1]);



                    }
                    catch (MyExc)
                    {
                        Console.WriteLine("Error enter");
                    }
                    writer.Write(str + ' ' + DateTime.Now + "\n");
                }


                if (str.Contains("find") == true)
                {
                    try
                    {
                        st = str.Split();
                        if (st.Count() < 2)
                        {
                            throw new MyExc();
                        }


                        Directory.GetFiles(dir1.FullName);
                        FileInfo[] imageFiles = dir1.GetFiles("*.*", SearchOption.AllDirectories);
                        foreach(var i in imageFiles)
                        {
                            if (i.Name == st[1])
                            {
                                Console.WriteLine(i);
                            }
                        }


                    }
                    catch (MyExc)
                    {
                        Console.WriteLine("Eerror enter!");
                    }
                    writer.Write(str + ' ' + DateTime.Now + "\n");

                }

                if (str.Contains("cat") == true)
                {
                    try
                    {
                        st = str.Split();
                        if (st.Count() < 2)
                        {
                            throw new MyExc();
                        }
                        Console.WriteLine(File.ReadAllText(st[1],Encoding.UTF8));
                        
                    }
                    catch (MyExc)
                    {
                        Console.WriteLine("Error enter");
                    }
                    writer.Write(str + ' ' + DateTime.Now + "\n");
                }


                if (str.Contains("cp") == true)
                {
                    try
                    {
                        st = str.Split();
                        if (st.Count() < 3)
                        {
                            throw new MyExc();
                        }
                        FileInfo fl = new FileInfo(st[1]);
                        fl.CopyTo(st[2]);

                    }
                    catch (MyExc)
                    {
                        Console.WriteLine("Error enter");
                    }
                    writer.Write(str + ' ' + DateTime.Now + "\n");
                }

                if (str.Contains("rm") == true)
                {
                    try
                    {
                        st = str.Split();
                        if (st.Count() < 2)
                        {
                            throw new MyExc();
                        }
                        File.Delete(st[1]);
                    }
                    catch (MyExc)
                    {
                        Console.WriteLine("Error enter");
                    }
                    writer.Write(str + ' ' + DateTime.Now +"\n");
                 }




                }


            writer.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                writer.Close();
            }



            
            
        }

        
    }
}
