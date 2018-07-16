using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 resultSum = Sum(777777777, 777).Result;
            Console.WriteLine(resultSum);
            Console.ReadKey();
        }
        public static async Task<Int64> Sum(Int64 n1, Int64 n2)
        {
            Int64 fibonacci1 = await Task.FromResult(Fibonacci(n1));
            Int64 fibonacci2 = await Task.FromResult(Fibonacci(n2));

            return fibonacci1 + fibonacci2;
        }
        public static Int64 Fibonacci(Int64 n)
        {
            Int64 x = 0;
            Int64 y = 1;
            for (Int64 i = 0; i < n; i++)
            {
                Int64 temp = x;
                x = y;
                y = temp + y;
            }
            return x;
        }
    }
}
