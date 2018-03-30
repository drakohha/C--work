using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    public delegate void MyEvent(int in_v);
    public delegate void MyEvent_2();

    public delegate bool MyEvent_3(int sum);

    class Account
    {
        public event MyEvent ev;
        public event MyEvent_2 ev_2;
        public event MyEvent_3 ev_3;
        int _sum;
        public void Withdraw(int sum)
        {
            if (this._sum >= sum)
            {
                if (sum > this._sum / 2)
                {
                    if (ev_3(sum) == true)
                    {
                        this._sum -= sum;
                        ev(sum);
                    }
                    else
                    {
                        Console.WriteLine("Отклонено!");

                    }

                }
                else
                {
                    this._sum -= sum;
                    ev(sum);
                }

            }
            else
            {
                ev_2();
            }
            
        }

        public void AddSum(int sum)
        {
            this._sum += sum;
        }

        public int GetSum()
        {
            return this._sum;
        }

    }
}
