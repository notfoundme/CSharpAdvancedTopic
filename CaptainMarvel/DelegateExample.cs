using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainMarvel
{
    class DelegateExample
    {
        public delegate void op(int a, int b);

        public void sum(int a, int b) {
            Console.WriteLine(a + b);
        }

        public void diff(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void product(int a, int b)
        {
            Console.WriteLine(a * b);
        }

    }
}
