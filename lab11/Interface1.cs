using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    interface Interface1<T>
        where T : IComparable
    {
        T GetInfo();
    }
}
