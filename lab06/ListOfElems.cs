using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class ListOfElems
    {
        public Elem Start=null;
        public Elem Stop = null;
        public void AddElem(int data){
            if (Start == null)
            {
                Start = new Elem(data);
                Stop = Start;
            }
            else {

                Stop.next = new Elem(data);
                Stop = Stop.next;
                
            
            }

        
        }

    }
}
