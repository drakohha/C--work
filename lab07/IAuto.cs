using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    interface IAuto: IAcaunt
    {
        String GetDescription();
        String AutoInfo { get; set; }


    }
}
