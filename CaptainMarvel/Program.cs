using System;
using CaptainMarvel;

namespace CaptainMarvel
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.sum((int) 10.5, 12);
            c.sub(15, 12);
        }
    }
}
