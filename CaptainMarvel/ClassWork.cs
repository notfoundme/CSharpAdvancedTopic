using System;

/// <summary>
/// WAP to create a generic class Calculator that has 2 methods
/// 1. add
/// 2. sub
/// 
/// The Usage of Calculator is as follows:
///     Calculator<int> calculator = new Calculator<int>();
///     calculator.add(2,3); // 5
///     calculator.sub(3, 1); // 2
///     
///     Calculator<float> calculator = new Calculator<float>();
///     calculator.add(2.5,3.6); // 7.1
///     calculator.sub(3.2, 1.2); // 2.0
/// </summary>
namespace CaptainMarvel
{
    class Calculator<T>
    {
        public void sum(T a, T b) {
            Console.WriteLine("sum");
        }
        public void sub(T a, T b)
        {
            Console.WriteLine("Diff");
        }
    }
}
