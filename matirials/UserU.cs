using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itstep
{
    namespace overloading{
 

         public   class UserU
            {
                public int age;
                public string fio;
                public static UserU operator +(UserU x, UserU y)
                {
                    UserU tempOb = new UserU();
                    tempOb.fio = "not defined";
                    tempOb.age = (x.age + y.age) / 2;
                    return tempOb;
                }
                /* public static UserU operator +(UserU x, int y)
                 {
                     x.age += y;
                     return x;
                 }*/
                public static UserU operator +(UserU x, int y)
                {
                    UserU tempOb = new UserU();
                    tempOb.fio = "not defined";
                    tempOb.age = x.age + y;
                    return tempOb;
                }
                public static implicit operator int(UserU x)
                {

                    return x.age;
                }
            }
        }

    
}
