using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharp_Yield
{
    class Program
    {
        static IEnumerable<int> GetNumbers(int lbound, int ubound, int maxCount)
        {
            int count = 0;
            for (int i = lbound; i <= ubound; i++)
            {
                
                if (count < maxCount)
                {
                    yield return i;
                }
                else
                {
                    // 跳出整个方法
                    yield break;
                }
                count++;
            }
        }

        static void Main(string[] args)
        {
            var numbers = GetNumbers(1, 100, 10);
            numbers.ToList().ForEach(x => Console.WriteLine(x));
            Console.Read();
        }

    }

}
