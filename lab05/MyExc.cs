using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    [Serializable]
    class MyExc : ApplicationException
    {
        public MyExc() { }
        public MyExc(string message) : base(message) { }

    }
}
