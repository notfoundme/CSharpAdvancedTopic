using System;
using CaptainMarvel;

namespace CaptainMarvel
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExample delE = new DelegateExample();

            // Delegate are function pointer.
            // Here, op1 is a delegate that points to sum method of delE
            DelegateExample.op op1 = new DelegateExample.op(delE.sum);
            op1 += delE.diff;
            op1 += delE.diff;
            op1 += delE.sum;
            op1 -= delE.diff;
            // so whenever op1 is called, sum is invoked.
            op1(10, 5);




        }
    }
}
